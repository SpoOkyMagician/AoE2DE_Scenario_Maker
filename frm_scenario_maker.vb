Imports System.IO
Imports System.IO.Compression

Public Class frm_scenario_maker

    ' ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    ' let's initialize these variables globally so we don't have to worry about scope...
    ' note: I made everything public as well...
    ' note: hopefully, the user has enough space/memory... can't use a try catch here...

    ' [FILE GLOBALS]

    Dim scenario_file_path As String = "" ' ofd_scenario / sfd_scenario (string path)
    Dim aoe2de_file_path As String = "" ' ofd_aoe2de_path (string path)

    ' [MAP GLOBALS]

    Dim map_size_standard As Integer = 0 ' cbx_map_size (index value)
    Dim map_tile_size As Integer = 0 ' nud_mwh_size (35 to 480)
    Dim default_terrain As Integer = 0 ' cbx_default_terrain (index value)
    Dim ai_type As Integer = 0 ' cbx_ai_map_type (index value)
    Dim color_mood As Integer = 0 ' cbx_color_mood (index value)
    Dim team_positions As Boolean = True ' cbx_team_positions (true/false)
    Dim script_filename As String = "" ' tbx_script_filename (text value)

    ' [TERRAIN GLOBALS]

    ' important note: Listboxes are limited to 32766 characters! I don't recommend using if you can help it.
    ' to do...

    ' [PLAYER GLOBALS]

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
    ' note: I know this can be a string but, I am going to assume integer... although, I might be able to convert string to integer... (to consider)
    Dim tribe_string_id As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' tbx_name_string_id_gaia, tbx_name_string_id_p1, ... tbx_name_string_id_p8 (text string to integer)
    Dim ai_or_player As Boolean() = {False, False, False, False, False, False, False, False, False} ' cbx_ai_gaia, cbx_ai_p1, ... cbx_ai_p8

    ' [OBJECT GLOBALS]

    ' important note: Listboxes are limited to 32766 characters! I don't recommend using if you can help it.
    ' to do...

    ' [DIPLOMACY GLOBALS]

    ' to do...

    ' [VICTORY GLOBALS]

    ' to do...

    ' [OPTION GLOBALS]

    ' to do...

    ' [MESSAGE GLOBALS]

    ' to do...

    ' [CINEMATIC GLOBALS]

    ' to do...

    ' [TRIGGER GLOBALS]

    ' to do...

    ' [ABOUT GLOBALS?]

    ' (may not be needed.)

    ' ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    ' [FUNCTION GLOBALS]

    ' catch all error

    Function catch_all_errors(ex As Exception)

        Try

            ' pop up a message box explaining what happened and try to create a file outputting the error as well in the programs directory.

            MessageBox.Show(ex.ToString, "Runtime Error")
            File.WriteAllText(".\error.txt", ex.ToString)

        Catch another_ex As Exception

            ' just give up...

            Return Nothing
            Me.Close()

        End Try

        Return Nothing
        Me.Close()

    End Function

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
    ' note: apparently, the whitespace/formatting is important too. (i experimented with it.) keep it exactly the same! (except your changes of course.)

    Function F_Decompress_File(my_in_file As String, my_out_file As String) As Object

        Try

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

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

        Return Nothing

    End Function

    Function F_Compress_File(my_in_file As String, my_out_file As String) As Object

        Try

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

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

        Return Nothing

    End Function

    ' this function checks the selected index of cbx_map_size. First, it clears the default x/y values in terrain/map/view, and sets them to the correct values per map size.
    ' note: they are 0 indexed.

    Function check_map_size()

        Try

            ' clear all the items from x and y...

            lbx_x_terrain.Items.Clear()
            lbx_y_terrain.Items.Clear()
            lbx_map_x.Items.Clear()
            lbx_map_y.Items.Clear()
            lbx_view_x.Items.Clear()
            lbx_view_y.Items.Clear()

            ' check which map size is selected...

            If cbx_map_size.SelectedIndex = 0 Then

                ' if miniature...

                For i As Integer = 0 To 79
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 1 Then

                ' if tiny...

                For i As Integer = 0 To 119
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 2 Then

                ' if small...

                For i As Integer = 0 To 143
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 3 Then

                ' if medium...

                For i As Integer = 0 To 167
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 4 Then

                ' if normal...

                For i As Integer = 0 To 199
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 5 Then

                ' if large...

                For i As Integer = 0 To 219
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 6 Then

                ' if huge...

                For i As Integer = 0 To 239
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 7 Then

                ' if giant...

                For i As Integer = 0 To 251
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 8 Then

                ' if massive...

                For i As Integer = 0 To 275
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 9 Then

                ' if enormous...

                For i As Integer = 0 To 299
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 10 Then

                ' if colossal...

                For i As Integer = 0 To 319
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 11 Then

                ' if incredible...

                For i As Integer = 0 To 359
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 12 Then

                ' if monsterous...

                For i As Integer = 0 To 399
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 13 Then

                ' if ludicrous...

                For i As Integer = 0 To 479
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            ElseIf cbx_map_size.SelectedIndex = 14 Then

                ' if custom...

                For i As Integer = 0 To nud_mwh_size.Value
                    lbx_x_terrain.Items.Add("" + i.ToString)
                    lbx_y_terrain.Items.Add("" + i.ToString)
                    lbx_map_x.Items.Add("" + i.ToString)
                    lbx_map_y.Items.Add("" + i.ToString)
                    lbx_view_x.Items.Add("" + i.ToString)
                    lbx_view_y.Items.Add("" + i.ToString)
                Next

            End If

        Catch ex As Exception
            catch_all_errors(ex)
        End Try

        ' since i am not returning anything, we return nothing. probably not needed but, whatever.

        Return Nothing

    End Function

    ' ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    ' [APPLICATION LOAD CODE] ------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub frm_scenario_maker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' on startup, be sure to define all your variables and reset all gui to a vaild minimum scenario...
        Try
            ' variables/GUI stuff goes here... you should be able to copy/paste in btn_new_scenario's click event...

        Catch ex As Exception
            catch_all_errors(ex)
        End Try

    End Sub

    ' [TAB: FILE CODE] -------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub btn_new_scenario_Click(sender As Object, e As EventArgs) Handles btn_new_scenario.Click

        ' on clicking new, be sure to define all your variables and reset all gui to a vaild minimum scenario...

        Try
            ' varables/GUI stuff goes here...
            cbx_map_size.SelectedIndex = 13
            cbx_ai_map_type.SelectedIndex = 6
            cbx_color_mood.SelectedIndex = 0
            cbx_total_players.SelectedIndex = 7
            tbx_script_filename.Text = ""
            cbx_total_players.SelectedIndex = 7
        Catch ex As Exception
            catch_all_errors(ex)
        End Try

    End Sub
    Public Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Try
            ' on click save, this will open the save file dialog window. write code here to save the scenario...
            sfd_scenario.ShowDialog()

            ' note: you can use lbl_save_path.Text to show the path if you want or whatever...
            lbl_save_path.Text = "Saving: " + ofd_scenario.FileName + "... (this will do nothing right now sorry...)"
        Catch ex As Exception
            catch_all_errors(ex)
        End Try

    End Sub
    Public Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click

        Try
            ' on click load, this will open the load file dialog window. write code here to load the scenario...
            ofd_scenario.ShowDialog()

            ' note: you can use lbl_load_path.Text to show the path if you want or whatever...
            lbl_load_path.Text = "Loading: " + ofd_scenario.FileName + "... (this will do nothing right now sorry...)"
        Catch ex As Exception
            catch_all_errors(ex)
        End Try

    End Sub
    Public Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click

        Try

            ' on clicking test, this will 'attempt' to load the scenario editor in AoE2DE... (add argument 'EDITOR' and 'SKIPINTRO')
            ' you will have to find the games executable yourself. I don't want to deal with this personally...

            ofd_aoe2de_path.ShowDialog()
            Process.Start("" + ofd_aoe2de_path.FileName, "EDITOR SKIPINTRO")

        Catch ex As Exception
            catch_all_errors(ex)
        End Try

    End Sub

    ' [TAB: MAP CODE] --------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub cbx_map_size_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_map_size.SelectedIndexChanged

        Try

            ' if we select custom map size, enable the size picker. otherwise, disable it...

            If cbx_map_size.SelectedIndex = 14 Then
                nud_mwh_size.Enabled = True
            Else
                nud_mwh_size.Enabled = False
            End If
            check_map_size()
            cbx_default_terrain.SelectedIndex = 56

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_mwh_size_ValueChanged(sender As Object, e As EventArgs) Handles nud_mwh_size.ValueChanged

        Try
            check_map_size()
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_default_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_default_terrain.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_ai_map_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_ai_map_type.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_color_mood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_mood.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_script_filename_TextChanged(sender As Object, e As EventArgs) Handles tbx_script_filename.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_team_positions_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_team_positions.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' [TAB: TERRAIN CODE] ----------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub lbx_base_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_base_terrain.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_layer_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_layer_terrain.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_x_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_x_terrain.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_y_terrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_y_terrain.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_elevation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_elevation.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_placed_terrains_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_placed_terrains.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_set_terrain_Click(sender As Object, e As EventArgs) Handles btn_set_terrain.Click

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_use_layers_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_use_layers.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' [TAB: PLAYERS CODE] ----------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub cbx_total_players_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_total_players.SelectedIndexChanged

        Try

            If cbx_total_players.SelectedIndex = 0 Then

                ' 1 player...

                btn_p1_to_p2_diplo.Enabled = False
                btn_p1_to_p3_diplo.Enabled = False
                btn_p1_to_p4_diplo.Enabled = False
                btn_p1_to_p5_diplo.Enabled = False
                btn_p1_to_p6_diplo.Enabled = False
                btn_p1_to_p7_diplo.Enabled = False
                btn_p1_to_p8_diplo.Enabled = False

                cbx_p2_age.Enabled = False
                nud_p2_food.Enabled = False
                nud_p2_wood.Enabled = False
                nud_p2_stone.Enabled = False
                nud_p2_gold.Enabled = False
                nud_p2_population.Enabled = False
                nud_p2_priority.Enabled = False
                cbx_p2_color.Enabled = False
                tbx_p2_tribe_name.Enabled = False
                tbx_p2_name_string_id.Enabled = False
                cbx_p2_ai.Enabled = False
                cbx_p2_ai_personality.Enabled = False
                cbx_p2_civilization.Enabled = False
                cbx_p2_architecture.Enabled = False
                cbx_p2_lock_civ.Enabled = False
                cbx_p2_lock_personality.Enabled = False

                cbx_p3_age.Enabled = False
                nud_p3_food.Enabled = False
                nud_p3_wood.Enabled = False
                nud_p3_stone.Enabled = False
                nud_p3_gold.Enabled = False
                nud_p3_population.Enabled = False
                nud_p3_priority.Enabled = False
                cbx_p3_color.Enabled = False
                tbx_p3_tribe_name.Enabled = False
                tbx_p3_name_string_id.Enabled = False
                cbx_p3_ai.Enabled = False
                cbx_p3_ai_personality.Enabled = False
                cbx_p3_civilization.Enabled = False
                cbx_p3_architecture.Enabled = False
                cbx_p3_lock_civ.Enabled = False
                cbx_p3_lock_personality.Enabled = False

                cbx_p4_age.Enabled = False
                nud_p4_food.Enabled = False
                nud_p4_wood.Enabled = False
                nud_p4_stone.Enabled = False
                nud_p4_gold.Enabled = False
                nud_p4_population.Enabled = False
                nud_p4_priority.Enabled = False
                cbx_p4_color.Enabled = False
                tbx_p4_tribe_name.Enabled = False
                tbx_p4_name_string_id.Enabled = False
                cbx_p4_ai.Enabled = False
                cbx_p4_ai_personality.Enabled = False
                cbx_p4_civilization.Enabled = False
                cbx_p4_architecture.Enabled = False
                cbx_p4_lock_civ.Enabled = False
                cbx_p4_lock_personality.Enabled = False

                cbx_p5_age.Enabled = False
                nud_p5_food.Enabled = False
                nud_p5_wood.Enabled = False
                nud_p5_stone.Enabled = False
                nud_p5_gold.Enabled = False
                nud_p5_population.Enabled = False
                nud_p5_priority.Enabled = False
                cbx_p5_color.Enabled = False
                tbx_p5_tribe_name.Enabled = False
                tbx_p5_name_string_id.Enabled = False
                cbx_p5_ai.Enabled = False
                cbx_p5_ai_personality.Enabled = False
                cbx_p5_civilization.Enabled = False
                cbx_p5_architecture.Enabled = False
                cbx_p5_lock_civ.Enabled = False
                cbx_p5_lock_personality.Enabled = False

                cbx_p6_age.Enabled = False
                nud_p6_food.Enabled = False
                nud_p6_wood.Enabled = False
                nud_p6_stone.Enabled = False
                nud_p6_gold.Enabled = False
                nud_p6_population.Enabled = False
                nud_p6_priority.Enabled = False
                cbx_p6_color.Enabled = False
                tbx_p6_tribe_name.Enabled = False
                tbx_p6_name_string_id.Enabled = False
                cbx_p6_ai.Enabled = False
                cbx_p6_ai_personality.Enabled = False
                cbx_p6_civilization.Enabled = False
                cbx_p6_architecture.Enabled = False
                cbx_p6_lock_civ.Enabled = False
                cbx_p6_lock_personality.Enabled = False

                cbx_p7_age.Enabled = False
                nud_p7_food.Enabled = False
                nud_p7_wood.Enabled = False
                nud_p7_stone.Enabled = False
                nud_p7_gold.Enabled = False
                nud_p7_population.Enabled = False
                nud_p7_priority.Enabled = False
                cbx_p7_color.Enabled = False
                tbx_p7_tribe_name.Enabled = False
                tbx_p7_name_string_id.Enabled = False
                cbx_p7_ai.Enabled = False
                cbx_p7_ai_personality.Enabled = False
                cbx_p7_civilization.Enabled = False
                cbx_p7_architecture.Enabled = False
                cbx_p7_lock_civ.Enabled = False
                cbx_p7_lock_personality.Enabled = False

                cbx_p8_age.Enabled = False
                nud_p8_food.Enabled = False
                nud_p8_wood.Enabled = False
                nud_p8_stone.Enabled = False
                nud_p8_gold.Enabled = False
                nud_p8_population.Enabled = False
                nud_p8_priority.Enabled = False
                cbx_p8_color.Enabled = False
                tbx_p8_tribe_name.Enabled = False
                tbx_p8_name_string_id.Enabled = False
                cbx_p8_ai.Enabled = False
                cbx_p8_ai_personality.Enabled = False
                cbx_p8_civilization.Enabled = False
                cbx_p8_architecture.Enabled = False
                cbx_p8_lock_civ.Enabled = False
                cbx_p8_lock_personality.Enabled = False

                btn_p2_to_p1_diplo.Enabled = False
                btn_p2_to_p3_diplo.Enabled = False
                btn_p2_to_p4_diplo.Enabled = False
                btn_p2_to_p5_diplo.Enabled = False
                btn_p2_to_p6_diplo.Enabled = False
                btn_p2_to_p7_diplo.Enabled = False
                btn_p2_to_p8_diplo.Enabled = False
                cbx_p2_av_me.Enabled = False

                btn_p3_to_p1_diplo.Enabled = False
                btn_p3_to_p2_diplo.Enabled = False
                btn_p3_to_p4_diplo.Enabled = False
                btn_p3_to_p5_diplo.Enabled = False
                btn_p3_to_p6_diplo.Enabled = False
                btn_p3_to_p7_diplo.Enabled = False
                btn_p3_to_p8_diplo.Enabled = False
                cbx_p3_av_me.Enabled = False

                btn_p4_to_p1_diplo.Enabled = False
                btn_p4_to_p2_diplo.Enabled = False
                btn_p4_to_p3_diplo.Enabled = False
                btn_p4_to_p5_diplo.Enabled = False
                btn_p4_to_p6_diplo.Enabled = False
                btn_p4_to_p7_diplo.Enabled = False
                btn_p4_to_p8_diplo.Enabled = False
                cbx_p4_av_me.Enabled = False

                btn_p5_to_p1_diplo.Enabled = False
                btn_p5_to_p2_diplo.Enabled = False
                btn_p5_to_p3_diplo.Enabled = False
                btn_p5_to_p4_diplo.Enabled = False
                btn_p5_to_p6_diplo.Enabled = False
                btn_p5_to_p7_diplo.Enabled = False
                btn_p5_to_p8_diplo.Enabled = False
                cbx_p5_av_me.Enabled = False

                btn_p6_to_p1_diplo.Enabled = False
                btn_p6_to_p2_diplo.Enabled = False
                btn_p6_to_p3_diplo.Enabled = False
                btn_p6_to_p4_diplo.Enabled = False
                btn_p6_to_p5_diplo.Enabled = False
                btn_p6_to_p7_diplo.Enabled = False
                btn_p6_to_p8_diplo.Enabled = False
                cbx_p6_av_me.Enabled = False

                btn_p7_to_p1_diplo.Enabled = False
                btn_p7_to_p2_diplo.Enabled = False
                btn_p7_to_p3_diplo.Enabled = False
                btn_p7_to_p4_diplo.Enabled = False
                btn_p7_to_p5_diplo.Enabled = False
                btn_p7_to_p6_diplo.Enabled = False
                btn_p7_to_p8_diplo.Enabled = False
                cbx_p7_av_me.Enabled = False

                btn_p8_to_p1_diplo.Enabled = False
                btn_p8_to_p2_diplo.Enabled = False
                btn_p8_to_p3_diplo.Enabled = False
                btn_p8_to_p4_diplo.Enabled = False
                btn_p8_to_p5_diplo.Enabled = False
                btn_p8_to_p6_diplo.Enabled = False
                btn_p8_to_p7_diplo.Enabled = False
                cbx_p8_av_me.Enabled = False

                cbx_p2_av_them.Enabled = False
                cbx_p3_av_them.Enabled = False
                cbx_p4_av_them.Enabled = False
                cbx_p5_av_them.Enabled = False
                cbx_p6_av_them.Enabled = False
                cbx_p7_av_them.Enabled = False
                cbx_p8_av_them.Enabled = False

            ElseIf cbx_total_players.SelectedIndex = 1 Then

                ' 2 players...

                btn_p1_to_p2_diplo.Enabled = True
                btn_p1_to_p3_diplo.Enabled = False
                btn_p1_to_p4_diplo.Enabled = False
                btn_p1_to_p5_diplo.Enabled = False
                btn_p1_to_p6_diplo.Enabled = False
                btn_p1_to_p7_diplo.Enabled = False
                btn_p1_to_p8_diplo.Enabled = False

                cbx_p2_age.Enabled = True
                nud_p2_food.Enabled = True
                nud_p2_wood.Enabled = True
                nud_p2_stone.Enabled = True
                nud_p2_gold.Enabled = True
                nud_p2_population.Enabled = True
                nud_p2_priority.Enabled = True
                cbx_p2_color.Enabled = True
                tbx_p2_tribe_name.Enabled = True
                tbx_p2_name_string_id.Enabled = True
                cbx_p2_ai.Enabled = True
                cbx_p2_ai_personality.Enabled = True
                cbx_p2_civilization.Enabled = True
                cbx_p2_architecture.Enabled = True
                cbx_p2_lock_civ.Enabled = True
                cbx_p2_lock_personality.Enabled = True

                cbx_p3_age.Enabled = False
                nud_p3_food.Enabled = False
                nud_p3_wood.Enabled = False
                nud_p3_stone.Enabled = False
                nud_p3_gold.Enabled = False
                nud_p3_population.Enabled = False
                nud_p3_priority.Enabled = False
                cbx_p3_color.Enabled = False
                tbx_p3_tribe_name.Enabled = False
                tbx_p3_name_string_id.Enabled = False
                cbx_p3_ai.Enabled = False
                cbx_p3_ai_personality.Enabled = False
                cbx_p3_civilization.Enabled = False
                cbx_p3_architecture.Enabled = False
                cbx_p3_lock_civ.Enabled = False
                cbx_p3_lock_personality.Enabled = False

                cbx_p4_age.Enabled = False
                nud_p4_food.Enabled = False
                nud_p4_wood.Enabled = False
                nud_p4_stone.Enabled = False
                nud_p4_gold.Enabled = False
                nud_p4_population.Enabled = False
                nud_p4_priority.Enabled = False
                cbx_p4_color.Enabled = False
                tbx_p4_tribe_name.Enabled = False
                tbx_p4_name_string_id.Enabled = False
                cbx_p4_ai.Enabled = False
                cbx_p4_ai_personality.Enabled = False
                cbx_p4_civilization.Enabled = False
                cbx_p4_architecture.Enabled = False
                cbx_p4_lock_civ.Enabled = False
                cbx_p4_lock_personality.Enabled = False

                cbx_p5_age.Enabled = False
                nud_p5_food.Enabled = False
                nud_p5_wood.Enabled = False
                nud_p5_stone.Enabled = False
                nud_p5_gold.Enabled = False
                nud_p5_population.Enabled = False
                nud_p5_priority.Enabled = False
                cbx_p5_color.Enabled = False
                tbx_p5_tribe_name.Enabled = False
                tbx_p5_name_string_id.Enabled = False
                cbx_p5_ai.Enabled = False
                cbx_p5_ai_personality.Enabled = False
                cbx_p5_civilization.Enabled = False
                cbx_p5_architecture.Enabled = False
                cbx_p5_lock_civ.Enabled = False
                cbx_p5_lock_personality.Enabled = False

                cbx_p6_age.Enabled = False
                nud_p6_food.Enabled = False
                nud_p6_wood.Enabled = False
                nud_p6_stone.Enabled = False
                nud_p6_gold.Enabled = False
                nud_p6_population.Enabled = False
                nud_p6_priority.Enabled = False
                cbx_p6_color.Enabled = False
                tbx_p6_tribe_name.Enabled = False
                tbx_p6_name_string_id.Enabled = False
                cbx_p6_ai.Enabled = False
                cbx_p6_ai_personality.Enabled = False
                cbx_p6_civilization.Enabled = False
                cbx_p6_architecture.Enabled = False
                cbx_p6_lock_civ.Enabled = False
                cbx_p6_lock_personality.Enabled = False

                cbx_p7_age.Enabled = False
                nud_p7_food.Enabled = False
                nud_p7_wood.Enabled = False
                nud_p7_stone.Enabled = False
                nud_p7_gold.Enabled = False
                nud_p7_population.Enabled = False
                nud_p7_priority.Enabled = False
                cbx_p7_color.Enabled = False
                tbx_p7_tribe_name.Enabled = False
                tbx_p7_name_string_id.Enabled = False
                cbx_p7_ai.Enabled = False
                cbx_p7_ai_personality.Enabled = False
                cbx_p7_civilization.Enabled = False
                cbx_p7_architecture.Enabled = False
                cbx_p7_lock_civ.Enabled = False
                cbx_p7_lock_personality.Enabled = False

                cbx_p8_age.Enabled = False
                nud_p8_food.Enabled = False
                nud_p8_wood.Enabled = False
                nud_p8_stone.Enabled = False
                nud_p8_gold.Enabled = False
                nud_p8_population.Enabled = False
                nud_p8_priority.Enabled = False
                cbx_p8_color.Enabled = False
                tbx_p8_tribe_name.Enabled = False
                tbx_p8_name_string_id.Enabled = False
                cbx_p8_ai.Enabled = False
                cbx_p8_ai_personality.Enabled = False
                cbx_p8_civilization.Enabled = False
                cbx_p8_architecture.Enabled = False
                cbx_p8_lock_civ.Enabled = False
                cbx_p8_lock_personality.Enabled = False

                btn_p2_to_p1_diplo.Enabled = True
                btn_p2_to_p3_diplo.Enabled = True
                btn_p2_to_p4_diplo.Enabled = True
                btn_p2_to_p5_diplo.Enabled = True
                btn_p2_to_p6_diplo.Enabled = True
                btn_p2_to_p7_diplo.Enabled = True
                btn_p2_to_p8_diplo.Enabled = True
                cbx_p2_av_me.Enabled = True

                btn_p3_to_p1_diplo.Enabled = False
                btn_p3_to_p2_diplo.Enabled = False
                btn_p3_to_p4_diplo.Enabled = False
                btn_p3_to_p5_diplo.Enabled = False
                btn_p3_to_p6_diplo.Enabled = False
                btn_p3_to_p7_diplo.Enabled = False
                btn_p3_to_p8_diplo.Enabled = False
                cbx_p3_av_me.Enabled = False

                btn_p4_to_p1_diplo.Enabled = False
                btn_p4_to_p2_diplo.Enabled = False
                btn_p4_to_p3_diplo.Enabled = False
                btn_p4_to_p5_diplo.Enabled = False
                btn_p4_to_p6_diplo.Enabled = False
                btn_p4_to_p7_diplo.Enabled = False
                btn_p4_to_p8_diplo.Enabled = False
                cbx_p4_av_me.Enabled = False

                btn_p5_to_p1_diplo.Enabled = False
                btn_p5_to_p2_diplo.Enabled = False
                btn_p5_to_p3_diplo.Enabled = False
                btn_p5_to_p4_diplo.Enabled = False
                btn_p5_to_p6_diplo.Enabled = False
                btn_p5_to_p7_diplo.Enabled = False
                btn_p5_to_p8_diplo.Enabled = False
                cbx_p5_av_me.Enabled = False

                btn_p6_to_p1_diplo.Enabled = False
                btn_p6_to_p2_diplo.Enabled = False
                btn_p6_to_p3_diplo.Enabled = False
                btn_p6_to_p4_diplo.Enabled = False
                btn_p6_to_p5_diplo.Enabled = False
                btn_p6_to_p7_diplo.Enabled = False
                btn_p6_to_p8_diplo.Enabled = False
                cbx_p6_av_me.Enabled = False

                btn_p7_to_p1_diplo.Enabled = False
                btn_p7_to_p2_diplo.Enabled = False
                btn_p7_to_p3_diplo.Enabled = False
                btn_p7_to_p4_diplo.Enabled = False
                btn_p7_to_p5_diplo.Enabled = False
                btn_p7_to_p6_diplo.Enabled = False
                btn_p7_to_p8_diplo.Enabled = False
                cbx_p7_av_me.Enabled = False

                btn_p8_to_p1_diplo.Enabled = False
                btn_p8_to_p2_diplo.Enabled = False
                btn_p8_to_p3_diplo.Enabled = False
                btn_p8_to_p4_diplo.Enabled = False
                btn_p8_to_p5_diplo.Enabled = False
                btn_p8_to_p6_diplo.Enabled = False
                btn_p8_to_p7_diplo.Enabled = False
                cbx_p8_av_me.Enabled = False

                cbx_p2_av_them.Enabled = True
                cbx_p3_av_them.Enabled = False
                cbx_p4_av_them.Enabled = False
                cbx_p5_av_them.Enabled = False
                cbx_p6_av_them.Enabled = False
                cbx_p7_av_them.Enabled = False
                cbx_p8_av_them.Enabled = False

            ElseIf cbx_total_players.SelectedIndex = 2 Then

                ' 3 players...

                btn_p1_to_p2_diplo.Enabled = True
                btn_p1_to_p3_diplo.Enabled = True
                btn_p1_to_p4_diplo.Enabled = False
                btn_p1_to_p5_diplo.Enabled = False
                btn_p1_to_p6_diplo.Enabled = False
                btn_p1_to_p7_diplo.Enabled = False
                btn_p1_to_p8_diplo.Enabled = False

                cbx_p2_age.Enabled = True
                nud_p2_food.Enabled = True
                nud_p2_wood.Enabled = True
                nud_p2_stone.Enabled = True
                nud_p2_gold.Enabled = True
                nud_p2_population.Enabled = True
                nud_p2_priority.Enabled = True
                cbx_p2_color.Enabled = True
                tbx_p2_tribe_name.Enabled = True
                tbx_p2_name_string_id.Enabled = True
                cbx_p2_ai.Enabled = True
                cbx_p2_ai_personality.Enabled = True
                cbx_p2_civilization.Enabled = True
                cbx_p2_architecture.Enabled = True
                cbx_p2_lock_civ.Enabled = True
                cbx_p2_lock_personality.Enabled = True

                cbx_p3_age.Enabled = True
                nud_p3_food.Enabled = True
                nud_p3_wood.Enabled = True
                nud_p3_stone.Enabled = True
                nud_p3_gold.Enabled = True
                nud_p3_population.Enabled = True
                nud_p3_priority.Enabled = True
                cbx_p3_color.Enabled = True
                tbx_p3_tribe_name.Enabled = True
                tbx_p3_name_string_id.Enabled = True
                cbx_p3_ai.Enabled = True
                cbx_p3_ai_personality.Enabled = True
                cbx_p3_civilization.Enabled = True
                cbx_p3_architecture.Enabled = True
                cbx_p3_lock_civ.Enabled = True
                cbx_p3_lock_personality.Enabled = True

                cbx_p4_age.Enabled = False
                nud_p4_food.Enabled = False
                nud_p4_wood.Enabled = False
                nud_p4_stone.Enabled = False
                nud_p4_gold.Enabled = False
                nud_p4_population.Enabled = False
                nud_p4_priority.Enabled = False
                cbx_p4_color.Enabled = False
                tbx_p4_tribe_name.Enabled = False
                tbx_p4_name_string_id.Enabled = False
                cbx_p4_ai.Enabled = False
                cbx_p4_ai_personality.Enabled = False
                cbx_p4_civilization.Enabled = False
                cbx_p4_architecture.Enabled = False
                cbx_p4_lock_civ.Enabled = False
                cbx_p4_lock_personality.Enabled = False

                cbx_p5_age.Enabled = False
                nud_p5_food.Enabled = False
                nud_p5_wood.Enabled = False
                nud_p5_stone.Enabled = False
                nud_p5_gold.Enabled = False
                nud_p5_population.Enabled = False
                nud_p5_priority.Enabled = False
                cbx_p5_color.Enabled = False
                tbx_p5_tribe_name.Enabled = False
                tbx_p5_name_string_id.Enabled = False
                cbx_p5_ai.Enabled = False
                cbx_p5_ai_personality.Enabled = False
                cbx_p5_civilization.Enabled = False
                cbx_p5_architecture.Enabled = False
                cbx_p5_lock_civ.Enabled = False
                cbx_p5_lock_personality.Enabled = False

                cbx_p6_age.Enabled = False
                nud_p6_food.Enabled = False
                nud_p6_wood.Enabled = False
                nud_p6_stone.Enabled = False
                nud_p6_gold.Enabled = False
                nud_p6_population.Enabled = False
                nud_p6_priority.Enabled = False
                cbx_p6_color.Enabled = False
                tbx_p6_tribe_name.Enabled = False
                tbx_p6_name_string_id.Enabled = False
                cbx_p6_ai.Enabled = False
                cbx_p6_ai_personality.Enabled = False
                cbx_p6_civilization.Enabled = False
                cbx_p6_architecture.Enabled = False
                cbx_p6_lock_civ.Enabled = False
                cbx_p6_lock_personality.Enabled = False

                cbx_p7_age.Enabled = False
                nud_p7_food.Enabled = False
                nud_p7_wood.Enabled = False
                nud_p7_stone.Enabled = False
                nud_p7_gold.Enabled = False
                nud_p7_population.Enabled = False
                nud_p7_priority.Enabled = False
                cbx_p7_color.Enabled = False
                tbx_p7_tribe_name.Enabled = False
                tbx_p7_name_string_id.Enabled = False
                cbx_p7_ai.Enabled = False
                cbx_p7_ai_personality.Enabled = False
                cbx_p7_civilization.Enabled = False
                cbx_p7_architecture.Enabled = False
                cbx_p7_lock_civ.Enabled = False
                cbx_p7_lock_personality.Enabled = False

                cbx_p8_age.Enabled = False
                nud_p8_food.Enabled = False
                nud_p8_wood.Enabled = False
                nud_p8_stone.Enabled = False
                nud_p8_gold.Enabled = False
                nud_p8_population.Enabled = False
                nud_p8_priority.Enabled = False
                cbx_p8_color.Enabled = False
                tbx_p8_tribe_name.Enabled = False
                tbx_p8_name_string_id.Enabled = False
                cbx_p8_ai.Enabled = False
                cbx_p8_ai_personality.Enabled = False
                cbx_p8_civilization.Enabled = False
                cbx_p8_architecture.Enabled = False
                cbx_p8_lock_civ.Enabled = False
                cbx_p8_lock_personality.Enabled = False

                btn_p2_to_p1_diplo.Enabled = True
                btn_p2_to_p3_diplo.Enabled = True
                btn_p2_to_p4_diplo.Enabled = True
                btn_p2_to_p5_diplo.Enabled = True
                btn_p2_to_p6_diplo.Enabled = True
                btn_p2_to_p7_diplo.Enabled = True
                btn_p2_to_p8_diplo.Enabled = True
                cbx_p2_av_me.Enabled = True

                btn_p3_to_p1_diplo.Enabled = True
                btn_p3_to_p2_diplo.Enabled = True
                btn_p3_to_p4_diplo.Enabled = True
                btn_p3_to_p5_diplo.Enabled = True
                btn_p3_to_p6_diplo.Enabled = True
                btn_p3_to_p7_diplo.Enabled = True
                btn_p3_to_p8_diplo.Enabled = True
                cbx_p3_av_me.Enabled = True

                btn_p4_to_p1_diplo.Enabled = False
                btn_p4_to_p2_diplo.Enabled = False
                btn_p4_to_p3_diplo.Enabled = False
                btn_p4_to_p5_diplo.Enabled = False
                btn_p4_to_p6_diplo.Enabled = False
                btn_p4_to_p7_diplo.Enabled = False
                btn_p4_to_p8_diplo.Enabled = False
                cbx_p4_av_me.Enabled = False

                btn_p5_to_p1_diplo.Enabled = False
                btn_p5_to_p2_diplo.Enabled = False
                btn_p5_to_p3_diplo.Enabled = False
                btn_p5_to_p4_diplo.Enabled = False
                btn_p5_to_p6_diplo.Enabled = False
                btn_p5_to_p7_diplo.Enabled = False
                btn_p5_to_p8_diplo.Enabled = False
                cbx_p5_av_me.Enabled = False

                btn_p6_to_p1_diplo.Enabled = False
                btn_p6_to_p2_diplo.Enabled = False
                btn_p6_to_p3_diplo.Enabled = False
                btn_p6_to_p4_diplo.Enabled = False
                btn_p6_to_p5_diplo.Enabled = False
                btn_p6_to_p7_diplo.Enabled = False
                btn_p6_to_p8_diplo.Enabled = False
                cbx_p6_av_me.Enabled = False

                btn_p7_to_p1_diplo.Enabled = False
                btn_p7_to_p2_diplo.Enabled = False
                btn_p7_to_p3_diplo.Enabled = False
                btn_p7_to_p4_diplo.Enabled = False
                btn_p7_to_p5_diplo.Enabled = False
                btn_p7_to_p6_diplo.Enabled = False
                btn_p7_to_p8_diplo.Enabled = False
                cbx_p7_av_me.Enabled = False

                btn_p8_to_p1_diplo.Enabled = False
                btn_p8_to_p2_diplo.Enabled = False
                btn_p8_to_p3_diplo.Enabled = False
                btn_p8_to_p4_diplo.Enabled = False
                btn_p8_to_p5_diplo.Enabled = False
                btn_p8_to_p6_diplo.Enabled = False
                btn_p8_to_p7_diplo.Enabled = False
                cbx_p8_av_me.Enabled = False

                cbx_p2_av_them.Enabled = True
                cbx_p3_av_them.Enabled = True
                cbx_p4_av_them.Enabled = False
                cbx_p5_av_them.Enabled = False
                cbx_p6_av_them.Enabled = False
                cbx_p7_av_them.Enabled = False
                cbx_p8_av_them.Enabled = False

            ElseIf cbx_total_players.SelectedIndex = 3 Then

                ' 4 players...

                btn_p1_to_p2_diplo.Enabled = True
                btn_p1_to_p3_diplo.Enabled = True
                btn_p1_to_p4_diplo.Enabled = True
                btn_p1_to_p5_diplo.Enabled = False
                btn_p1_to_p6_diplo.Enabled = False
                btn_p1_to_p7_diplo.Enabled = False
                btn_p1_to_p8_diplo.Enabled = False

                cbx_p2_age.Enabled = True
                nud_p2_food.Enabled = True
                nud_p2_wood.Enabled = True
                nud_p2_stone.Enabled = True
                nud_p2_gold.Enabled = True
                nud_p2_population.Enabled = True
                nud_p2_priority.Enabled = True
                cbx_p2_color.Enabled = True
                tbx_p2_tribe_name.Enabled = True
                tbx_p2_name_string_id.Enabled = True
                cbx_p2_ai.Enabled = True
                cbx_p2_ai_personality.Enabled = True
                cbx_p2_civilization.Enabled = True
                cbx_p2_architecture.Enabled = True
                cbx_p2_lock_civ.Enabled = True
                cbx_p2_lock_personality.Enabled = True

                cbx_p3_age.Enabled = True
                nud_p3_food.Enabled = True
                nud_p3_wood.Enabled = True
                nud_p3_stone.Enabled = True
                nud_p3_gold.Enabled = True
                nud_p3_population.Enabled = True
                nud_p3_priority.Enabled = True
                cbx_p3_color.Enabled = True
                tbx_p3_tribe_name.Enabled = True
                tbx_p3_name_string_id.Enabled = True
                cbx_p3_ai.Enabled = True
                cbx_p3_ai_personality.Enabled = True
                cbx_p3_civilization.Enabled = True
                cbx_p3_architecture.Enabled = True
                cbx_p3_lock_civ.Enabled = True
                cbx_p3_lock_personality.Enabled = True

                cbx_p4_age.Enabled = True
                nud_p4_food.Enabled = True
                nud_p4_wood.Enabled = True
                nud_p4_stone.Enabled = True
                nud_p4_gold.Enabled = True
                nud_p4_population.Enabled = True
                nud_p4_priority.Enabled = True
                cbx_p4_color.Enabled = True
                tbx_p4_tribe_name.Enabled = True
                tbx_p4_name_string_id.Enabled = True
                cbx_p4_ai.Enabled = True
                cbx_p4_ai_personality.Enabled = True
                cbx_p4_civilization.Enabled = True
                cbx_p4_architecture.Enabled = True
                cbx_p4_lock_civ.Enabled = True
                cbx_p4_lock_personality.Enabled = True

                cbx_p5_age.Enabled = False
                nud_p5_food.Enabled = False
                nud_p5_wood.Enabled = False
                nud_p5_stone.Enabled = False
                nud_p5_gold.Enabled = False
                nud_p5_population.Enabled = False
                nud_p5_priority.Enabled = False
                cbx_p5_color.Enabled = False
                tbx_p5_tribe_name.Enabled = False
                tbx_p5_name_string_id.Enabled = False
                cbx_p5_ai.Enabled = False
                cbx_p5_ai_personality.Enabled = False
                cbx_p5_civilization.Enabled = False
                cbx_p5_architecture.Enabled = False
                cbx_p5_lock_civ.Enabled = False
                cbx_p5_lock_personality.Enabled = False

                cbx_p6_age.Enabled = False
                nud_p6_food.Enabled = False
                nud_p6_wood.Enabled = False
                nud_p6_stone.Enabled = False
                nud_p6_gold.Enabled = False
                nud_p6_population.Enabled = False
                nud_p6_priority.Enabled = False
                cbx_p6_color.Enabled = False
                tbx_p6_tribe_name.Enabled = False
                tbx_p6_name_string_id.Enabled = False
                cbx_p6_ai.Enabled = False
                cbx_p6_ai_personality.Enabled = False
                cbx_p6_civilization.Enabled = False
                cbx_p6_architecture.Enabled = False
                cbx_p6_lock_civ.Enabled = False
                cbx_p6_lock_personality.Enabled = False

                cbx_p7_age.Enabled = False
                nud_p7_food.Enabled = False
                nud_p7_wood.Enabled = False
                nud_p7_stone.Enabled = False
                nud_p7_gold.Enabled = False
                nud_p7_population.Enabled = False
                nud_p7_priority.Enabled = False
                cbx_p7_color.Enabled = False
                tbx_p7_tribe_name.Enabled = False
                tbx_p7_name_string_id.Enabled = False
                cbx_p7_ai.Enabled = False
                cbx_p7_ai_personality.Enabled = False
                cbx_p7_civilization.Enabled = False
                cbx_p7_architecture.Enabled = False
                cbx_p7_lock_civ.Enabled = False
                cbx_p7_lock_personality.Enabled = False

                cbx_p8_age.Enabled = False
                nud_p8_food.Enabled = False
                nud_p8_wood.Enabled = False
                nud_p8_stone.Enabled = False
                nud_p8_gold.Enabled = False
                nud_p8_population.Enabled = False
                nud_p8_priority.Enabled = False
                cbx_p8_color.Enabled = False
                tbx_p8_tribe_name.Enabled = False
                tbx_p8_name_string_id.Enabled = False
                cbx_p8_ai.Enabled = False
                cbx_p8_ai_personality.Enabled = False
                cbx_p8_civilization.Enabled = False
                cbx_p8_architecture.Enabled = False
                cbx_p8_lock_civ.Enabled = False
                cbx_p8_lock_personality.Enabled = False

                btn_p2_to_p1_diplo.Enabled = True
                btn_p2_to_p3_diplo.Enabled = True
                btn_p2_to_p4_diplo.Enabled = True
                btn_p2_to_p5_diplo.Enabled = True
                btn_p2_to_p6_diplo.Enabled = True
                btn_p2_to_p7_diplo.Enabled = True
                btn_p2_to_p8_diplo.Enabled = True
                cbx_p2_av_me.Enabled = True

                btn_p3_to_p1_diplo.Enabled = True
                btn_p3_to_p2_diplo.Enabled = True
                btn_p3_to_p4_diplo.Enabled = True
                btn_p3_to_p5_diplo.Enabled = True
                btn_p3_to_p6_diplo.Enabled = True
                btn_p3_to_p7_diplo.Enabled = True
                btn_p3_to_p8_diplo.Enabled = True
                cbx_p3_av_me.Enabled = True

                btn_p4_to_p1_diplo.Enabled = True
                btn_p4_to_p2_diplo.Enabled = True
                btn_p4_to_p3_diplo.Enabled = True
                btn_p4_to_p5_diplo.Enabled = True
                btn_p4_to_p6_diplo.Enabled = True
                btn_p4_to_p7_diplo.Enabled = True
                btn_p4_to_p8_diplo.Enabled = True
                cbx_p4_av_me.Enabled = True

                btn_p5_to_p1_diplo.Enabled = False
                btn_p5_to_p2_diplo.Enabled = False
                btn_p5_to_p3_diplo.Enabled = False
                btn_p5_to_p4_diplo.Enabled = False
                btn_p5_to_p6_diplo.Enabled = False
                btn_p5_to_p7_diplo.Enabled = False
                btn_p5_to_p8_diplo.Enabled = False
                cbx_p5_av_me.Enabled = False

                btn_p6_to_p1_diplo.Enabled = False
                btn_p6_to_p2_diplo.Enabled = False
                btn_p6_to_p3_diplo.Enabled = False
                btn_p6_to_p4_diplo.Enabled = False
                btn_p6_to_p5_diplo.Enabled = False
                btn_p6_to_p7_diplo.Enabled = False
                btn_p6_to_p8_diplo.Enabled = False
                cbx_p6_av_me.Enabled = False

                btn_p7_to_p1_diplo.Enabled = False
                btn_p7_to_p2_diplo.Enabled = False
                btn_p7_to_p3_diplo.Enabled = False
                btn_p7_to_p4_diplo.Enabled = False
                btn_p7_to_p5_diplo.Enabled = False
                btn_p7_to_p6_diplo.Enabled = False
                btn_p7_to_p8_diplo.Enabled = False
                cbx_p7_av_me.Enabled = False

                btn_p8_to_p1_diplo.Enabled = False
                btn_p8_to_p2_diplo.Enabled = False
                btn_p8_to_p3_diplo.Enabled = False
                btn_p8_to_p4_diplo.Enabled = False
                btn_p8_to_p5_diplo.Enabled = False
                btn_p8_to_p6_diplo.Enabled = False
                btn_p8_to_p7_diplo.Enabled = False
                cbx_p8_av_me.Enabled = False

                cbx_p2_av_them.Enabled = True
                cbx_p3_av_them.Enabled = True
                cbx_p4_av_them.Enabled = True
                cbx_p5_av_them.Enabled = False
                cbx_p6_av_them.Enabled = False
                cbx_p7_av_them.Enabled = False
                cbx_p8_av_them.Enabled = False

            ElseIf cbx_total_players.SelectedIndex = 4 Then

                ' 5 players...

                btn_p1_to_p2_diplo.Enabled = True
                btn_p1_to_p3_diplo.Enabled = True
                btn_p1_to_p4_diplo.Enabled = True
                btn_p1_to_p5_diplo.Enabled = True
                btn_p1_to_p6_diplo.Enabled = False
                btn_p1_to_p7_diplo.Enabled = False
                btn_p1_to_p8_diplo.Enabled = False

                cbx_p2_age.Enabled = True
                nud_p2_food.Enabled = True
                nud_p2_wood.Enabled = True
                nud_p2_stone.Enabled = True
                nud_p2_gold.Enabled = True
                nud_p2_population.Enabled = True
                nud_p2_priority.Enabled = True
                cbx_p2_color.Enabled = True
                tbx_p2_tribe_name.Enabled = True
                tbx_p2_name_string_id.Enabled = True
                cbx_p2_ai.Enabled = True
                cbx_p2_ai_personality.Enabled = True
                cbx_p2_civilization.Enabled = True
                cbx_p2_architecture.Enabled = True
                cbx_p2_lock_civ.Enabled = True
                cbx_p2_lock_personality.Enabled = True

                cbx_p3_age.Enabled = True
                nud_p3_food.Enabled = True
                nud_p3_wood.Enabled = True
                nud_p3_stone.Enabled = True
                nud_p3_gold.Enabled = True
                nud_p3_population.Enabled = True
                nud_p3_priority.Enabled = True
                cbx_p3_color.Enabled = True
                tbx_p3_tribe_name.Enabled = True
                tbx_p3_name_string_id.Enabled = True
                cbx_p3_ai.Enabled = True
                cbx_p3_ai_personality.Enabled = True
                cbx_p3_civilization.Enabled = True
                cbx_p3_architecture.Enabled = True
                cbx_p3_lock_civ.Enabled = True
                cbx_p3_lock_personality.Enabled = True

                cbx_p4_age.Enabled = True
                nud_p4_food.Enabled = True
                nud_p4_wood.Enabled = True
                nud_p4_stone.Enabled = True
                nud_p4_gold.Enabled = True
                nud_p4_population.Enabled = True
                nud_p4_priority.Enabled = True
                cbx_p4_color.Enabled = True
                tbx_p4_tribe_name.Enabled = True
                tbx_p4_name_string_id.Enabled = True
                cbx_p4_ai.Enabled = True
                cbx_p4_ai_personality.Enabled = True
                cbx_p4_civilization.Enabled = True
                cbx_p4_architecture.Enabled = True
                cbx_p4_lock_civ.Enabled = True
                cbx_p4_lock_personality.Enabled = True

                cbx_p5_age.Enabled = True
                nud_p5_food.Enabled = True
                nud_p5_wood.Enabled = True
                nud_p5_stone.Enabled = True
                nud_p5_gold.Enabled = True
                nud_p5_population.Enabled = True
                nud_p5_priority.Enabled = True
                cbx_p5_color.Enabled = True
                tbx_p5_tribe_name.Enabled = True
                tbx_p5_name_string_id.Enabled = True
                cbx_p5_ai.Enabled = True
                cbx_p5_ai_personality.Enabled = True
                cbx_p5_civilization.Enabled = True
                cbx_p5_architecture.Enabled = True
                cbx_p5_lock_civ.Enabled = True
                cbx_p5_lock_personality.Enabled = True

                cbx_p6_age.Enabled = False
                nud_p6_food.Enabled = False
                nud_p6_wood.Enabled = False
                nud_p6_stone.Enabled = False
                nud_p6_gold.Enabled = False
                nud_p6_population.Enabled = False
                nud_p6_priority.Enabled = False
                cbx_p6_color.Enabled = False
                tbx_p6_tribe_name.Enabled = False
                tbx_p6_name_string_id.Enabled = False
                cbx_p6_ai.Enabled = False
                cbx_p6_ai_personality.Enabled = False
                cbx_p6_civilization.Enabled = False
                cbx_p6_architecture.Enabled = False
                cbx_p6_lock_civ.Enabled = False
                cbx_p6_lock_personality.Enabled = False

                cbx_p7_age.Enabled = False
                nud_p7_food.Enabled = False
                nud_p7_wood.Enabled = False
                nud_p7_stone.Enabled = False
                nud_p7_gold.Enabled = False
                nud_p7_population.Enabled = False
                nud_p7_priority.Enabled = False
                cbx_p7_color.Enabled = False
                tbx_p7_tribe_name.Enabled = False
                tbx_p7_name_string_id.Enabled = False
                cbx_p7_ai.Enabled = False
                cbx_p7_ai_personality.Enabled = False
                cbx_p7_civilization.Enabled = False
                cbx_p7_architecture.Enabled = False
                cbx_p7_lock_civ.Enabled = False
                cbx_p7_lock_personality.Enabled = False

                cbx_p8_age.Enabled = False
                nud_p8_food.Enabled = False
                nud_p8_wood.Enabled = False
                nud_p8_stone.Enabled = False
                nud_p8_gold.Enabled = False
                nud_p8_population.Enabled = False
                nud_p8_priority.Enabled = False
                cbx_p8_color.Enabled = False
                tbx_p8_tribe_name.Enabled = False
                tbx_p8_name_string_id.Enabled = False
                cbx_p8_ai.Enabled = False
                cbx_p8_ai_personality.Enabled = False
                cbx_p8_civilization.Enabled = False
                cbx_p8_architecture.Enabled = False
                cbx_p8_lock_civ.Enabled = False
                cbx_p8_lock_personality.Enabled = False

                btn_p2_to_p1_diplo.Enabled = True
                btn_p2_to_p3_diplo.Enabled = True
                btn_p2_to_p4_diplo.Enabled = True
                btn_p2_to_p5_diplo.Enabled = True
                btn_p2_to_p6_diplo.Enabled = True
                btn_p2_to_p7_diplo.Enabled = True
                btn_p2_to_p8_diplo.Enabled = True
                cbx_p2_av_me.Enabled = True

                btn_p3_to_p1_diplo.Enabled = True
                btn_p3_to_p2_diplo.Enabled = True
                btn_p3_to_p4_diplo.Enabled = True
                btn_p3_to_p5_diplo.Enabled = True
                btn_p3_to_p6_diplo.Enabled = True
                btn_p3_to_p7_diplo.Enabled = True
                btn_p3_to_p8_diplo.Enabled = True
                cbx_p3_av_me.Enabled = True

                btn_p4_to_p1_diplo.Enabled = True
                btn_p4_to_p2_diplo.Enabled = True
                btn_p4_to_p3_diplo.Enabled = True
                btn_p4_to_p5_diplo.Enabled = True
                btn_p4_to_p6_diplo.Enabled = True
                btn_p4_to_p7_diplo.Enabled = True
                btn_p4_to_p8_diplo.Enabled = True
                cbx_p4_av_me.Enabled = True

                btn_p5_to_p1_diplo.Enabled = True
                btn_p5_to_p2_diplo.Enabled = True
                btn_p5_to_p3_diplo.Enabled = True
                btn_p5_to_p4_diplo.Enabled = True
                btn_p5_to_p6_diplo.Enabled = True
                btn_p5_to_p7_diplo.Enabled = True
                btn_p5_to_p8_diplo.Enabled = True
                cbx_p5_av_me.Enabled = True

                btn_p6_to_p1_diplo.Enabled = False
                btn_p6_to_p2_diplo.Enabled = False
                btn_p6_to_p3_diplo.Enabled = False
                btn_p6_to_p4_diplo.Enabled = False
                btn_p6_to_p5_diplo.Enabled = False
                btn_p6_to_p7_diplo.Enabled = False
                btn_p6_to_p8_diplo.Enabled = False
                cbx_p6_av_me.Enabled = False

                btn_p7_to_p1_diplo.Enabled = False
                btn_p7_to_p2_diplo.Enabled = False
                btn_p7_to_p3_diplo.Enabled = False
                btn_p7_to_p4_diplo.Enabled = False
                btn_p7_to_p5_diplo.Enabled = False
                btn_p7_to_p6_diplo.Enabled = False
                btn_p7_to_p8_diplo.Enabled = False
                cbx_p7_av_me.Enabled = False

                btn_p8_to_p1_diplo.Enabled = False
                btn_p8_to_p2_diplo.Enabled = False
                btn_p8_to_p3_diplo.Enabled = False
                btn_p8_to_p4_diplo.Enabled = False
                btn_p8_to_p5_diplo.Enabled = False
                btn_p8_to_p6_diplo.Enabled = False
                btn_p8_to_p7_diplo.Enabled = False
                cbx_p8_av_me.Enabled = False

                cbx_p2_av_them.Enabled = True
                cbx_p3_av_them.Enabled = True
                cbx_p4_av_them.Enabled = True
                cbx_p5_av_them.Enabled = True
                cbx_p6_av_them.Enabled = False
                cbx_p7_av_them.Enabled = False
                cbx_p8_av_them.Enabled = False

            ElseIf cbx_total_players.SelectedIndex = 5 Then

                ' 6 players...

                btn_p1_to_p2_diplo.Enabled = True
                btn_p1_to_p3_diplo.Enabled = True
                btn_p1_to_p4_diplo.Enabled = True
                btn_p1_to_p5_diplo.Enabled = True
                btn_p1_to_p6_diplo.Enabled = True
                btn_p1_to_p7_diplo.Enabled = False
                btn_p1_to_p8_diplo.Enabled = False

                cbx_p2_age.Enabled = True
                nud_p2_food.Enabled = True
                nud_p2_wood.Enabled = True
                nud_p2_stone.Enabled = True
                nud_p2_gold.Enabled = True
                nud_p2_population.Enabled = True
                nud_p2_priority.Enabled = True
                cbx_p2_color.Enabled = True
                tbx_p2_tribe_name.Enabled = True
                tbx_p2_name_string_id.Enabled = True
                cbx_p2_ai.Enabled = True
                cbx_p2_ai_personality.Enabled = True
                cbx_p2_civilization.Enabled = True
                cbx_p2_architecture.Enabled = True
                cbx_p2_lock_civ.Enabled = True
                cbx_p2_lock_personality.Enabled = True

                cbx_p3_age.Enabled = True
                nud_p3_food.Enabled = True
                nud_p3_wood.Enabled = True
                nud_p3_stone.Enabled = True
                nud_p3_gold.Enabled = True
                nud_p3_population.Enabled = True
                nud_p3_priority.Enabled = True
                cbx_p3_color.Enabled = True
                tbx_p3_tribe_name.Enabled = True
                tbx_p3_name_string_id.Enabled = True
                cbx_p3_ai.Enabled = True
                cbx_p3_ai_personality.Enabled = True
                cbx_p3_civilization.Enabled = True
                cbx_p3_architecture.Enabled = True
                cbx_p3_lock_civ.Enabled = True
                cbx_p3_lock_personality.Enabled = True

                cbx_p4_age.Enabled = True
                nud_p4_food.Enabled = True
                nud_p4_wood.Enabled = True
                nud_p4_stone.Enabled = True
                nud_p4_gold.Enabled = True
                nud_p4_population.Enabled = True
                nud_p4_priority.Enabled = True
                cbx_p4_color.Enabled = True
                tbx_p4_tribe_name.Enabled = True
                tbx_p4_name_string_id.Enabled = True
                cbx_p4_ai.Enabled = True
                cbx_p4_ai_personality.Enabled = True
                cbx_p4_civilization.Enabled = True
                cbx_p4_architecture.Enabled = True
                cbx_p4_lock_civ.Enabled = True
                cbx_p4_lock_personality.Enabled = True

                cbx_p5_age.Enabled = True
                nud_p5_food.Enabled = True
                nud_p5_wood.Enabled = True
                nud_p5_stone.Enabled = True
                nud_p5_gold.Enabled = True
                nud_p5_population.Enabled = True
                nud_p5_priority.Enabled = True
                cbx_p5_color.Enabled = True
                tbx_p5_tribe_name.Enabled = True
                tbx_p5_name_string_id.Enabled = True
                cbx_p5_ai.Enabled = True
                cbx_p5_ai_personality.Enabled = True
                cbx_p5_civilization.Enabled = True
                cbx_p5_architecture.Enabled = True
                cbx_p5_lock_civ.Enabled = True
                cbx_p5_lock_personality.Enabled = True

                cbx_p6_age.Enabled = True
                nud_p6_food.Enabled = True
                nud_p6_wood.Enabled = True
                nud_p6_stone.Enabled = True
                nud_p6_gold.Enabled = True
                nud_p6_population.Enabled = True
                nud_p6_priority.Enabled = True
                cbx_p6_color.Enabled = True
                tbx_p6_tribe_name.Enabled = True
                tbx_p6_name_string_id.Enabled = True
                cbx_p6_ai.Enabled = True
                cbx_p6_ai_personality.Enabled = True
                cbx_p6_civilization.Enabled = True
                cbx_p6_architecture.Enabled = True
                cbx_p6_lock_civ.Enabled = True
                cbx_p6_lock_personality.Enabled = True

                cbx_p7_age.Enabled = False
                nud_p7_food.Enabled = False
                nud_p7_wood.Enabled = False
                nud_p7_stone.Enabled = False
                nud_p7_gold.Enabled = False
                nud_p7_population.Enabled = False
                nud_p7_priority.Enabled = False
                cbx_p7_color.Enabled = False
                tbx_p7_tribe_name.Enabled = False
                tbx_p7_name_string_id.Enabled = False
                cbx_p7_ai.Enabled = False
                cbx_p7_ai_personality.Enabled = False
                cbx_p7_civilization.Enabled = False
                cbx_p7_architecture.Enabled = False
                cbx_p7_lock_civ.Enabled = False
                cbx_p7_lock_personality.Enabled = False

                cbx_p8_age.Enabled = False
                nud_p8_food.Enabled = False
                nud_p8_wood.Enabled = False
                nud_p8_stone.Enabled = False
                nud_p8_gold.Enabled = False
                nud_p8_population.Enabled = False
                nud_p8_priority.Enabled = False
                cbx_p8_color.Enabled = False
                tbx_p8_tribe_name.Enabled = False
                tbx_p8_name_string_id.Enabled = False
                cbx_p8_ai.Enabled = False
                cbx_p8_ai_personality.Enabled = False
                cbx_p8_civilization.Enabled = False
                cbx_p8_architecture.Enabled = False
                cbx_p8_lock_civ.Enabled = False
                cbx_p8_lock_personality.Enabled = False

                btn_p2_to_p1_diplo.Enabled = True
                btn_p2_to_p3_diplo.Enabled = True
                btn_p2_to_p4_diplo.Enabled = True
                btn_p2_to_p5_diplo.Enabled = True
                btn_p2_to_p6_diplo.Enabled = True
                btn_p2_to_p7_diplo.Enabled = True
                btn_p2_to_p8_diplo.Enabled = True
                cbx_p2_av_me.Enabled = True

                btn_p3_to_p1_diplo.Enabled = True
                btn_p3_to_p2_diplo.Enabled = True
                btn_p3_to_p4_diplo.Enabled = True
                btn_p3_to_p5_diplo.Enabled = True
                btn_p3_to_p6_diplo.Enabled = True
                btn_p3_to_p7_diplo.Enabled = True
                btn_p3_to_p8_diplo.Enabled = True
                cbx_p3_av_me.Enabled = True

                btn_p4_to_p1_diplo.Enabled = True
                btn_p4_to_p2_diplo.Enabled = True
                btn_p4_to_p3_diplo.Enabled = True
                btn_p4_to_p5_diplo.Enabled = True
                btn_p4_to_p6_diplo.Enabled = True
                btn_p4_to_p7_diplo.Enabled = True
                btn_p4_to_p8_diplo.Enabled = True
                cbx_p4_av_me.Enabled = True

                btn_p5_to_p1_diplo.Enabled = True
                btn_p5_to_p2_diplo.Enabled = True
                btn_p5_to_p3_diplo.Enabled = True
                btn_p5_to_p4_diplo.Enabled = True
                btn_p5_to_p6_diplo.Enabled = True
                btn_p5_to_p7_diplo.Enabled = True
                btn_p5_to_p8_diplo.Enabled = True
                cbx_p5_av_me.Enabled = True

                btn_p6_to_p1_diplo.Enabled = True
                btn_p6_to_p2_diplo.Enabled = True
                btn_p6_to_p3_diplo.Enabled = True
                btn_p6_to_p4_diplo.Enabled = True
                btn_p6_to_p5_diplo.Enabled = True
                btn_p6_to_p7_diplo.Enabled = True
                btn_p6_to_p8_diplo.Enabled = True
                cbx_p6_av_me.Enabled = True

                btn_p7_to_p1_diplo.Enabled = False
                btn_p7_to_p2_diplo.Enabled = False
                btn_p7_to_p3_diplo.Enabled = False
                btn_p7_to_p4_diplo.Enabled = False
                btn_p7_to_p5_diplo.Enabled = False
                btn_p7_to_p6_diplo.Enabled = False
                btn_p7_to_p8_diplo.Enabled = False
                cbx_p7_av_me.Enabled = False

                btn_p8_to_p1_diplo.Enabled = False
                btn_p8_to_p2_diplo.Enabled = False
                btn_p8_to_p3_diplo.Enabled = False
                btn_p8_to_p4_diplo.Enabled = False
                btn_p8_to_p5_diplo.Enabled = False
                btn_p8_to_p6_diplo.Enabled = False
                btn_p8_to_p7_diplo.Enabled = False
                cbx_p8_av_me.Enabled = False

                cbx_p2_av_them.Enabled = True
                cbx_p3_av_them.Enabled = True
                cbx_p4_av_them.Enabled = True
                cbx_p5_av_them.Enabled = True
                cbx_p6_av_them.Enabled = True
                cbx_p7_av_them.Enabled = False
                cbx_p8_av_them.Enabled = False

            ElseIf cbx_total_players.SelectedIndex = 6 Then

                ' 7 players...

                btn_p1_to_p2_diplo.Enabled = True
                btn_p1_to_p3_diplo.Enabled = True
                btn_p1_to_p4_diplo.Enabled = True
                btn_p1_to_p5_diplo.Enabled = True
                btn_p1_to_p6_diplo.Enabled = True
                btn_p1_to_p7_diplo.Enabled = True
                btn_p1_to_p8_diplo.Enabled = False

                cbx_p2_age.Enabled = True
                nud_p2_food.Enabled = True
                nud_p2_wood.Enabled = True
                nud_p2_stone.Enabled = True
                nud_p2_gold.Enabled = True
                nud_p2_population.Enabled = True
                nud_p2_priority.Enabled = True
                cbx_p2_color.Enabled = True
                tbx_p2_tribe_name.Enabled = True
                tbx_p2_name_string_id.Enabled = True
                cbx_p2_ai.Enabled = True
                cbx_p2_ai_personality.Enabled = True
                cbx_p2_civilization.Enabled = True
                cbx_p2_architecture.Enabled = True
                cbx_p2_lock_civ.Enabled = True
                cbx_p2_lock_personality.Enabled = True

                cbx_p3_age.Enabled = True
                nud_p3_food.Enabled = True
                nud_p3_wood.Enabled = True
                nud_p3_stone.Enabled = True
                nud_p3_gold.Enabled = True
                nud_p3_population.Enabled = True
                nud_p3_priority.Enabled = True
                cbx_p3_color.Enabled = True
                tbx_p3_tribe_name.Enabled = True
                tbx_p3_name_string_id.Enabled = True
                cbx_p3_ai.Enabled = True
                cbx_p3_ai_personality.Enabled = True
                cbx_p3_civilization.Enabled = True
                cbx_p3_architecture.Enabled = True
                cbx_p3_lock_civ.Enabled = True
                cbx_p3_lock_personality.Enabled = True

                cbx_p4_age.Enabled = True
                nud_p4_food.Enabled = True
                nud_p4_wood.Enabled = True
                nud_p4_stone.Enabled = True
                nud_p4_gold.Enabled = True
                nud_p4_population.Enabled = True
                nud_p4_priority.Enabled = True
                cbx_p4_color.Enabled = True
                tbx_p4_tribe_name.Enabled = True
                tbx_p4_name_string_id.Enabled = True
                cbx_p4_ai.Enabled = True
                cbx_p4_ai_personality.Enabled = True
                cbx_p4_civilization.Enabled = True
                cbx_p4_architecture.Enabled = True
                cbx_p4_lock_civ.Enabled = True
                cbx_p4_lock_personality.Enabled = True

                cbx_p5_age.Enabled = True
                nud_p5_food.Enabled = True
                nud_p5_wood.Enabled = True
                nud_p5_stone.Enabled = True
                nud_p5_gold.Enabled = True
                nud_p5_population.Enabled = True
                nud_p5_priority.Enabled = True
                cbx_p5_color.Enabled = True
                tbx_p5_tribe_name.Enabled = True
                tbx_p5_name_string_id.Enabled = True
                cbx_p5_ai.Enabled = True
                cbx_p5_ai_personality.Enabled = True
                cbx_p5_civilization.Enabled = True
                cbx_p5_architecture.Enabled = True
                cbx_p5_lock_civ.Enabled = True
                cbx_p5_lock_personality.Enabled = True

                cbx_p6_age.Enabled = True
                nud_p6_food.Enabled = True
                nud_p6_wood.Enabled = True
                nud_p6_stone.Enabled = True
                nud_p6_gold.Enabled = True
                nud_p6_population.Enabled = True
                nud_p6_priority.Enabled = True
                cbx_p6_color.Enabled = True
                tbx_p6_tribe_name.Enabled = True
                tbx_p6_name_string_id.Enabled = True
                cbx_p6_ai.Enabled = True
                cbx_p6_ai_personality.Enabled = True
                cbx_p6_civilization.Enabled = True
                cbx_p6_architecture.Enabled = True
                cbx_p6_lock_civ.Enabled = True
                cbx_p6_lock_personality.Enabled = True

                cbx_p7_age.Enabled = True
                nud_p7_food.Enabled = True
                nud_p7_wood.Enabled = True
                nud_p7_stone.Enabled = True
                nud_p7_gold.Enabled = True
                nud_p7_population.Enabled = True
                nud_p7_priority.Enabled = True
                cbx_p7_color.Enabled = True
                tbx_p7_tribe_name.Enabled = True
                tbx_p7_name_string_id.Enabled = True
                cbx_p7_ai.Enabled = True
                cbx_p7_ai_personality.Enabled = True
                cbx_p7_civilization.Enabled = True
                cbx_p7_architecture.Enabled = True
                cbx_p7_lock_civ.Enabled = True
                cbx_p7_lock_personality.Enabled = True

                cbx_p8_age.Enabled = False
                nud_p8_food.Enabled = False
                nud_p8_wood.Enabled = False
                nud_p8_stone.Enabled = False
                nud_p8_gold.Enabled = False
                nud_p8_population.Enabled = False
                nud_p8_priority.Enabled = False
                cbx_p8_color.Enabled = False
                tbx_p8_tribe_name.Enabled = False
                tbx_p8_name_string_id.Enabled = False
                cbx_p8_ai.Enabled = False
                cbx_p8_ai_personality.Enabled = False
                cbx_p8_civilization.Enabled = False
                cbx_p8_architecture.Enabled = False
                cbx_p8_lock_civ.Enabled = False
                cbx_p8_lock_personality.Enabled = False

                btn_p2_to_p1_diplo.Enabled = True
                btn_p2_to_p3_diplo.Enabled = True
                btn_p2_to_p4_diplo.Enabled = True
                btn_p2_to_p5_diplo.Enabled = True
                btn_p2_to_p6_diplo.Enabled = True
                btn_p2_to_p7_diplo.Enabled = True
                btn_p2_to_p8_diplo.Enabled = True
                cbx_p2_av_me.Enabled = True

                btn_p3_to_p1_diplo.Enabled = True
                btn_p3_to_p2_diplo.Enabled = True
                btn_p3_to_p4_diplo.Enabled = True
                btn_p3_to_p5_diplo.Enabled = True
                btn_p3_to_p6_diplo.Enabled = True
                btn_p3_to_p7_diplo.Enabled = True
                btn_p3_to_p8_diplo.Enabled = True
                cbx_p3_av_me.Enabled = True

                btn_p4_to_p1_diplo.Enabled = True
                btn_p4_to_p2_diplo.Enabled = True
                btn_p4_to_p3_diplo.Enabled = True
                btn_p4_to_p5_diplo.Enabled = True
                btn_p4_to_p6_diplo.Enabled = True
                btn_p4_to_p7_diplo.Enabled = True
                btn_p4_to_p8_diplo.Enabled = True
                cbx_p4_av_me.Enabled = True

                btn_p5_to_p1_diplo.Enabled = True
                btn_p5_to_p2_diplo.Enabled = True
                btn_p5_to_p3_diplo.Enabled = True
                btn_p5_to_p4_diplo.Enabled = True
                btn_p5_to_p6_diplo.Enabled = True
                btn_p5_to_p7_diplo.Enabled = True
                btn_p5_to_p8_diplo.Enabled = True
                cbx_p5_av_me.Enabled = True

                btn_p6_to_p1_diplo.Enabled = True
                btn_p6_to_p2_diplo.Enabled = True
                btn_p6_to_p3_diplo.Enabled = True
                btn_p6_to_p4_diplo.Enabled = True
                btn_p6_to_p5_diplo.Enabled = True
                btn_p6_to_p7_diplo.Enabled = True
                btn_p6_to_p8_diplo.Enabled = True
                cbx_p6_av_me.Enabled = True

                btn_p7_to_p1_diplo.Enabled = True
                btn_p7_to_p2_diplo.Enabled = True
                btn_p7_to_p3_diplo.Enabled = True
                btn_p7_to_p4_diplo.Enabled = True
                btn_p7_to_p5_diplo.Enabled = True
                btn_p7_to_p6_diplo.Enabled = True
                btn_p7_to_p8_diplo.Enabled = True
                cbx_p7_av_me.Enabled = True

                btn_p8_to_p1_diplo.Enabled = False
                btn_p8_to_p2_diplo.Enabled = False
                btn_p8_to_p3_diplo.Enabled = False
                btn_p8_to_p4_diplo.Enabled = False
                btn_p8_to_p5_diplo.Enabled = False
                btn_p8_to_p6_diplo.Enabled = False
                btn_p8_to_p7_diplo.Enabled = False
                cbx_p8_av_me.Enabled = False

                cbx_p2_av_them.Enabled = True
                cbx_p3_av_them.Enabled = True
                cbx_p4_av_them.Enabled = True
                cbx_p5_av_them.Enabled = True
                cbx_p6_av_them.Enabled = True
                cbx_p7_av_them.Enabled = True
                cbx_p8_av_them.Enabled = False

            ElseIf cbx_total_players.SelectedIndex = 7 Then

                ' 8 players...

                btn_p1_to_p2_diplo.Enabled = True
                btn_p1_to_p3_diplo.Enabled = True
                btn_p1_to_p4_diplo.Enabled = True
                btn_p1_to_p5_diplo.Enabled = True
                btn_p1_to_p6_diplo.Enabled = True
                btn_p1_to_p7_diplo.Enabled = True
                btn_p1_to_p8_diplo.Enabled = True

                cbx_p2_age.Enabled = True
                nud_p2_food.Enabled = True
                nud_p2_wood.Enabled = True
                nud_p2_stone.Enabled = True
                nud_p2_gold.Enabled = True
                nud_p2_population.Enabled = True
                nud_p2_priority.Enabled = True
                cbx_p2_color.Enabled = True
                tbx_p2_tribe_name.Enabled = True
                tbx_p2_name_string_id.Enabled = True
                cbx_p2_ai.Enabled = True
                cbx_p2_ai_personality.Enabled = True
                cbx_p2_civilization.Enabled = True
                cbx_p2_architecture.Enabled = True
                cbx_p2_lock_civ.Enabled = True
                cbx_p2_lock_personality.Enabled = True

                cbx_p3_age.Enabled = True
                nud_p3_food.Enabled = True
                nud_p3_wood.Enabled = True
                nud_p3_stone.Enabled = True
                nud_p3_gold.Enabled = True
                nud_p3_population.Enabled = True
                nud_p3_priority.Enabled = True
                cbx_p3_color.Enabled = True
                tbx_p3_tribe_name.Enabled = True
                tbx_p3_name_string_id.Enabled = True
                cbx_p3_ai.Enabled = True
                cbx_p3_ai_personality.Enabled = True
                cbx_p3_civilization.Enabled = True
                cbx_p3_architecture.Enabled = True
                cbx_p3_lock_civ.Enabled = True
                cbx_p3_lock_personality.Enabled = True

                cbx_p4_age.Enabled = True
                nud_p4_food.Enabled = True
                nud_p4_wood.Enabled = True
                nud_p4_stone.Enabled = True
                nud_p4_gold.Enabled = True
                nud_p4_population.Enabled = True
                nud_p4_priority.Enabled = True
                cbx_p4_color.Enabled = True
                tbx_p4_tribe_name.Enabled = True
                tbx_p4_name_string_id.Enabled = True
                cbx_p4_ai.Enabled = True
                cbx_p4_ai_personality.Enabled = True
                cbx_p4_civilization.Enabled = True
                cbx_p4_architecture.Enabled = True
                cbx_p4_lock_civ.Enabled = True
                cbx_p4_lock_personality.Enabled = True

                cbx_p5_age.Enabled = True
                nud_p5_food.Enabled = True
                nud_p5_wood.Enabled = True
                nud_p5_stone.Enabled = True
                nud_p5_gold.Enabled = True
                nud_p5_population.Enabled = True
                nud_p5_priority.Enabled = True
                cbx_p5_color.Enabled = True
                tbx_p5_tribe_name.Enabled = True
                tbx_p5_name_string_id.Enabled = True
                cbx_p5_ai.Enabled = True
                cbx_p5_ai_personality.Enabled = True
                cbx_p5_civilization.Enabled = True
                cbx_p5_architecture.Enabled = True
                cbx_p5_lock_civ.Enabled = True
                cbx_p5_lock_personality.Enabled = True

                cbx_p6_age.Enabled = True
                nud_p6_food.Enabled = True
                nud_p6_wood.Enabled = True
                nud_p6_stone.Enabled = True
                nud_p6_gold.Enabled = True
                nud_p6_population.Enabled = True
                nud_p6_priority.Enabled = True
                cbx_p6_color.Enabled = True
                tbx_p6_tribe_name.Enabled = True
                tbx_p6_name_string_id.Enabled = True
                cbx_p6_ai.Enabled = True
                cbx_p6_ai_personality.Enabled = True
                cbx_p6_civilization.Enabled = True
                cbx_p6_architecture.Enabled = True
                cbx_p6_lock_civ.Enabled = True
                cbx_p6_lock_personality.Enabled = True

                cbx_p7_age.Enabled = True
                nud_p7_food.Enabled = True
                nud_p7_wood.Enabled = True
                nud_p7_stone.Enabled = True
                nud_p7_gold.Enabled = True
                nud_p7_population.Enabled = True
                nud_p7_priority.Enabled = True
                cbx_p7_color.Enabled = True
                tbx_p7_tribe_name.Enabled = True
                tbx_p7_name_string_id.Enabled = True
                cbx_p7_ai.Enabled = True
                cbx_p7_ai_personality.Enabled = True
                cbx_p7_civilization.Enabled = True
                cbx_p7_architecture.Enabled = True
                cbx_p7_lock_civ.Enabled = True
                cbx_p7_lock_personality.Enabled = True

                cbx_p8_age.Enabled = True
                nud_p8_food.Enabled = True
                nud_p8_wood.Enabled = True
                nud_p8_stone.Enabled = True
                nud_p8_gold.Enabled = True
                nud_p8_population.Enabled = True
                nud_p8_priority.Enabled = True
                cbx_p8_color.Enabled = True
                tbx_p8_tribe_name.Enabled = True
                tbx_p8_name_string_id.Enabled = True
                cbx_p8_ai.Enabled = True
                cbx_p8_ai_personality.Enabled = True
                cbx_p8_civilization.Enabled = True
                cbx_p8_architecture.Enabled = True
                cbx_p8_lock_civ.Enabled = True
                cbx_p8_lock_personality.Enabled = True

                btn_p2_to_p1_diplo.Enabled = True
                btn_p2_to_p3_diplo.Enabled = True
                btn_p2_to_p4_diplo.Enabled = True
                btn_p2_to_p5_diplo.Enabled = True
                btn_p2_to_p6_diplo.Enabled = True
                btn_p2_to_p7_diplo.Enabled = True
                btn_p2_to_p8_diplo.Enabled = True
                cbx_p2_av_me.Enabled = True

                btn_p3_to_p1_diplo.Enabled = True
                btn_p3_to_p2_diplo.Enabled = True
                btn_p3_to_p4_diplo.Enabled = True
                btn_p3_to_p5_diplo.Enabled = True
                btn_p3_to_p6_diplo.Enabled = True
                btn_p3_to_p7_diplo.Enabled = True
                btn_p3_to_p8_diplo.Enabled = True
                cbx_p3_av_me.Enabled = True

                btn_p4_to_p1_diplo.Enabled = True
                btn_p4_to_p2_diplo.Enabled = True
                btn_p4_to_p3_diplo.Enabled = True
                btn_p4_to_p5_diplo.Enabled = True
                btn_p4_to_p6_diplo.Enabled = True
                btn_p4_to_p7_diplo.Enabled = True
                btn_p4_to_p8_diplo.Enabled = True
                cbx_p4_av_me.Enabled = True

                btn_p5_to_p1_diplo.Enabled = True
                btn_p5_to_p2_diplo.Enabled = True
                btn_p5_to_p3_diplo.Enabled = True
                btn_p5_to_p4_diplo.Enabled = True
                btn_p5_to_p6_diplo.Enabled = True
                btn_p5_to_p7_diplo.Enabled = True
                btn_p5_to_p8_diplo.Enabled = True
                cbx_p5_av_me.Enabled = True

                btn_p6_to_p1_diplo.Enabled = True
                btn_p6_to_p2_diplo.Enabled = True
                btn_p6_to_p3_diplo.Enabled = True
                btn_p6_to_p4_diplo.Enabled = True
                btn_p6_to_p5_diplo.Enabled = True
                btn_p6_to_p7_diplo.Enabled = True
                btn_p6_to_p8_diplo.Enabled = True
                cbx_p6_av_me.Enabled = True

                btn_p7_to_p1_diplo.Enabled = True
                btn_p7_to_p2_diplo.Enabled = True
                btn_p7_to_p3_diplo.Enabled = True
                btn_p7_to_p4_diplo.Enabled = True
                btn_p7_to_p5_diplo.Enabled = True
                btn_p7_to_p6_diplo.Enabled = True
                btn_p7_to_p8_diplo.Enabled = True
                cbx_p7_av_me.Enabled = True

                btn_p8_to_p1_diplo.Enabled = True
                btn_p8_to_p2_diplo.Enabled = True
                btn_p8_to_p3_diplo.Enabled = True
                btn_p8_to_p4_diplo.Enabled = True
                btn_p8_to_p5_diplo.Enabled = True
                btn_p8_to_p6_diplo.Enabled = True
                btn_p8_to_p7_diplo.Enabled = True
                cbx_p8_av_me.Enabled = True

                cbx_p2_av_them.Enabled = True
                cbx_p3_av_them.Enabled = True
                cbx_p4_av_them.Enabled = True
                cbx_p5_av_them.Enabled = True
                cbx_p6_av_them.Enabled = True
                cbx_p7_av_them.Enabled = True
                cbx_p8_av_them.Enabled = True

            End If

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_gaia_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_age.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_gaia_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_food.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_gaia_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_wood.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_gaia_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_stone.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_gaia_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_gold.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_gaia_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_population.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_gaia_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_gaia_priority.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_gaia_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_color.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_gaia_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_gaia_tribe_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_gaia_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_gaia_name_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_gaia_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_gaia_ai.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_gaia_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_ai_personality.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_gaia_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_civilization.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_gaia_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gaia_architecture.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_gaia_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_gaia_lock_civ.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_gaia_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_gaia_lock_personality.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_age.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p1_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_food.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p1_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_wood.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p1_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_stone.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p1_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_gold.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p1_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_population.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p1_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p1_priority.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_color.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p1_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p1_tribe_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p1_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p1_name_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_ai.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_ai_personality.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_civilization.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p1_architecture.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_lock_civ.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_lock_personality.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_age.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p2_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_food.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p2_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_wood.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p2_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_stone.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p2_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_gold.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p2_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_population.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p2_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p2_priority.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_color.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p2_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p2_tribe_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p2_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p2_name_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_ai.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_ai_personality.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_civilization.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p2_architecture.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_lock_civ.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_lock_personality.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_age.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p3_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_food.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p3_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_wood.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p3_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_stone.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p3_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_gold.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p3_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_population.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p3_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p3_priority.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_color.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p3_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p3_tribe_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p3_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p3_name_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_ai.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_ai_personality.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_civilization.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p3_architecture.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_lock_civ.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_lock_personality.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_age.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p4_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_food.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p4_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_wood.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p4_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_stone.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p4_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_gold.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p4_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_population.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p4_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p4_priority.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_color.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p4_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p4_tribe_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p4_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p4_name_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_ai.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_ai_personality.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_civilization.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p4_architecture.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_lock_civ.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_lock_personality.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_age.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p5_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_food.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p5_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_wood.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p5_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_stone.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p5_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_gold.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p5_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_population.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p5_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p5_priority.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_color.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p5_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p5_tribe_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p5_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p5_name_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_ai.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_ai_personality.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_civilization.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p5_architecture.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_lock_civ.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_lock_personality.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_age.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p6_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_food.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p6_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_wood.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p6_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_stone.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p6_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_gold.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p6_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_population.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p6_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p6_priority.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_color.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p6_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p6_tribe_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p6_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p6_name_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_ai.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_ai_personality.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_civilization.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p6_architecture.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_lock_civ.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_lock_personality.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_age.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p7_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_food.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p7_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_wood.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p7_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_stone.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p7_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_gold.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p7_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_population.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p7_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p7_priority.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_color.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p7_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p7_tribe_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p7_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p7_name_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_ai.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_ai_personality.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_civilization.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p7_architecture.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_lock_civ.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_lock_personality.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_age.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p8_food_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_food.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p8_wood_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_wood.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p8_stone_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_stone.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p8_gold_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_gold.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p8_population_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_population.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub nud_p8_priority_ValueChanged(sender As Object, e As EventArgs) Handles nud_p8_priority.ValueChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_color.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p8_tribe_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_p8_tribe_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_p8_name_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_p8_name_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_ai_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_ai.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_ai_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_ai_personality.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_civilization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_civilization.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_architecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_p8_architecture.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_lock_civ_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_lock_civ.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_lock_personality_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_lock_personality.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' [TABS: OBJECTS CODE] -----------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub lbx_objects_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_objects_1.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_objects_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_objects_2.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_map_x_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_map_x.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_map_y_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_map_y.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_placed_objects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_placed_objects.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_object_player_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_object_player.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_create_unit_Click(sender As Object, e As EventArgs) Handles btn_create_unit.Click

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_remove_unit_Click(sender As Object, e As EventArgs) Handles btn_remove_unit.Click

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' [TABS: DIPLOMACY CODE] -------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub btn_p1_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p2_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p1_to_p2_diplo.Text = "Enemy" And clicked = False Then
                btn_p1_to_p2_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p1_to_p2_diplo.Text = "Neutral" And clicked = False Then
                btn_p1_to_p2_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p1_to_p2_diplo.Text = "Ally" And clicked = False Then
                btn_p1_to_p2_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p1_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p3_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p1_to_p3_diplo.Text = "Enemy" And clicked = False Then
                btn_p1_to_p3_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p1_to_p3_diplo.Text = "Neutral" And clicked = False Then
                btn_p1_to_p3_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p1_to_p3_diplo.Text = "Ally" And clicked = False Then
                btn_p1_to_p3_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p1_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p4_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p1_to_p4_diplo.Text = "Enemy" And clicked = False Then
                btn_p1_to_p4_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p1_to_p4_diplo.Text = "Neutral" And clicked = False Then
                btn_p1_to_p4_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p1_to_p4_diplo.Text = "Ally" And clicked = False Then
                btn_p1_to_p4_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p1_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p5_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p1_to_p5_diplo.Text = "Enemy" And clicked = False Then
                btn_p1_to_p5_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p1_to_p5_diplo.Text = "Neutral" And clicked = False Then
                btn_p1_to_p5_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p1_to_p5_diplo.Text = "Ally" And clicked = False Then
                btn_p1_to_p5_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p1_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p6_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p1_to_p6_diplo.Text = "Enemy" And clicked = False Then
                btn_p1_to_p6_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p1_to_p6_diplo.Text = "Neutral" And clicked = False Then
                btn_p1_to_p6_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p1_to_p6_diplo.Text = "Ally" And clicked = False Then
                btn_p1_to_p6_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p1_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p7_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p1_to_p7_diplo.Text = "Enemy" And clicked = False Then
                btn_p1_to_p7_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p1_to_p7_diplo.Text = "Neutral" And clicked = False Then
                btn_p1_to_p7_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p1_to_p7_diplo.Text = "Ally" And clicked = False Then
                btn_p1_to_p7_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p1_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p8_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p1_to_p8_diplo.Text = "Enemy" And clicked = False Then
                btn_p1_to_p8_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p1_to_p8_diplo.Text = "Neutral" And clicked = False Then
                btn_p1_to_p8_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p1_to_p8_diplo.Text = "Ally" And clicked = False Then
                btn_p1_to_p8_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_av_me.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p2_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p1_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p2_to_p1_diplo.Text = "Enemy" And clicked = False Then
                btn_p2_to_p1_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p2_to_p1_diplo.Text = "Neutral" And clicked = False Then
                btn_p2_to_p1_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p2_to_p1_diplo.Text = "Ally" And clicked = False Then
                btn_p2_to_p1_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p2_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p3_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p2_to_p3_diplo.Text = "Enemy" And clicked = False Then
                btn_p2_to_p3_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p2_to_p3_diplo.Text = "Neutral" And clicked = False Then
                btn_p2_to_p3_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p2_to_p3_diplo.Text = "Ally" And clicked = False Then
                btn_p2_to_p3_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p2_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p4_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p2_to_p4_diplo.Text = "Enemy" And clicked = False Then
                btn_p2_to_p4_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p2_to_p4_diplo.Text = "Neutral" And clicked = False Then
                btn_p2_to_p4_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p2_to_p4_diplo.Text = "Ally" And clicked = False Then
                btn_p2_to_p4_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p2_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p5_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p2_to_p5_diplo.Text = "Enemy" And clicked = False Then
                btn_p2_to_p5_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p2_to_p5_diplo.Text = "Neutral" And clicked = False Then
                btn_p2_to_p5_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p2_to_p5_diplo.Text = "Ally" And clicked = False Then
                btn_p2_to_p5_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p2_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p6_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p2_to_p6_diplo.Text = "Enemy" And clicked = False Then
                btn_p2_to_p6_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p2_to_p6_diplo.Text = "Neutral" And clicked = False Then
                btn_p2_to_p6_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p2_to_p6_diplo.Text = "Ally" And clicked = False Then
                btn_p2_to_p6_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p2_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p7_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p2_to_p7_diplo.Text = "Enemy" And clicked = False Then
                btn_p2_to_p7_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p2_to_p7_diplo.Text = "Neutral" And clicked = False Then
                btn_p2_to_p7_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p2_to_p7_diplo.Text = "Ally" And clicked = False Then
                btn_p2_to_p7_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p2_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p2_to_p8_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p2_to_p8_diplo.Text = "Enemy" And clicked = False Then
                btn_p2_to_p8_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p2_to_p8_diplo.Text = "Neutral" And clicked = False Then
                btn_p2_to_p8_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p2_to_p8_diplo.Text = "Ally" And clicked = False Then
                btn_p2_to_p8_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_av_me.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p3_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p1_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p3_to_p1_diplo.Text = "Enemy" And clicked = False Then
                btn_p3_to_p1_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p3_to_p1_diplo.Text = "Neutral" And clicked = False Then
                btn_p3_to_p1_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p3_to_p1_diplo.Text = "Ally" And clicked = False Then
                btn_p3_to_p1_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p3_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p2_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p3_to_p2_diplo.Text = "Enemy" And clicked = False Then
                btn_p3_to_p2_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p3_to_p2_diplo.Text = "Neutral" And clicked = False Then
                btn_p3_to_p2_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p3_to_p2_diplo.Text = "Ally" And clicked = False Then
                btn_p3_to_p2_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p3_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p4_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p3_to_p4_diplo.Text = "Enemy" And clicked = False Then
                btn_p3_to_p4_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p3_to_p4_diplo.Text = "Neutral" And clicked = False Then
                btn_p3_to_p4_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p3_to_p4_diplo.Text = "Ally" And clicked = False Then
                btn_p3_to_p4_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p3_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p5_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p3_to_p5_diplo.Text = "Enemy" And clicked = False Then
                btn_p3_to_p5_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p3_to_p5_diplo.Text = "Neutral" And clicked = False Then
                btn_p3_to_p5_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p3_to_p5_diplo.Text = "Ally" And clicked = False Then
                btn_p3_to_p5_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p3_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p6_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p3_to_p6_diplo.Text = "Enemy" And clicked = False Then
                btn_p3_to_p6_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p3_to_p6_diplo.Text = "Neutral" And clicked = False Then
                btn_p3_to_p6_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p3_to_p6_diplo.Text = "Ally" And clicked = False Then
                btn_p3_to_p6_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p3_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p7_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p3_to_p7_diplo.Text = "Enemy" And clicked = False Then
                btn_p3_to_p7_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p3_to_p7_diplo.Text = "Neutral" And clicked = False Then
                btn_p3_to_p7_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p3_to_p7_diplo.Text = "Ally" And clicked = False Then
                btn_p3_to_p7_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p3_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p3_to_p8_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p3_to_p8_diplo.Text = "Enemy" And clicked = False Then
                btn_p3_to_p8_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p3_to_p8_diplo.Text = "Neutral" And clicked = False Then
                btn_p3_to_p8_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p3_to_p8_diplo.Text = "Ally" And clicked = False Then
                btn_p3_to_p8_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_av_me.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p4_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p1_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p4_to_p1_diplo.Text = "Enemy" And clicked = False Then
                btn_p4_to_p1_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p4_to_p1_diplo.Text = "Neutral" And clicked = False Then
                btn_p4_to_p1_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p4_to_p1_diplo.Text = "Ally" And clicked = False Then
                btn_p4_to_p1_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p4_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p2_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p4_to_p2_diplo.Text = "Enemy" And clicked = False Then
                btn_p4_to_p2_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p4_to_p2_diplo.Text = "Neutral" And clicked = False Then
                btn_p4_to_p2_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p4_to_p2_diplo.Text = "Ally" And clicked = False Then
                btn_p4_to_p2_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p4_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p3_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p4_to_p3_diplo.Text = "Enemy" And clicked = False Then
                btn_p4_to_p3_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p4_to_p3_diplo.Text = "Neutral" And clicked = False Then
                btn_p4_to_p3_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p4_to_p3_diplo.Text = "Ally" And clicked = False Then
                btn_p4_to_p3_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p4_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p5_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p4_to_p5_diplo.Text = "Enemy" And clicked = False Then
                btn_p4_to_p5_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p4_to_p5_diplo.Text = "Neutral" And clicked = False Then
                btn_p4_to_p5_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p4_to_p5_diplo.Text = "Ally" And clicked = False Then
                btn_p4_to_p5_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p4_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p6_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p4_to_p6_diplo.Text = "Enemy" And clicked = False Then
                btn_p4_to_p6_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p4_to_p6_diplo.Text = "Neutral" And clicked = False Then
                btn_p4_to_p6_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p4_to_p6_diplo.Text = "Ally" And clicked = False Then
                btn_p4_to_p6_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p4_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p7_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p4_to_p7_diplo.Text = "Enemy" And clicked = False Then
                btn_p4_to_p7_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p4_to_p7_diplo.Text = "Neutral" And clicked = False Then
                btn_p4_to_p7_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p4_to_p7_diplo.Text = "Ally" And clicked = False Then
                btn_p4_to_p7_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p4_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p4_to_p8_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p4_to_p8_diplo.Text = "Enemy" And clicked = False Then
                btn_p4_to_p8_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p4_to_p8_diplo.Text = "Neutral" And clicked = False Then
                btn_p4_to_p8_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p4_to_p8_diplo.Text = "Ally" And clicked = False Then
                btn_p4_to_p8_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_av_me.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p5_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p1_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p5_to_p1_diplo.Text = "Enemy" And clicked = False Then
                btn_p5_to_p1_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p5_to_p1_diplo.Text = "Neutral" And clicked = False Then
                btn_p5_to_p1_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p5_to_p1_diplo.Text = "Ally" And clicked = False Then
                btn_p5_to_p1_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p5_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p2_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p5_to_p2_diplo.Text = "Enemy" And clicked = False Then
                btn_p5_to_p2_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p5_to_p2_diplo.Text = "Neutral" And clicked = False Then
                btn_p5_to_p2_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p5_to_p2_diplo.Text = "Ally" And clicked = False Then
                btn_p5_to_p2_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p5_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p3_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p5_to_p3_diplo.Text = "Enemy" And clicked = False Then
                btn_p5_to_p3_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p5_to_p3_diplo.Text = "Neutral" And clicked = False Then
                btn_p5_to_p3_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p5_to_p3_diplo.Text = "Ally" And clicked = False Then
                btn_p5_to_p3_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p5_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p4_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p5_to_p4_diplo.Text = "Enemy" And clicked = False Then
                btn_p5_to_p4_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p5_to_p4_diplo.Text = "Neutral" And clicked = False Then
                btn_p5_to_p4_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p5_to_p4_diplo.Text = "Ally" And clicked = False Then
                btn_p5_to_p4_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p5_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p6_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p5_to_p6_diplo.Text = "Enemy" And clicked = False Then
                btn_p5_to_p6_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p5_to_p6_diplo.Text = "Neutral" And clicked = False Then
                btn_p5_to_p6_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p5_to_p6_diplo.Text = "Ally" And clicked = False Then
                btn_p5_to_p6_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p5_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p7_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p5_to_p7_diplo.Text = "Enemy" And clicked = False Then
                btn_p5_to_p7_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p5_to_p7_diplo.Text = "Neutral" And clicked = False Then
                btn_p5_to_p7_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p5_to_p7_diplo.Text = "Ally" And clicked = False Then
                btn_p5_to_p7_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p5_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p5_to_p8_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p5_to_p8_diplo.Text = "Enemy" And clicked = False Then
                btn_p5_to_p8_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p5_to_p8_diplo.Text = "Neutral" And clicked = False Then
                btn_p5_to_p8_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p5_to_p8_diplo.Text = "Ally" And clicked = False Then
                btn_p5_to_p8_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_av_me.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p6_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p1_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p6_to_p1_diplo.Text = "Enemy" And clicked = False Then
                btn_p6_to_p1_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p6_to_p1_diplo.Text = "Neutral" And clicked = False Then
                btn_p6_to_p1_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p6_to_p1_diplo.Text = "Ally" And clicked = False Then
                btn_p6_to_p1_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p6_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p2_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p6_to_p2_diplo.Text = "Enemy" And clicked = False Then
                btn_p6_to_p2_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p6_to_p2_diplo.Text = "Neutral" And clicked = False Then
                btn_p6_to_p2_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p6_to_p2_diplo.Text = "Ally" And clicked = False Then
                btn_p6_to_p2_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p6_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p3_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p6_to_p3_diplo.Text = "Enemy" And clicked = False Then
                btn_p6_to_p3_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p6_to_p3_diplo.Text = "Neutral" And clicked = False Then
                btn_p6_to_p3_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p6_to_p3_diplo.Text = "Ally" And clicked = False Then
                btn_p6_to_p3_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p6_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p4_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p6_to_p4_diplo.Text = "Enemy" And clicked = False Then
                btn_p6_to_p4_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p6_to_p4_diplo.Text = "Neutral" And clicked = False Then
                btn_p6_to_p4_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p6_to_p4_diplo.Text = "Ally" And clicked = False Then
                btn_p6_to_p4_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p6_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p5_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p6_to_p5_diplo.Text = "Enemy" And clicked = False Then
                btn_p6_to_p5_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p6_to_p5_diplo.Text = "Neutral" And clicked = False Then
                btn_p6_to_p5_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p6_to_p5_diplo.Text = "Ally" And clicked = False Then
                btn_p6_to_p5_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p6_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p7_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p6_to_p7_diplo.Text = "Enemy" And clicked = False Then
                btn_p6_to_p7_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p6_to_p7_diplo.Text = "Neutral" And clicked = False Then
                btn_p6_to_p7_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p6_to_p7_diplo.Text = "Ally" And clicked = False Then
                btn_p6_to_p7_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p6_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p6_to_p8_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p6_to_p8_diplo.Text = "Enemy" And clicked = False Then
                btn_p6_to_p8_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p6_to_p8_diplo.Text = "Neutral" And clicked = False Then
                btn_p6_to_p8_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p6_to_p8_diplo.Text = "Ally" And clicked = False Then
                btn_p6_to_p8_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_av_me.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p7_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p1_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p7_to_p1_diplo.Text = "Enemy" And clicked = False Then
                btn_p7_to_p1_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p7_to_p1_diplo.Text = "Neutral" And clicked = False Then
                btn_p7_to_p1_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p7_to_p1_diplo.Text = "Ally" And clicked = False Then
                btn_p7_to_p1_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p7_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p2_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p7_to_p2_diplo.Text = "Enemy" And clicked = False Then
                btn_p7_to_p2_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p7_to_p2_diplo.Text = "Neutral" And clicked = False Then
                btn_p7_to_p2_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p7_to_p2_diplo.Text = "Ally" And clicked = False Then
                btn_p7_to_p2_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p7_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p3_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p7_to_p3_diplo.Text = "Enemy" And clicked = False Then
                btn_p7_to_p3_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p7_to_p3_diplo.Text = "Neutral" And clicked = False Then
                btn_p7_to_p3_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p7_to_p3_diplo.Text = "Ally" And clicked = False Then
                btn_p7_to_p3_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p7_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p4_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p7_to_p4_diplo.Text = "Enemy" And clicked = False Then
                btn_p7_to_p4_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p7_to_p4_diplo.Text = "Neutral" And clicked = False Then
                btn_p7_to_p4_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p7_to_p4_diplo.Text = "Ally" And clicked = False Then
                btn_p7_to_p4_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p7_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p5_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p7_to_p5_diplo.Text = "Enemy" And clicked = False Then
                btn_p7_to_p5_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p7_to_p5_diplo.Text = "Neutral" And clicked = False Then
                btn_p7_to_p5_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p7_to_p5_diplo.Text = "Ally" And clicked = False Then
                btn_p7_to_p5_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p7_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p6_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p7_to_p6_diplo.Text = "Enemy" And clicked = False Then
                btn_p7_to_p6_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p7_to_p6_diplo.Text = "Neutral" And clicked = False Then
                btn_p7_to_p6_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p7_to_p6_diplo.Text = "Ally" And clicked = False Then
                btn_p7_to_p6_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p7_to_p8_diplo_Click(sender As Object, e As EventArgs) Handles btn_p7_to_p8_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p7_to_p8_diplo.Text = "Enemy" And clicked = False Then
                btn_p7_to_p8_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p7_to_p8_diplo.Text = "Neutral" And clicked = False Then
                btn_p7_to_p8_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p7_to_p8_diplo.Text = "Ally" And clicked = False Then
                btn_p7_to_p8_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_av_me.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p8_to_p1_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p1_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p8_to_p1_diplo.Text = "Enemy" And clicked = False Then
                btn_p8_to_p1_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p8_to_p1_diplo.Text = "Neutral" And clicked = False Then
                btn_p8_to_p1_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p8_to_p1_diplo.Text = "Ally" And clicked = False Then
                btn_p8_to_p1_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p8_to_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p2_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p8_to_p2_diplo.Text = "Enemy" And clicked = False Then
                btn_p8_to_p2_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p8_to_p2_diplo.Text = "Neutral" And clicked = False Then
                btn_p8_to_p2_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p8_to_p2_diplo.Text = "Ally" And clicked = False Then
                btn_p8_to_p2_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p8_to_p3_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p3_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p8_to_p3_diplo.Text = "Enemy" And clicked = False Then
                btn_p8_to_p3_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p8_to_p3_diplo.Text = "Neutral" And clicked = False Then
                btn_p8_to_p3_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p8_to_p3_diplo.Text = "Ally" And clicked = False Then
                btn_p8_to_p3_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p8_to_p4_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p4_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p8_to_p4_diplo.Text = "Enemy" And clicked = False Then
                btn_p8_to_p4_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p8_to_p4_diplo.Text = "Neutral" And clicked = False Then
                btn_p8_to_p4_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p8_to_p4_diplo.Text = "Ally" And clicked = False Then
                btn_p8_to_p4_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p8_to_p5_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p5_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p8_to_p5_diplo.Text = "Enemy" And clicked = False Then
                btn_p8_to_p5_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p8_to_p5_diplo.Text = "Neutral" And clicked = False Then
                btn_p8_to_p5_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p8_to_p5_diplo.Text = "Ally" And clicked = False Then
                btn_p8_to_p5_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p8_to_p6_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p6_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p8_to_p6_diplo.Text = "Enemy" And clicked = False Then
                btn_p8_to_p6_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p8_to_p6_diplo.Text = "Neutral" And clicked = False Then
                btn_p8_to_p6_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p8_to_p6_diplo.Text = "Ally" And clicked = False Then
                btn_p8_to_p6_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_p8_to_p7_diplo_Click(sender As Object, e As EventArgs) Handles btn_p8_to_p7_diplo.Click

        Try
            Dim clicked As Boolean = False
            If btn_p8_to_p7_diplo.Text = "Enemy" And clicked = False Then
                btn_p8_to_p7_diplo.Text = "Neutral"
                clicked = True
            ElseIf btn_p8_to_p7_diplo.Text = "Neutral" And clicked = False Then
                btn_p8_to_p7_diplo.Text = "Ally"
                clicked = True
            ElseIf btn_p8_to_p7_diplo.Text = "Ally" And clicked = False Then
                btn_p8_to_p7_diplo.Text = "Enemy"
                clicked = True
            End If
            clicked = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_av_me_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_av_me.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p1_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p1_av_them.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p2_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p2_av_them.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p3_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p3_av_them.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p4_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p4_av_them.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p5_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p5_av_them.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p6_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p6_av_them.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p7_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p7_av_them.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_p8_av_them_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_p8_av_them.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_max_teams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_max_teams.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_lock_teams_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_lock_teams.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_choose_teams_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_choose_teams.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_random_starting_points_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_random_starting_points.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' [TABS: VICTORY CODE] ---------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub rbn_standard_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_standard.CheckedChanged

        Try

            cbx_score.Enabled = False
            cbx_time_limit.Enabled = False
            cbx_conquest.Enabled = False
            cbx_exploration.Enabled = False
            cbx_relics.Enabled = False
            cbx_all.Enabled = False
            tbx_exploration_total.Enabled = False
            tbx_relics_total.Enabled = False
            cbx_empire_wars.Enabled = False
            cbx_sudden_death.Enabled = False
            cbx_regicide.Enabled = False
            cbx_king_of_the_hill.Enabled = False

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub rbn_conquest_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_conquest.CheckedChanged

        Try

            cbx_score.Enabled = False
            cbx_time_limit.Enabled = False
            cbx_conquest.Enabled = False
            cbx_exploration.Enabled = False
            cbx_relics.Enabled = False
            cbx_all.Enabled = False
            tbx_exploration_total.Enabled = False
            tbx_relics_total.Enabled = False
            cbx_empire_wars.Enabled = False
            cbx_sudden_death.Enabled = False
            cbx_regicide.Enabled = False
            cbx_king_of_the_hill.Enabled = False

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub rbn_score_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_score.CheckedChanged

        Try
            cbx_score.Enabled = True
            cbx_time_limit.Enabled = False
            cbx_conquest.Enabled = False
            cbx_exploration.Enabled = False
            cbx_relics.Enabled = False
            cbx_all.Enabled = False
            tbx_exploration_total.Enabled = False
            tbx_relics_total.Enabled = False
            cbx_empire_wars.Enabled = False
            cbx_sudden_death.Enabled = False
            cbx_regicide.Enabled = False
            cbx_king_of_the_hill.Enabled = False
        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub rbn_time_limit_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_time_limit.CheckedChanged

        Try

            cbx_score.Enabled = False
            cbx_time_limit.Enabled = True
            cbx_conquest.Enabled = False
            cbx_exploration.Enabled = False
            cbx_relics.Enabled = False
            cbx_all.Enabled = False
            tbx_exploration_total.Enabled = False
            tbx_relics_total.Enabled = False
            cbx_empire_wars.Enabled = False
            cbx_sudden_death.Enabled = False
            cbx_regicide.Enabled = False
            cbx_king_of_the_hill.Enabled = False

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub rbn_custom_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_custom.CheckedChanged

        Try

            cbx_score.Enabled = False
            cbx_time_limit.Enabled = False
            cbx_conquest.Enabled = True
            cbx_exploration.Enabled = True
            cbx_relics.Enabled = True
            cbx_all.Enabled = True
            tbx_exploration_total.Enabled = True
            tbx_relics_total.Enabled = True
            cbx_empire_wars.Enabled = False
            cbx_sudden_death.Enabled = False
            cbx_regicide.Enabled = False
            cbx_king_of_the_hill.Enabled = False

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub rbn_secondary_game_mode_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_secondary_game_mode.CheckedChanged

        Try

            cbx_score.Enabled = False
            cbx_time_limit.Enabled = False
            cbx_conquest.Enabled = False
            cbx_exploration.Enabled = False
            cbx_relics.Enabled = False
            cbx_all.Enabled = False
            tbx_exploration_total.Enabled = False
            tbx_relics_total.Enabled = False
            cbx_empire_wars.Enabled = True
            cbx_sudden_death.Enabled = True
            cbx_regicide.Enabled = True
            cbx_king_of_the_hill.Enabled = True

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_score_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_score.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_time_limit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_time_limit.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_conquest_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_conquest.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_exploration_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_exploration.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_relics_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_relics.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_all_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_all.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_exploration_total_TextChanged(sender As Object, e As EventArgs) Handles tbx_exploration_total.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_relics_total_TextChanged(sender As Object, e As EventArgs) Handles tbx_relics_total.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_empire_wars_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_empire_wars.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_sudden_death_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_sudden_death.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_regicide_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_regicide.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_king_of_the_hill_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_king_of_the_hill.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' [TABS: OPTIONS CODE] ----------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub clb_disabled_units_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clb_disabled_units.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub clb_disabled_buildings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clb_disabled_buildings.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub clb_disabled_techs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clb_disabled_techs.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_disabled_player_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_disabled_player.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_full_tech_tree_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_full_tech_tree.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_collide_and_correcting_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_collide_and_correcting.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_villager_force_drop_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_villager_force_drop.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_lock_co_op_alliances_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_lock_co_op_alliances.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_testing_difficulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_testing_difficulty.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_view_x_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_view_x.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_view_y_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_view_y.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_camera_view_Click(sender As Object, e As EventArgs) Handles btn_camera_view.Click

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' [TABS: MESSAGES CODE] ---------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub tbx_instructions_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_instructions_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_instructions_TextChanged(sender As Object, e As EventArgs) Handles tbx_instructions.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_hints_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_hints_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_hints_TextChanged(sender As Object, e As EventArgs) Handles tbx_hints.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_victory_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_victory_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_victory_TextChanged(sender As Object, e As EventArgs) Handles tbx_victory.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_loss_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_loss_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_loss_TextChanged(sender As Object, e As EventArgs) Handles tbx_loss.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_history_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_history_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_history_TextChanged(sender As Object, e As EventArgs) Handles tbx_history.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_scout_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_scout_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_scout_TextChanged(sender As Object, e As EventArgs) Handles tbx_scout.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' [TABS: CINEMATICS CODE] -------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub cbx_pregame_cinematic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pregame_cinematic.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_victory_cinematic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_victory_cinematic.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_loss_cinematic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_loss_cinematic.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_instructions_cinematic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_instructions_cinematic.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' [TABS: TRIGGER CODE] ----------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub lbx_trigger_conditions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_trigger_conditions.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_trigger_effects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_trigger_effects.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_trigger_name_TextChanged(sender As Object, e As EventArgs) Handles tbx_trigger_name.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_trigger_starting_state_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_trigger_starting_state.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_trigger_looping_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_trigger_looping.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_trigger_add_condition_Click(sender As Object, e As EventArgs) Handles btn_trigger_add_condition.Click

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub btn_trigger_add_effect_Click(sender As Object, e As EventArgs) Handles btn_trigger_add_effect.Click

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_trigger_description_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_trigger_description_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_trigger_display_as_objective_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_trigger_display_as_objective.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_trigger_description_TextChanged(sender As Object, e As EventArgs) Handles tbx_trigger_description.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_trigger_short_description_string_id_TextChanged(sender As Object, e As EventArgs) Handles tbx_trigger_short_description_string_id.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub cbx_trigger_display_on_screen_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_trigger_display_on_screen.CheckedChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub tbx_trigger_short_description_TextChanged(sender As Object, e As EventArgs) Handles tbx_trigger_short_description.TextChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    Public Sub lbx_created_trigger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_created_trigger.SelectedIndexChanged

        Try

        Catch ex As Exception

            catch_all_errors(ex)
        End Try

    End Sub

    ' ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

End Class