Public Class frm_scenario_maker

    ' let's initialize these variables globally so we don't have to worry about scope...

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
    Dim starting_age As Integer() = {0, 0, 0, 0, 0, 0, 0, 0} ' cbx_gaia_age, cbx_p1_age, ... cbx_p8_age (index value)
    Dim starting_food As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0} ' nud_food_gaia, nud_food_p1, ... nud_food_p8 (index value)

    Public Sub frm_scenario_maker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' on startup, be sure to define all your variables and reset all gui to a vaild minimum scenario...
        Try
            ' variables/GUI stuff goes here...

        Catch ex As Exception
            MessageBox.Show("An error occured while trying to create variables. Hard Drive/Memory Full?")
        End Try
    End Sub
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

    Public Sub cbx_total_players_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_total_players.SelectedIndexChanged

    End Sub

    Public Sub nud_food_gaia_ValueChanged(sender As Object, e As EventArgs) Handles nud_food_gaia.ValueChanged

    End Sub

    Public Sub nud_wood_gaia_ValueChanged(sender As Object, e As EventArgs) Handles nud_wood_gaia.ValueChanged

    End Sub

    Public Sub nud_stone_gaia_ValueChanged(sender As Object, e As EventArgs) Handles nud_stone_gaia.ValueChanged

    End Sub

    Public Sub nud_gold_gaia_ValueChanged(sender As Object, e As EventArgs) Handles nud_gold_gaia.ValueChanged

    End Sub

    Public Sub nud_population_gaia_ValueChanged(sender As Object, e As EventArgs) Handles nud_population_gaia.ValueChanged

    End Sub

    Public Sub nud_priority_gaia_ValueChanged(sender As Object, e As EventArgs) Handles nud_priority_gaia.ValueChanged

    End Sub

    Public Sub cbx_color_gaia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_gaia.SelectedIndexChanged

    End Sub

    Public Sub tbx_tribe_name_gaia_TextChanged(sender As Object, e As EventArgs) Handles tbx_tribe_name_gaia.TextChanged

    End Sub

    Public Sub tbx_name_string_id_gaia_TextChanged(sender As Object, e As EventArgs) Handles tbx_name_string_id_gaia.TextChanged

    End Sub

    Public Sub cbx_ai_gaia_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ai_gaia.CheckedChanged

    End Sub

    Public Sub nud_food_p1_ValueChanged(sender As Object, e As EventArgs) Handles nud_food_p1.ValueChanged

    End Sub

    Public Sub nud_wood_p1_ValueChanged(sender As Object, e As EventArgs) Handles nud_wood_p1.ValueChanged

    End Sub

    Public Sub nud_stone_p1_ValueChanged(sender As Object, e As EventArgs) Handles nud_stone_p1.ValueChanged

    End Sub

    Public Sub nud_gold_p1_ValueChanged(sender As Object, e As EventArgs) Handles nud_gold_p1.ValueChanged

    End Sub

    Public Sub nud_population_p1_ValueChanged(sender As Object, e As EventArgs) Handles nud_population_p1.ValueChanged

    End Sub

    Public Sub nud_priority_p1_ValueChanged(sender As Object, e As EventArgs) Handles nud_priority_p1.ValueChanged

    End Sub

    Public Sub cbx_color_p1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_p1.SelectedIndexChanged

    End Sub

    Public Sub tbx_tribe_name_p1_TextChanged(sender As Object, e As EventArgs) Handles tbx_tribe_name_p1.TextChanged

    End Sub

    Public Sub tbx_name_string_id_p1_TextChanged(sender As Object, e As EventArgs) Handles tbx_name_string_id_p1.TextChanged

    End Sub

    Public Sub cbx_ai_p1_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ai_p1.CheckedChanged

    End Sub

    Public Sub nud_food_p2_ValueChanged(sender As Object, e As EventArgs) Handles nud_food_p2.ValueChanged

    End Sub

    Public Sub nud_wood_p2_ValueChanged(sender As Object, e As EventArgs) Handles nud_wood_p2.ValueChanged

    End Sub

    Public Sub nud_stone_p2_ValueChanged(sender As Object, e As EventArgs) Handles nud_stone_p2.ValueChanged

    End Sub

    Public Sub nud_gold_p2_ValueChanged(sender As Object, e As EventArgs) Handles nud_gold_p2.ValueChanged

    End Sub

    Public Sub nud_population_p2_ValueChanged(sender As Object, e As EventArgs) Handles nud_population_p2.ValueChanged

    End Sub

    Public Sub cbx_color_p2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_p2.SelectedIndexChanged

    End Sub

    Public Sub tbx_tribe_name_p2_TextChanged(sender As Object, e As EventArgs) Handles tbx_tribe_name_p2.TextChanged

    End Sub

    Public Sub tbx_name_string_id_p2_TextChanged(sender As Object, e As EventArgs) Handles tbx_name_string_id_p2.TextChanged

    End Sub

    Public Sub cbx_ai_p2_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ai_p2.CheckedChanged

    End Sub

    Public Sub nud_food_p3_ValueChanged(sender As Object, e As EventArgs) Handles nud_food_p3.ValueChanged

    End Sub

    Public Sub nud_wood_p3_ValueChanged(sender As Object, e As EventArgs) Handles nud_wood_p3.ValueChanged

    End Sub

    Public Sub nud_stone_p3_ValueChanged(sender As Object, e As EventArgs) Handles nud_stone_p3.ValueChanged

    End Sub

    Public Sub nud_gold_p3_ValueChanged(sender As Object, e As EventArgs) Handles nud_gold_p3.ValueChanged

    End Sub

    Public Sub nud_population_p3_ValueChanged(sender As Object, e As EventArgs) Handles nud_population_p3.ValueChanged

    End Sub

    Public Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged

    End Sub

    Public Sub cbx_color_p3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_p3.SelectedIndexChanged

    End Sub

    Public Sub tbx_tribe_name_p3_TextChanged(sender As Object, e As EventArgs) Handles tbx_tribe_name_p3.TextChanged

    End Sub

    Public Sub tbx_name_string_id_p3_TextChanged(sender As Object, e As EventArgs) Handles tbx_name_string_id_p3.TextChanged

    End Sub

    Public Sub cbx_ai_p3_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ai_p3.CheckedChanged

    End Sub

    Public Sub nud_food_p4_ValueChanged(sender As Object, e As EventArgs) Handles nud_food_p4.ValueChanged

    End Sub

    Public Sub nud_wood_p4_ValueChanged(sender As Object, e As EventArgs) Handles nud_wood_p4.ValueChanged

    End Sub

    Public Sub nud_stone_p4_ValueChanged(sender As Object, e As EventArgs) Handles nud_stone_p4.ValueChanged

    End Sub

    Public Sub nud_gold_p4_ValueChanged(sender As Object, e As EventArgs) Handles nud_gold_p4.ValueChanged

    End Sub

    Public Sub nud_population_p4_ValueChanged(sender As Object, e As EventArgs) Handles nud_population_p4.ValueChanged

    End Sub

    Public Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged

    End Sub

    Public Sub cbx_color_p4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_p4.SelectedIndexChanged

    End Sub

    Public Sub tbx_tribe_name_p4_TextChanged(sender As Object, e As EventArgs) Handles tbx_tribe_name_p4.TextChanged

    End Sub

    Public Sub tbx_name_string_id_p4_TextChanged(sender As Object, e As EventArgs) Handles tbx_name_string_id_p4.TextChanged

    End Sub

    Public Sub cbx_ai_p4_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ai_p4.CheckedChanged

    End Sub

    Public Sub nud_food_p5_ValueChanged(sender As Object, e As EventArgs) Handles nud_food_p5.ValueChanged

    End Sub

    Public Sub nud_wood_p5_ValueChanged(sender As Object, e As EventArgs) Handles nud_wood_p5.ValueChanged

    End Sub

    Public Sub nud_stone_p5_ValueChanged(sender As Object, e As EventArgs) Handles nud_stone_p5.ValueChanged

    End Sub

    Public Sub nud_gold_p5_ValueChanged(sender As Object, e As EventArgs) Handles nud_gold_p5.ValueChanged

    End Sub

    Public Sub nud_population_p5_ValueChanged(sender As Object, e As EventArgs) Handles nud_population_p5.ValueChanged

    End Sub

    Public Sub cbx_color_p5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_p5.SelectedIndexChanged

    End Sub

    Public Sub tbx_tribe_name_p5_TextChanged(sender As Object, e As EventArgs) Handles tbx_tribe_name_p5.TextChanged

    End Sub

    Public Sub tbx_name_string_id_p5_TextChanged(sender As Object, e As EventArgs) Handles tbx_name_string_id_p5.TextChanged

    End Sub

    Public Sub cbx_ai_p5_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ai_p5.CheckedChanged

    End Sub

    Public Sub nud_food_p6_ValueChanged(sender As Object, e As EventArgs) Handles nud_food_p6.ValueChanged

    End Sub

    Public Sub nud_wood_p6_ValueChanged(sender As Object, e As EventArgs) Handles nud_wood_p6.ValueChanged

    End Sub

    Public Sub nud_stone_p6_ValueChanged(sender As Object, e As EventArgs) Handles nud_stone_p6.ValueChanged

    End Sub

    Public Sub nud_gold_p6_ValueChanged(sender As Object, e As EventArgs) Handles nud_gold_p6.ValueChanged

    End Sub

    Public Sub nud_population_p6_ValueChanged(sender As Object, e As EventArgs) Handles nud_population_p6.ValueChanged

    End Sub

    Public Sub cbx_color_p6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_p6.SelectedIndexChanged

    End Sub

    Public Sub tbx_tribe_name_p6_TextChanged(sender As Object, e As EventArgs) Handles tbx_tribe_name_p6.TextChanged

    End Sub

    Public Sub tbx_name_string_id_p6_TextChanged(sender As Object, e As EventArgs) Handles tbx_name_string_id_p6.TextChanged

    End Sub

    Public Sub cbx_ai_p6_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ai_p6.CheckedChanged

    End Sub

    Public Sub nud_food_p7_ValueChanged(sender As Object, e As EventArgs) Handles nud_food_p7.ValueChanged

    End Sub

    Public Sub nud_wood_p7_ValueChanged(sender As Object, e As EventArgs) Handles nud_wood_p7.ValueChanged

    End Sub

    Public Sub nud_stone_p7_ValueChanged(sender As Object, e As EventArgs) Handles nud_stone_p7.ValueChanged

    End Sub

    Public Sub nud_gold_p7_ValueChanged(sender As Object, e As EventArgs) Handles nud_gold_p7.ValueChanged

    End Sub

    Public Sub nud_population_p7_ValueChanged(sender As Object, e As EventArgs) Handles nud_population_p7.ValueChanged

    End Sub

    Public Sub cbx_color_p7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_p7.SelectedIndexChanged

    End Sub

    Public Sub tbx_tribe_name_p7_TextChanged(sender As Object, e As EventArgs) Handles tbx_tribe_name_p7.TextChanged

    End Sub

    Public Sub tbx_name_string_id_p7_TextChanged(sender As Object, e As EventArgs) Handles tbx_name_string_id_p7.TextChanged

    End Sub

    Public Sub cbx_ai_p7_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ai_p7.CheckedChanged

    End Sub

    Public Sub nud_food_p8_ValueChanged(sender As Object, e As EventArgs) Handles nud_food_p8.ValueChanged

    End Sub

    Public Sub nud_wood_p8_ValueChanged(sender As Object, e As EventArgs) Handles nud_wood_p8.ValueChanged

    End Sub

    Public Sub nud_stone_p8_ValueChanged(sender As Object, e As EventArgs) Handles nud_stone_p8.ValueChanged

    End Sub

    Public Sub nud_gold_p8_ValueChanged(sender As Object, e As EventArgs) Handles nud_gold_p8.ValueChanged

    End Sub

    Public Sub nud_population_p8_ValueChanged(sender As Object, e As EventArgs) Handles nud_population_p8.ValueChanged

    End Sub

    Public Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged

    End Sub

    Public Sub cbx_color_p8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_color_p8.SelectedIndexChanged

    End Sub

    Public Sub tbx_tribe_name_p8_TextChanged(sender As Object, e As EventArgs) Handles tbx_tribe_name_p8.TextChanged

    End Sub

    Public Sub tbx_name_string_id_p8_TextChanged(sender As Object, e As EventArgs) Handles tbx_name_string_id_p8.TextChanged

    End Sub

    Public Sub cbx_ai_p8_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_ai_p8.CheckedChanged

    End Sub

    Public Sub btn_p1_p2_diplo_Click(sender As Object, e As EventArgs) Handles btn_p1_to_p2_diplo.Click

    End Sub

End Class