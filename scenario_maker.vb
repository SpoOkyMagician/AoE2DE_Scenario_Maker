Public Class frm_scenario_maker

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

    ' [APPLICATION LOAD CODE]

    Public Sub frm_scenario_maker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' on startup, be sure to define all your variables and reset all gui to a vaild minimum scenario...
        Try
            ' variables/GUI stuff goes here...

        Catch ex As Exception
            MessageBox.Show("An error occured while trying to create variables. Hard Drive/Memory Full?")
        End Try
    End Sub

    ' [TAB: FILE CODE]

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

    ' [TAB: MAP CODE]

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

    ' [TAB: TERRAIN CODE]

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

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Public Sub cbx_use_layers_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_use_layers.CheckedChanged

    End Sub

    ' [TAB: PLAYERS CODE]

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

End Class