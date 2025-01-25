Imports System
Imports System.IO
Imports System.IO.Compression

Public Class frm_scenario_maker

    ' ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    ' let's initialize these variables globally so we don't have to worry about scope...
    ' note: I made everything public as well...
    ' note: hopefully, the user has enough space/memory... can't use a try catch here...

    Dim scenario_file_path As String = "" ' ofd_scenario / sfd_scenario (string path)
    Dim aoe2de_file_path As String = "" ' ofd_aoe2de_path (string path)
    Dim map_size_standard As Integer = 0 ' cbx_map_size (index value)
    Dim map_tile_size As Integer = 0 ' nud_mwh_size (35 to 480)
    Dim default_terrain As Integer = 0 ' cbx_default_terrain (index value)
    Dim ai_type As Integer = 0 ' cbx_ai_map_type (index value)
    Dim color_mood As Integer = 0 ' cbx_color_mood (index value)
    Dim team_positions As Boolean = True ' cbx_team_positions (true/false)
    Dim script_filename As String = "" ' tbx_script_filename (text value)
    ' space for terrain...
    Dim player_count As Integer = 1 ' cbx_total_players (index value)
    Dim starting_age As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' cbx_gaia_age, cbx_p1_age, ... cbx_p8_age (index value)
    Dim starting_food As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' nud_food_gaia, nud_food_p1, ... nud_food_p8 (index value)
    Dim starting_wood As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' nud_wood_gaia, nud_wood_p1, ... nud_wood_p8 (index value)
    Dim starting_stone As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' nud_stone_gaia, nud_stone_p1, ... nud_stone_p1 (index value)
    Dim starting_gold As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' nud_gold_gaia, nud_gold_p1, ... nud_gold_p8 (index value)
    Dim starting_population As Integer() = {200, 200, 200, 200, 200, 200, 200, 200, 200} ' nud_population_gaia, nud_population_p1, ... nud_population_p8 (index value)
    Dim priority As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' nud_priority_gaia, nud_priority_p1, ... nud_priority_p8 (index value)
    Dim player_color As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' cbx_color_gaia, cbx_color_p1, ... cbx_color_p8 (index value)
    Dim tribe_name As String() = {"", "", "", "", "", "", "", "", ""} ' tbx_tribe_name_gaia, tbx_tribe_name_p1, ... tbx_tribe_name_p8 (text string)
    ' note: I know this can be a string but, I am going to assume integer...
    Dim tribe_string_id As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' tbx_name_string_id_gaia, tbx_name_string_id_p1, ... tbx_name_string_id_p8 (text string to integer)
    Dim ai_or_player As Boolean() = {False, False, False, False, False, False, False, False, False} ' cbx_ai_gaia, cbx_ai_p1, ... cbx_ai_p8
    ' space for units...
    ' important note: Listboxes are limited to 32766 characters! I don't recommend using if you can help it.
    ' space for diplomacy...
    ' space for victory...
    ' space for options...
    ' space for messages...
    ' space for cinematics...
    ' space for triggers...
    ' space for about...? (may not need.)

    ' ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    ' here is an example function call that I would use in a seperate program. also, here is where I got/found the code. many thanks.

    ' source: http://pont.ist/vbnet-compress-decompress-byte-array/

    ' F_Compress_File("D:\scenario_tests\_ALL_SCENARIO_STUFF_OBJECTS_MINUS_HEADER_EDIT_TRIGGERS.aoe2scenario", "D:\scenario_tests\_ALL_SCENARIO_STUFF_OBJECTS_MINUS_HEADER_EDIT_TRIGGERS_OUTPUT.aoe2scenario")
    ' F_Decompress_File("D:\scenario_tests\_ALL_SCENARIO_STUFF_OBJECTS_MINUS_HEADER_OUTPUT.aoe2scenario", "D:\scenario_tests\_ALL_SCENARIO_STUFF_OBJECTS_MINUS_HEADER.aoe2scenario") ' we need to reverse this...

    ' Rough Explanation: When a scenario is created in AoE2DE, it is compressed. You will have to decompress it to view it's real contents.
    ' First, you will have to remove the 'header' section. (You do need to save this. It is still important. Although, it may change depending on what you change.)
    ' You can refer to this: https://github.com/KSneijders/AoE2ScenarioParser/tree/fc1444956e21fd949158365ecd597f5b98afeeed/AoE2ScenarioParser/versions/DE
    ' You may want to use a hex editor of some kind. I use HxD: https://mh-nexus.de/en/hxd/
    ' I am also going to include a file called: BYTE_NOTES.txt (This is a bit useful if you need some help with how this works. You may need to do research if you do not.)
    ' the 'header' section is generally a bit after the creators name so, you can see this visually in a text editor.
    ' If you remove this section of the bytes, you can then decompress the scenario and see it's actual content.
    ' Note: Yes, you will still see data/bytes in the file afterwords. That is normal. From here, you would have to follow the format, make changes carefully,
    ' and re-add the 'header' section. (If you change anything related to the header in there, you will also have to change those bytes too...)
    ' Once you are done with this, you can compress the scenario and then add the header back in to the top of the file.
    ' You should be able to load the scenario. If you made any mistakes, you may not be able to.

    Function F_Decompress_File(my_in_file As String, my_out_file As String) As Object

        Dim toDecompress As Byte()
        Dim nowDecompressed As Byte()
        toDecompress = File.ReadAllBytes(my_in_file)

        Using inputStream As New MemoryStream(toDecompress)

            Using outputStream As New MemoryStream()

                Using decompressionStream As New DeflateStream(inputStream, CompressionMode.Decompress)

                    decompressionStream.CopyTo(outputStream)

                End Using

                nowDecompressed = outputStream.ToArray

            End Using

        End Using

        File.WriteAllBytes(my_out_file, nowDecompressed)
        Return Nothing

    End Function

    Function F_Compress_File(my_in_file As String, my_out_file As String) As Object

        Dim toCompress As Byte()
        Dim nowCompressed As Byte()
        toCompress = File.ReadAllBytes(my_in_file)

        Using inputStream As New MemoryStream(toCompress)

            Using outputStream As New MemoryStream()

                Using compressionStream As New DeflateStream(outputStream, CompressionMode.Compress)

                    inputStream.CopyTo(compressionStream)

                End Using

                nowCompressed = outputStream.ToArray()
                File.WriteAllBytes(my_out_file, nowCompressed)

            End Using

        End Using

        Return Nothing

    End Function

    ' ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    ' [APPLICATION LOAD CODE] ------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub frm_scenario_maker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' on startup, be sure to define all your variables and reset all gui to a vaild minimum scenario...
        Try
            ' variables/GUI stuff goes here...

        Catch ex As Exception
            MessageBox.Show("An error occured while trying to create variables. Hard Drive/Memory Full?")
        End Try
    End Sub

    ' [TAB: FILE CODE] -------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub btn_new_scenario_Click(sender As Object, e As EventArgs) Handles btn_new_scenario.Click
        ' on clicking new, be sure to define all your variables and reset all gui to a vaild minimum scenario...
        Try
            ' varables/GUI stuff goes here...

        Catch ex As Exception
            MessageBox.Show("An error occured while trying to create variables. Hard Drive/Memory Full?")
        End Try
    End Sub
    Public Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ' on click save, this will open the save file dialog window. write code here to save the scenario...
        sfd_scenario.ShowDialog()
        ' note: you can use lbl_save_path.Text to show the path if you want or whatever...
        Try
            ' save scenario code goes here...

        Catch ex As Exception
            MessageBox.Show("An error occured while trying to save scenario. Hard Drive/Memory Full/Incorrect File?")
        End Try
    End Sub
    Public Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        ' on click load, this will open the load file dialog window. write code here to load the scenario...
        ofd_scenario.ShowDialog()
        ' note: you can use lbl_load_path.Text to show the path if you want or whatever...
        Try
            ' load scenario code goes here...

        Catch ex As Exception
            MessageBox.Show("An error occured while trying to load scenario. Permission Issue/Incorrect File?")
        End Try
    End Sub
    Public Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        ' on click test, this will 'attempt' to load the scenario editor in AoE2DE... (add argument 'EDITOR')
        ' you will have to find the games executable yourself. I don't want to deal with this personally...
        ofd_aoe2de_path.ShowDialog()
        Try
            Process.Start("" + ofd_aoe2de_path.FileName, "EDITOR")
        Catch ex As Exception
            MessageBox.Show("An error occured while trying to launch AoE2DE's Editor. Permission Issue/Wrong Executable/Cancelled?")
        End Try
    End Sub

    ' [TAB: MAP CODE] --------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub cbx_map_size_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_map_size.SelectedIndexChanged

    End Sub

    Public Sub nud_mwh_size_ValueChanged(sender As Object, e As EventArgs) Handles nud_mwh_size.ValueChanged

    End Sub

    Public Sub cbx_default_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_default_terrain.SelectedIndexChanged

    End Sub

    Public Sub cbx_ai_map_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_ai_map_type.SelectedIndexChanged

    End Sub

    Public Sub cbx_color_mood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_mood.SelectedIndexChanged

    End Sub

    Public Sub cbx_team_positions_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_team_positions.CheckedChanged

    End Sub

    Public Sub tbx_script_filename_TextChanged(sender As Object, e As EventArgs) Handles tbx_script_filename.TextChanged

    End Sub

    ' [TAB: TERRAIN CODE] ----------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub lbx_base_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_base_terrain.SelectedIndexChanged

    End Sub

    Public Sub lbx_layer_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_layer_terrain.SelectedIndexChanged

    End Sub

    Public Sub lbx_x_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_x_terrain.SelectedIndexChanged

    End Sub

    Public Sub lbx_y_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_y_terrain.SelectedIndexChanged

    End Sub

    Public Sub lbx_elevation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_elevation.SelectedIndexChanged

    End Sub

    Public Sub lbx_placed_terrains_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_placed_terrains.SelectedIndexChanged

    End Sub

    Public Sub btn_set_terrain_Click(sender As Object, e As EventArgs) Handles btn_set_terrain.Click

    End Sub

    Public Sub cbx_use_layers_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_use_layers.CheckedChanged

    End Sub

    ' [TAB: PLAYERS CODE] ----------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub cbx_total_players_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_total_players.SelectedIndexChanged

    End Sub

    Public Sub cbx_gaia_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_age.SelectedIndexChanged

    End Sub

    Public Sub nud_gaia_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_food.ValueChanged

    End Sub

    Public Sub nud_gaia_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_wood.ValueChanged

    End Sub

    Public Sub nud_gaia_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_stone.ValueChanged

    End Sub

    Public Sub nud_gaia_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_gold.ValueChanged

    End Sub

    Public Sub nud_gaia_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_population.ValueChanged

    End Sub

    Public Sub nud_gaia_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_priority.ValueChanged

    End Sub

    Public Sub cbx_gaia_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_color.SelectedIndexChanged

    End Sub

    Public Sub tbx_gaia_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_gaia_tribe_name.TextChanged

    End Sub

    Public Sub tbx_gaia_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_gaia_name_string_id.TextChanged

    End Sub

    Public Sub cbx_gaia_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_gaia_ai.CheckedChanged

    End Sub

    Public Sub cbx_gaia_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_ai_personality.SelectedIndexChanged

    End Sub

    Public Sub cbx_gaia_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_civilization.SelectedIndexChanged

    End Sub

    Public Sub cbx_gaia_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_architecture.SelectedIndexChanged

    End Sub

    Public Sub cbx_gaia_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_gaia_lock_civ.CheckedChanged

    End Sub

    Public Sub cbx_gaia_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_gaia_lock_personality.CheckedChanged

    End Sub

    Public Sub cbx_p1_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_age.SelectedIndexChanged

    End Sub

    Public Sub nud_p1_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_food.ValueChanged

    End Sub

    Public Sub nud_p1_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_wood.ValueChanged

    End Sub

    Public Sub nud_p1_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_stone.ValueChanged

    End Sub

    Public Sub nud_p1_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_gold.ValueChanged

    End Sub

    Public Sub nud_p1_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_population.ValueChanged

    End Sub

    Public Sub nud_p1_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_priority.ValueChanged

    End Sub

    Public Sub cbx_p1_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_color.SelectedIndexChanged

    End Sub

    Public Sub tbx_p1_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p1_tribe_name.TextChanged

    End Sub

    Public Sub tbx_p1_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p1_name_string_id.TextChanged

    End Sub

    Public Sub cbx_p1_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_ai.CheckedChanged

    End Sub

    Public Sub cbx_p1_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_ai_personality.SelectedIndexChanged

    End Sub

    Public Sub cbx_p1_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_civilization.SelectedIndexChanged

    End Sub

    Public Sub cbx_p1_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_architecture.SelectedIndexChanged

    End Sub

    Public Sub cbx_p1_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_lock_civ.CheckedChanged

    End Sub

    Public Sub cbx_p1_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_lock_personality.CheckedChanged

    End Sub

    Public Sub cbx_p2_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_age.SelectedIndexChanged

    End Sub

    Public Sub nud_p2_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_food.ValueChanged

    End Sub

    Public Sub nud_p2_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_wood.ValueChanged

    End Sub

    Public Sub nud_p2_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_stone.ValueChanged

    End Sub

    Public Sub nud_p2_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_gold.ValueChanged

    End Sub

    Public Sub nud_p2_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_population.ValueChanged

    End Sub

    Public Sub nud_p2_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_priority.ValueChanged

    End Sub

    Public Sub cbx_p2_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_color.SelectedIndexChanged

    End Sub

    Public Sub tbx_p2_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p2_tribe_name.TextChanged

    End Sub

    Public Sub tbx_p2_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p2_name_string_id.TextChanged

    End Sub

    Public Sub cbx_p2_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_ai.CheckedChanged

    End Sub

    Public Sub cbx_p2_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_ai_personality.SelectedIndexChanged

    End Sub

    Public Sub cbx_p2_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_civilization.SelectedIndexChanged

    End Sub

    Public Sub cbx_p2_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_architecture.SelectedIndexChanged

    End Sub

    Public Sub cbx_p2_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_lock_civ.CheckedChanged

    End Sub

    Public Sub cbx_p2_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_lock_personality.CheckedChanged

    End Sub

    Public Sub cbx_p3_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_age.SelectedIndexChanged

    End Sub

    Public Sub nud_p3_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_food.ValueChanged

    End Sub

    Public Sub nud_p3_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_wood.ValueChanged

    End Sub

    Public Sub nud_p3_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_stone.ValueChanged

    End Sub

    Public Sub nud_p3_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_gold.ValueChanged

    End Sub

    Public Sub nud_p3_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_population.ValueChanged

    End Sub

    Public Sub nud_p3_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_priority.ValueChanged

    End Sub

    Public Sub cbx_p3_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_color.SelectedIndexChanged

    End Sub

    Public Sub tbx_p3_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p3_tribe_name.TextChanged

    End Sub

    Public Sub tbx_p3_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p3_name_string_id.TextChanged

    End Sub

    Public Sub cbx_p3_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_ai.CheckedChanged

    End Sub

    Public Sub cbx_p3_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_ai_personality.SelectedIndexChanged

    End Sub

    Public Sub cbx_p3_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_civilization.SelectedIndexChanged

    End Sub

    Public Sub cbx_p3_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_architecture.SelectedIndexChanged

    End Sub

    Public Sub cbx_p3_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_lock_civ.CheckedChanged

    End Sub

    Public Sub cbx_p3_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_lock_personality.CheckedChanged

    End Sub

    Public Sub cbx_p4_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_age.SelectedIndexChanged

    End Sub

    Public Sub nud_p4_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_food.ValueChanged

    End Sub

    Public Sub nud_p4_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_wood.ValueChanged

    End Sub

    Public Sub nud_p4_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_stone.ValueChanged

    End Sub

    Public Sub nud_p4_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_gold.ValueChanged

    End Sub

    Public Sub nud_p4_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_population.ValueChanged

    End Sub

    Public Sub nud_p4_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_priority.ValueChanged

    End Sub

    Public Sub cbx_p4_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_color.SelectedIndexChanged

    End Sub

    Public Sub tbx_p4_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p4_tribe_name.TextChanged

    End Sub

    Public Sub tbx_p4_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p4_name_string_id.TextChanged

    End Sub

    Public Sub cbx_p4_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_ai.CheckedChanged

    End Sub

    Public Sub cbx_p4_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_ai_personality.SelectedIndexChanged

    End Sub

    Public Sub cbx_p4_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_civilization.SelectedIndexChanged

    End Sub

    Public Sub cbx_p4_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_architecture.SelectedIndexChanged

    End Sub

    Public Sub cbx_p4_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_lock_civ.CheckedChanged

    End Sub

    Public Sub cbx_p4_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_lock_personality.CheckedChanged

    End Sub

    Public Sub cbx_p5_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_age.SelectedIndexChanged

    End Sub

    Public Sub nud_p5_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_food.ValueChanged

    End Sub

    Public Sub nud_p5_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_wood.ValueChanged

    End Sub

    Public Sub nud_p5_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_stone.ValueChanged

    End Sub

    Public Sub nud_p5_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_gold.ValueChanged

    End Sub

    Public Sub nud_p5_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_population.ValueChanged

    End Sub

    Public Sub nud_p5_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_priority.ValueChanged

    End Sub

    Public Sub cbx_p5_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_color.SelectedIndexChanged

    End Sub

    Public Sub tbx_p5_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p5_tribe_name.TextChanged

    End Sub

    Public Sub tbx_p5_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p5_name_string_id.TextChanged

    End Sub

    Public Sub cbx_p5_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_ai.CheckedChanged

    End Sub

    Public Sub cbx_p5_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_ai_personality.SelectedIndexChanged

    End Sub

    Public Sub cbx_p5_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_civilization.SelectedIndexChanged

    End Sub

    Public Sub cbx_p5_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_architecture.SelectedIndexChanged

    End Sub

    Public Sub cbx_p5_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_lock_civ.CheckedChanged

    End Sub

    Public Sub cbx_p5_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_lock_personality.CheckedChanged

    End Sub

    Public Sub cbx_p6_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_age.SelectedIndexChanged

    End Sub

    Public Sub nud_p6_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_food.ValueChanged

    End Sub

    Public Sub nud_p6_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_wood.ValueChanged

    End Sub

    Public Sub nud_p6_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_stone.ValueChanged

    End Sub

    Public Sub nud_p6_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_gold.ValueChanged

    End Sub

    Public Sub nud_p6_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_population.ValueChanged

    End Sub

    Public Sub nud_p6_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_priority.ValueChanged

    End Sub

    Public Sub cbx_p6_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_color.SelectedIndexChanged

    End Sub

    Public Sub tbx_p6_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p6_tribe_name.TextChanged

    End Sub

    Public Sub tbx_p6_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p6_name_string_id.TextChanged

    End Sub

    Public Sub cbx_p6_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_ai.CheckedChanged

    End Sub

    Public Sub cbx_p6_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_ai_personality.SelectedIndexChanged

    End Sub

    Public Sub cbx_p6_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_civilization.SelectedIndexChanged

    End Sub

    Public Sub cbx_p6_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_architecture.SelectedIndexChanged

    End Sub

    Public Sub cbx_p6_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_lock_civ.CheckedChanged

    End Sub

    Public Sub cbx_p6_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_lock_personality.CheckedChanged

    End Sub

    Public Sub cbx_p7_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_age.SelectedIndexChanged

    End Sub

    Public Sub nud_p7_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_food.ValueChanged

    End Sub

    Public Sub nud_p7_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_wood.ValueChanged

    End Sub

    Public Sub nud_p7_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_stone.ValueChanged

    End Sub

    Public Sub nud_p7_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_gold.ValueChanged

    End Sub

    Public Sub nud_p7_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_population.ValueChanged

    End Sub

    Public Sub nud_p7_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_priority.ValueChanged

    End Sub

    Public Sub cbx_p7_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_color.SelectedIndexChanged

    End Sub

    Public Sub tbx_p7_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p7_tribe_name.TextChanged

    End Sub

    Public Sub tbx_p7_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p7_name_string_id.TextChanged

    End Sub

    Public Sub cbx_p7_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_ai.CheckedChanged

    End Sub

    Public Sub cbx_p7_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_ai_personality.SelectedIndexChanged

    End Sub

    Public Sub cbx_p7_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_civilization.SelectedIndexChanged

    End Sub

    Public Sub cbx_p7_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_architecture.SelectedIndexChanged

    End Sub

    Public Sub cbx_p7_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_lock_civ.CheckedChanged

    End Sub

    Public Sub cbx_p7_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_lock_personality.CheckedChanged

    End Sub

    Public Sub cbx_p8_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_age.SelectedIndexChanged

    End Sub

    Public Sub nud_p8_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_food.ValueChanged

    End Sub

    Public Sub nud_p8_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_wood.ValueChanged

    End Sub

    Public Sub nud_p8_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_stone.ValueChanged

    End Sub

    Public Sub nud_p8_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_gold.ValueChanged

    End Sub

    Public Sub nud_p8_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_population.ValueChanged

    End Sub

    Public Sub nud_p8_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_priority.ValueChanged

    End Sub

    Public Sub cbx_p8_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_color.SelectedIndexChanged

    End Sub

    Public Sub tbx_p8_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p8_tribe_name.TextChanged

    End Sub

    Public Sub tbx_p8_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p8_name_string_id.TextChanged

    End Sub

    Public Sub cbx_p8_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_ai.CheckedChanged

    End Sub

    Public Sub cbx_p8_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_ai_personality.SelectedIndexChanged

    End Sub

    Public Sub cbx_p8_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_civilization.SelectedIndexChanged

    End Sub

    Public Sub cbx_p8_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_architecture.SelectedIndexChanged

    End Sub

    Public Sub cbx_p8_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_lock_civ.CheckedChanged

    End Sub

    Public Sub cbx_p8_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_lock_personality.CheckedChanged

    End Sub

    ' [TABS: UNITS CODE] -----------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub lbx_objects_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_objects_1.SelectedIndexChanged

    End Sub

    Public Sub lbx_objects_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_objects_2.SelectedIndexChanged

    End Sub

    ' [TABS: DIPLOMACY CODE] -------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub btn_p1_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p2_diplo.Click

    End Sub

    Public Sub btn_p1_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p3_diplo.Click

    End Sub

    Public Sub btn_p1_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p4_diplo.Click

    End Sub

    Public Sub btn_p1_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p5_diplo.Click

    End Sub

    Public Sub btn_p1_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p6_diplo.Click

    End Sub

    Public Sub btn_p1_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p7_diplo.Click

    End Sub

    Public Sub btn_p1_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p8_diplo.Click

    End Sub

    Public Sub cbx_p1_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_av_me.CheckedChanged

    End Sub

    Public Sub btn_p2_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p1_diplo.Click

    End Sub

    Public Sub btn_p2_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p3_diplo.Click

    End Sub

    Public Sub btn_p2_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p4_diplo.Click

    End Sub

    Public Sub btn_p2_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p5_diplo.Click

    End Sub

    Public Sub btn_p2_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p6_diplo.Click

    End Sub

    Public Sub btn_p2_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p7_diplo.Click

    End Sub

    Public Sub btn_p2_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p8_diplo.Click

    End Sub

    Public Sub cbx_p2_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_av_me.CheckedChanged

    End Sub

    Public Sub btn_p3_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p1_diplo.Click

    End Sub

    Public Sub btn_p3_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p2_diplo.Click

    End Sub

    Public Sub btn_p3_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p4_diplo.Click

    End Sub

    Public Sub btn_p3_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p5_diplo.Click

    End Sub

    Public Sub btn_p3_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p6_diplo.Click

    End Sub

    Public Sub btn_p3_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p7_diplo.Click

    End Sub

    Public Sub btn_p3_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p8_diplo.Click

    End Sub

    Public Sub cbx_p3_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_av_me.CheckedChanged

    End Sub

    Public Sub btn_p4_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p1_diplo.Click

    End Sub

    Public Sub btn_p4_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p2_diplo.Click

    End Sub

    Public Sub btn_p4_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p3_diplo.Click

    End Sub

    Public Sub btn_p4_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p5_diplo.Click

    End Sub

    Public Sub btn_p4_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p6_diplo.Click

    End Sub

    Public Sub btn_p4_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p7_diplo.Click

    End Sub

    Public Sub btn_p4_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p8_diplo.Click

    End Sub

    Public Sub cbx_p4_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_av_me.CheckedChanged

    End Sub

    Public Sub btn_p5_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p1_diplo.Click

    End Sub

    Public Sub btn_p5_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p2_diplo.Click

    End Sub

    Public Sub btn_p5_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p3_diplo.Click

    End Sub

    Public Sub btn_p5_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p4_diplo.Click

    End Sub

    Public Sub btn_p5_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p6_diplo.Click

    End Sub

    Public Sub btn_p5_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p7_diplo.Click

    End Sub

    Public Sub btn_p5_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p8_diplo.Click

    End Sub

    Public Sub cbx_p5_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_av_me.CheckedChanged

    End Sub

    Public Sub btn_p6_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p1_diplo.Click

    End Sub

    Public Sub btn_p6_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p2_diplo.Click

    End Sub

    Public Sub btn_p6_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p3_diplo.Click

    End Sub

    Public Sub btn_p6_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p4_diplo.Click

    End Sub

    Public Sub btn_p6_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p5_diplo.Click

    End Sub

    Public Sub btn_p6_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p7_diplo.Click

    End Sub

    Public Sub btn_p6_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p8_diplo.Click

    End Sub

    Public Sub cbx_p6_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_av_me.CheckedChanged

    End Sub

    Public Sub btn_p7_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p1_diplo.Click

    End Sub

    Public Sub btn_p7_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p2_diplo.Click

    End Sub

    Public Sub btn_p7_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p3_diplo.Click

    End Sub

    Public Sub btn_p7_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p4_diplo.Click

    End Sub

    Public Sub btn_p7_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p5_diplo.Click

    End Sub

    Public Sub btn_p7_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p6_diplo.Click

    End Sub

    Public Sub btn_p7_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p8_diplo.Click

    End Sub

    Public Sub cbx_p7_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_av_me.CheckedChanged

    End Sub

    Public Sub btn_p8_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p1_diplo.Click

    End Sub

    Public Sub btn_p8_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p2_diplo.Click

    End Sub

    Public Sub btn_p8_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p3_diplo.Click

    End Sub

    Public Sub btn_p8_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p4_diplo.Click

    End Sub

    Public Sub btn_p8_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p5_diplo.Click

    End Sub

    Public Sub btn_p8_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p6_diplo.Click

    End Sub

    Public Sub btn_p8_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p7_diplo.Click

    End Sub

    Public Sub cbx_p8_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_av_me.CheckedChanged

    End Sub

    Public Sub cbx_p1_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_av_them.CheckedChanged

    End Sub

    Public Sub cbx_p2_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_av_them.CheckedChanged

    End Sub

    Public Sub cbx_p3_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_av_them.CheckedChanged

    End Sub

    Public Sub cbx_p4_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_av_them.CheckedChanged

    End Sub

    Public Sub cbx_p5_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_av_them.CheckedChanged

    End Sub

    Public Sub cbx_p6_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_av_them.CheckedChanged

    End Sub

    Public Sub cbx_p7_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_av_them.CheckedChanged

    End Sub

    Public Sub cbx_p8_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_av_them.CheckedChanged

    End Sub

    Public Sub cbx_max_teams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_max_teams.SelectedIndexChanged

    End Sub

    Public Sub cbx_lock_teams_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_lock_teams.CheckedChanged

    End Sub

    Public Sub cbx_choose_teams_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_choose_teams.CheckedChanged

    End Sub

    Public Sub cbx_random_starting_points_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_random_starting_points.CheckedChanged

    End Sub

    ' [TABS: VICTORY CODE] ---------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub rbn_standard_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_standard.CheckedChanged

    End Sub

    Public Sub rbn_conquest_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_conquest.CheckedChanged

    End Sub

    Public Sub rbn_score_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_score.CheckedChanged

    End Sub

    Public Sub rbn_time_limit_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_time_limit.CheckedChanged

    End Sub

    Public Sub rbn_custom_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_custom.CheckedChanged

    End Sub

    Public Sub rbn_secondary_game_mode_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_secondary_game_mode.CheckedChanged

    End Sub

    Public Sub cbx_score_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_score.SelectedIndexChanged

    End Sub

    Public Sub cbx_time_limit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_time_limit.SelectedIndexChanged

    End Sub

    Public Sub cbx_conquest_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_conquest.CheckedChanged

    End Sub

    Public Sub cbx_exploration_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_exploration.CheckedChanged

    End Sub

    Public Sub cbx_relics_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_relics.CheckedChanged

    End Sub

    Public Sub cbx_all_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_all.CheckedChanged

    End Sub

    Public Sub tbx_exploration_total_TextChanged(sender As Object, e As EventArgs) Handles tbx_exploration_total.TextChanged

    End Sub

    Public Sub tbx_relics_total_TextChanged(sender As Object, e As EventArgs) Handles tbx_relics_total.TextChanged

    End Sub

    Public Sub cbx_empire_wars_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_empire_wars.CheckedChanged

    End Sub

    Public Sub cbx_sudden_death_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_sudden_death.CheckedChanged

    End Sub

    Public Sub cbx_regicide_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_regicide.CheckedChanged

    End Sub

    Public Sub cbx_king_of_the_hill_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_king_of_the_hill.CheckedChanged

    End Sub

    ' [TABS: CINEMATICS CODE] ------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub cbx_pregame_cinematic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pregame_cinematic.SelectedIndexChanged

    End Sub

    Public Sub cbx_victory_cinematic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_victory_cinematic.SelectedIndexChanged

    End Sub

    Public Sub cbx_loss_cinematic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_loss_cinematic.SelectedIndexChanged

    End Sub

    Public Sub cbx_instructions_cinematic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_instructions_cinematic.SelectedIndexChanged

    End Sub

    ' ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

End Class