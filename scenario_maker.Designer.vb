﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_scenario_maker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_scenario_maker))
        tc_main = New TabControl()
        tp_file = New TabPage()
        btn_test = New Button()
        btn_new_scenario = New Button()
        lbl_save_path = New Label()
        lbl_load_path = New Label()
        btn_save = New Button()
        btn_load = New Button()
        tp_map = New TabPage()
        cbx_map_size = New ComboBox()
        nud_mwh_size = New NumericUpDown()
        cbx_team_positions = New CheckBox()
        cbx_default_terrain = New ComboBox()
        cbx_color_mood = New ComboBox()
        cbx_ai_map_type = New ComboBox()
        tp_terrain = New TabPage()
        tp_players = New TabPage()
        cbx_gaia_age = New ComboBox()
        lbl_age = New Label()
        ComboBox6 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        cbx_p2_age = New ComboBox()
        cbx_p1_age = New ComboBox()
        lbl_player_type = New Label()
        cbx_ai_p8 = New CheckBox()
        cbx_ai_p7 = New CheckBox()
        cbx_ai_p6 = New CheckBox()
        cbx_ai_p5 = New CheckBox()
        cbx_ai_p4 = New CheckBox()
        cbx_ai_p3 = New CheckBox()
        cbx_ai_p2 = New CheckBox()
        cbx_ai_p1 = New CheckBox()
        cbx_ai_gaia = New CheckBox()
        lb_name_string_id = New Label()
        tbx_name_string_id_p8 = New TextBox()
        tbx_name_string_id_p7 = New TextBox()
        tbx_name_string_id_p6 = New TextBox()
        tbx_name_string_id_p5 = New TextBox()
        tbx_name_string_id_p4 = New TextBox()
        tbx_name_string_id_p3 = New TextBox()
        tbx_name_string_id_p2 = New TextBox()
        tbx_name_string_id_p1 = New TextBox()
        tbx_name_string_id_gaia = New TextBox()
        lb_tribe_name = New Label()
        tbx_tribe_name_p8 = New TextBox()
        tbx_tribe_name_p7 = New TextBox()
        tbx_tribe_name_p6 = New TextBox()
        tbx_tribe_name_p5 = New TextBox()
        tbx_tribe_name_p4 = New TextBox()
        tbx_tribe_name_p3 = New TextBox()
        tbx_tribe_name_p2 = New TextBox()
        tbx_tribe_name_p1 = New TextBox()
        tbx_tribe_name_gaia = New TextBox()
        cbx_color_p8 = New ComboBox()
        cbx_color_p7 = New ComboBox()
        cbx_color_p6 = New ComboBox()
        cbx_color_p5 = New ComboBox()
        cbx_color_p4 = New ComboBox()
        cbx_color_p3 = New ComboBox()
        cbx_color_p2 = New ComboBox()
        cbx_color_p1 = New ComboBox()
        lb_color = New Label()
        cbx_color_gaia = New ComboBox()
        lb_player_8 = New Label()
        lb_player_7 = New Label()
        lb_player_6 = New Label()
        lb_player_5 = New Label()
        lb_player_4 = New Label()
        lb_player_3 = New Label()
        lb_player_2 = New Label()
        lb_player_1 = New Label()
        lb_gaia = New Label()
        NumericUpDown7 = New NumericUpDown()
        NumericUpDown6 = New NumericUpDown()
        NumericUpDown5 = New NumericUpDown()
        NumericUpDown4 = New NumericUpDown()
        NumericUpDown3 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown1 = New NumericUpDown()
        nud_priority_p1 = New NumericUpDown()
        nud_priority_gaia = New NumericUpDown()
        lb_priority_gaia = New Label()
        nud_population_gaia = New NumericUpDown()
        nud_population_p8 = New NumericUpDown()
        nud_population_p7 = New NumericUpDown()
        nud_population_p6 = New NumericUpDown()
        nud_population_p5 = New NumericUpDown()
        nud_population_p4 = New NumericUpDown()
        nud_population_p3 = New NumericUpDown()
        nud_population_p2 = New NumericUpDown()
        lb_pop = New Label()
        nud_population_p1 = New NumericUpDown()
        nud_gold_gaia = New NumericUpDown()
        nud_gold_p8 = New NumericUpDown()
        nud_gold_p7 = New NumericUpDown()
        nud_gold_p6 = New NumericUpDown()
        nud_gold_p5 = New NumericUpDown()
        nud_gold_p4 = New NumericUpDown()
        nud_gold_p3 = New NumericUpDown()
        nud_gold_p2 = New NumericUpDown()
        lb_gold = New Label()
        nud_gold_p1 = New NumericUpDown()
        nud_stone_gaia = New NumericUpDown()
        nud_stone_p8 = New NumericUpDown()
        nud_stone_p7 = New NumericUpDown()
        nud_stone_p6 = New NumericUpDown()
        nud_stone_p5 = New NumericUpDown()
        nud_stone_p4 = New NumericUpDown()
        nud_stone_p3 = New NumericUpDown()
        nud_stone_p2 = New NumericUpDown()
        lb_stone = New Label()
        nud_stone_p1 = New NumericUpDown()
        nud_wood_gaia = New NumericUpDown()
        nud_wood_p8 = New NumericUpDown()
        nud_wood_p7 = New NumericUpDown()
        nud_wood_p6 = New NumericUpDown()
        nud_wood_p5 = New NumericUpDown()
        nud_wood_p4 = New NumericUpDown()
        nud_wood_p3 = New NumericUpDown()
        nud_wood_p2 = New NumericUpDown()
        lb_wood = New Label()
        nud_wood_p1 = New NumericUpDown()
        nud_food_gaia = New NumericUpDown()
        nud_food_p8 = New NumericUpDown()
        nud_food_p7 = New NumericUpDown()
        nud_food_p6 = New NumericUpDown()
        nud_food_p5 = New NumericUpDown()
        nud_food_p4 = New NumericUpDown()
        nud_food_p3 = New NumericUpDown()
        nud_food_p2 = New NumericUpDown()
        lb_food = New Label()
        nud_food_p1 = New NumericUpDown()
        cbx_total_players = New ComboBox()
        tp_units = New TabPage()
        cbx_unit_player = New ComboBox()
        btn_remove_unit = New Button()
        btn_create_unit = New Button()
        lbx_map_xy = New ListBox()
        lbx_units = New ListBox()
        tp_diplomacy = New TabPage()
        cbx_random_starting_points = New CheckBox()
        cbx_choose_teams = New CheckBox()
        cbx_lock_teams = New CheckBox()
        cbx_max_teams = New ComboBox()
        cbx_p8_av_them = New CheckBox()
        cbx_p7_av_them = New CheckBox()
        cbx_p6_av_them = New CheckBox()
        cbx_p5_av_them = New CheckBox()
        cbx_p4_av_them = New CheckBox()
        cbx_p3_av_them = New CheckBox()
        cbx_p2_av_them = New CheckBox()
        cbx_p1_av_them = New CheckBox()
        cbx_p8_av_me = New CheckBox()
        cbx_p7_av_me = New CheckBox()
        cbx_p6_av_me = New CheckBox()
        btn_p8_to_p7_diplo = New Button()
        btn_p8_to_p6_diplo = New Button()
        btn_p8_to_p5_diplo = New Button()
        btn_p8_to_p4_diplo = New Button()
        btn_p8_to_p3_diplo = New Button()
        btn_p8_to_p2_diplo = New Button()
        btn_p8_to_p1_diplo = New Button()
        btn_p7_to_p8_diplo = New Button()
        btn_p7_to_p6_diplo = New Button()
        btn_p7_to_p5_diplo = New Button()
        btn_p7_to_p4_diplo = New Button()
        btn_p7_to_p3_diplo = New Button()
        btn_p7_to_p2_diplo = New Button()
        btn_p7_to_p1_diplo = New Button()
        btn_p6_to_p8_diplo = New Button()
        btn_p6_to_p7_diplo = New Button()
        btn_p6_to_p5_diplo = New Button()
        btn_p6_to_p4_diplo = New Button()
        btn_p6_to_p3_diplo = New Button()
        btn_p6_to_p2_diplo = New Button()
        btn_p6_to_p1_diplo = New Button()
        cbx_p5_av_me = New CheckBox()
        btn_p5_to_p8_diplo = New Button()
        btn_p5_to_p7_diplo = New Button()
        btn_p5_to_p6_diplo = New Button()
        btn_p5_to_p4_diplo = New Button()
        btn_p5_to_p3_diplo = New Button()
        btn_p5_to_p2_diplo = New Button()
        btn_p5_to_p1_diplo = New Button()
        cbx_p4_av_me = New CheckBox()
        btn_p4_to_p8_diplo = New Button()
        btn_p4_to_p7_diplo = New Button()
        btn_p4_to_p6_diplo = New Button()
        btn_p4_to_p5_diplo = New Button()
        btn_p4_to_p3_diplo = New Button()
        btn_p4_to_p2_diplo = New Button()
        btn_p4_to_p1_diplo = New Button()
        cbx_p3_av_me = New CheckBox()
        btn_p3_to_p8_diplo = New Button()
        btn_p3_to_p7_diplo = New Button()
        btn_p3_to_p6_diplo = New Button()
        btn_p3_to_p5_diplo = New Button()
        btn_p3_to_p4_diplo = New Button()
        btn_p3_to_p2_diplo = New Button()
        btn_p3_to_p1_diplo = New Button()
        cbx_p2_av_me = New CheckBox()
        btn_p2_to_p8_diplo = New Button()
        btn_p2_to_p7_diplo = New Button()
        btn_p2_to_p6_diplo = New Button()
        btn_p2_to_p5_diplo = New Button()
        btn_p2_to_p4_diplo = New Button()
        cbx_p1_av_me = New CheckBox()
        btn_p2_to_p1_diplo = New Button()
        btn_p2_to_p3_diplo = New Button()
        btn_p1_to_p8_diplo = New Button()
        btn_p1_to_p7_diplo = New Button()
        btn_p1_to_p6_diplo = New Button()
        btn_p1_to_p5_diplo = New Button()
        btn_p1_to_p4_diplo = New Button()
        btn_p1_to_p3_diplo = New Button()
        lbl_allied_victory_them = New Label()
        lbl_p8_them = New Label()
        lbl_p7_them = New Label()
        lbl_p6_them = New Label()
        lbl_p5_them = New Label()
        lbl_p4_them = New Label()
        lbl_them = New Label()
        lbl_me = New Label()
        lbl_p3_them = New Label()
        lbl_p2_them = New Label()
        lbl_p1_them = New Label()
        lbl_allied_victory_me = New Label()
        lbl_p8_me = New Label()
        lbl_p7_me = New Label()
        lbl_p6_me = New Label()
        lbl_p5_me = New Label()
        lbl_p4_me = New Label()
        lbl_p3_me = New Label()
        lbl_p2_me = New Label()
        lbl_p1_me = New Label()
        lbl_middle = New Label()
        btn_p1_to_p2_diplo = New Button()
        tp_victory = New TabPage()
        tp_options = New TabPage()
        tp_messages = New TabPage()
        tp_cinematics = New TabPage()
        tp_triggers = New TabPage()
        tp_about = New TabPage()
        ofd_scenario = New OpenFileDialog()
        sfd_scenario = New SaveFileDialog()
        ofd_aoe2de_path = New OpenFileDialog()
        tbx_script_filename = New TextBox()
        tc_main.SuspendLayout()
        tp_file.SuspendLayout()
        tp_map.SuspendLayout()
        CType(nud_mwh_size, ComponentModel.ISupportInitialize).BeginInit()
        tp_players.SuspendLayout()
        CType(NumericUpDown7, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown6, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_priority_p1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_priority_gaia, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_population_gaia, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_population_p8, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_population_p7, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_population_p6, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_population_p5, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_population_p4, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_population_p3, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_population_p2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_population_p1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gold_gaia, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gold_p8, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gold_p7, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gold_p6, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gold_p5, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gold_p4, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gold_p3, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gold_p2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gold_p1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_stone_gaia, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_stone_p8, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_stone_p7, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_stone_p6, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_stone_p5, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_stone_p4, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_stone_p3, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_stone_p2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_stone_p1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_wood_gaia, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_wood_p8, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_wood_p7, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_wood_p6, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_wood_p5, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_wood_p4, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_wood_p3, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_wood_p2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_wood_p1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_food_gaia, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_food_p8, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_food_p7, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_food_p6, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_food_p5, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_food_p4, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_food_p3, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_food_p2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_food_p1, ComponentModel.ISupportInitialize).BeginInit()
        tp_units.SuspendLayout()
        tp_diplomacy.SuspendLayout()
        SuspendLayout()
        ' 
        ' tc_main
        ' 
        tc_main.Controls.Add(tp_file)
        tc_main.Controls.Add(tp_map)
        tc_main.Controls.Add(tp_terrain)
        tc_main.Controls.Add(tp_players)
        tc_main.Controls.Add(tp_units)
        tc_main.Controls.Add(tp_diplomacy)
        tc_main.Controls.Add(tp_victory)
        tc_main.Controls.Add(tp_options)
        tc_main.Controls.Add(tp_messages)
        tc_main.Controls.Add(tp_cinematics)
        tc_main.Controls.Add(tp_triggers)
        tc_main.Controls.Add(tp_about)
        tc_main.ImeMode = ImeMode.NoControl
        tc_main.Location = New Point(12, 12)
        tc_main.Name = "tc_main"
        tc_main.SelectedIndex = 0
        tc_main.Size = New Size(1160, 537)
        tc_main.TabIndex = 0
        ' 
        ' tp_file
        ' 
        tp_file.Controls.Add(btn_test)
        tp_file.Controls.Add(btn_new_scenario)
        tp_file.Controls.Add(lbl_save_path)
        tp_file.Controls.Add(lbl_load_path)
        tp_file.Controls.Add(btn_save)
        tp_file.Controls.Add(btn_load)
        tp_file.Location = New Point(4, 24)
        tp_file.Name = "tp_file"
        tp_file.Padding = New Padding(3)
        tp_file.Size = New Size(1152, 509)
        tp_file.TabIndex = 2
        tp_file.Text = "File"
        tp_file.UseVisualStyleBackColor = True
        ' 
        ' btn_test
        ' 
        btn_test.Location = New Point(8, 104)
        btn_test.Name = "btn_test"
        btn_test.Size = New Size(50, 25)
        btn_test.TabIndex = 5
        btn_test.Text = "Test"
        btn_test.UseVisualStyleBackColor = True
        ' 
        ' btn_new_scenario
        ' 
        btn_new_scenario.Location = New Point(8, 8)
        btn_new_scenario.Name = "btn_new_scenario"
        btn_new_scenario.Size = New Size(50, 25)
        btn_new_scenario.TabIndex = 4
        btn_new_scenario.Text = "New"
        btn_new_scenario.UseVisualStyleBackColor = True
        ' 
        ' lbl_save_path
        ' 
        lbl_save_path.AutoSize = True
        lbl_save_path.Location = New Point(64, 40)
        lbl_save_path.Name = "lbl_save_path"
        lbl_save_path.Size = New Size(12, 15)
        lbl_save_path.TabIndex = 3
        lbl_save_path.Text = "-"
        ' 
        ' lbl_load_path
        ' 
        lbl_load_path.AutoSize = True
        lbl_load_path.Location = New Point(64, 72)
        lbl_load_path.Name = "lbl_load_path"
        lbl_load_path.Size = New Size(12, 15)
        lbl_load_path.TabIndex = 2
        lbl_load_path.Text = "-"
        ' 
        ' btn_save
        ' 
        btn_save.Location = New Point(8, 40)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(50, 25)
        btn_save.TabIndex = 1
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' btn_load
        ' 
        btn_load.Location = New Point(8, 72)
        btn_load.Name = "btn_load"
        btn_load.Size = New Size(50, 25)
        btn_load.TabIndex = 0
        btn_load.Text = "Load"
        btn_load.UseVisualStyleBackColor = True
        ' 
        ' tp_map
        ' 
        tp_map.AutoScroll = True
        tp_map.Controls.Add(tbx_script_filename)
        tp_map.Controls.Add(cbx_map_size)
        tp_map.Controls.Add(nud_mwh_size)
        tp_map.Controls.Add(cbx_team_positions)
        tp_map.Controls.Add(cbx_default_terrain)
        tp_map.Controls.Add(cbx_color_mood)
        tp_map.Controls.Add(cbx_ai_map_type)
        tp_map.Location = New Point(4, 24)
        tp_map.Name = "tp_map"
        tp_map.Padding = New Padding(3)
        tp_map.Size = New Size(1152, 509)
        tp_map.TabIndex = 0
        tp_map.Text = "Map"
        tp_map.UseVisualStyleBackColor = True
        ' 
        ' cbx_map_size
        ' 
        cbx_map_size.FormattingEnabled = True
        cbx_map_size.Items.AddRange(New Object() {"Miniature (1 Player)", "Tiny (2 Players)", "Small (3 Players)", "Medium (4 Players)", "Normal (6 Players)", "Large (8 Players)", "Huge", "Giant", "Massive", "Enormous", "Colossal", "Incredible", "Monstrous", "Ludicrous", "Custom"})
        cbx_map_size.Location = New Point(8, 8)
        cbx_map_size.Name = "cbx_map_size"
        cbx_map_size.Size = New Size(152, 23)
        cbx_map_size.TabIndex = 6
        cbx_map_size.Text = "Map Size"
        ' 
        ' nud_mwh_size
        ' 
        nud_mwh_size.Enabled = False
        nud_mwh_size.Location = New Point(168, 8)
        nud_mwh_size.Maximum = New Decimal(New Integer() {480, 0, 0, 0})
        nud_mwh_size.Minimum = New Decimal(New Integer() {36, 0, 0, 0})
        nud_mwh_size.Name = "nud_mwh_size"
        nud_mwh_size.Size = New Size(43, 23)
        nud_mwh_size.TabIndex = 7
        nud_mwh_size.Value = New Decimal(New Integer() {480, 0, 0, 0})
        ' 
        ' cbx_team_positions
        ' 
        cbx_team_positions.AutoSize = True
        cbx_team_positions.Checked = True
        cbx_team_positions.CheckState = CheckState.Checked
        cbx_team_positions.Location = New Point(8, 136)
        cbx_team_positions.Name = "cbx_team_positions"
        cbx_team_positions.Size = New Size(105, 19)
        cbx_team_positions.TabIndex = 11
        cbx_team_positions.Text = "Team Positions"
        cbx_team_positions.UseVisualStyleBackColor = True
        ' 
        ' cbx_default_terrain
        ' 
        cbx_default_terrain.FormattingEnabled = True
        cbx_default_terrain.Items.AddRange(New Object() {"Beach", "Beach (Non-Navigable)", "Beach (Non-Navigable), Wet Gravel", "Beach (Non-Navigable), Wet Rock", "Beach (Non-Navigable), Wet Sand", "Beach, Ice", "Beach, Vegetation", "Beach, Wet", "Beach, Wet Gravel", "Beach, Wet Rock", "Beach, White", "Beach, White, Vegetation", "Black", "Desert, Cracked", "Desert, Quicksand", "Desert, Sand", "Dirt 1", "Dirt 2", "Dirt 3", "Dirt 4", "Dirt, Mud", "Dirt, Savannah", "Farm", "Farm, 0%", "Farm, 33%", "Farm, 67%", "Farm, Dead", "Forest, Acacia", "Forest, Autumn", "Forest, Autumn Snow", "Forest, Bamboo", "Forest, Baobab", "Forest, Birch", "Forest, Bush", "Forest, Dead", "Forest, Dragon Tree", "Forest, Jungle", "Forest, Mangrove", "Forest, Mediterranean", "Forest, Oak", "Forest, Oak Bush", "Forest, Palm Desert", "Forest, Palm Grass", "Forest, Pine", "Forest, Pine Snow", "Forest, Rainforest", "Forest, Reeds", "Forest, Reeds (Beach)", "Forest, Reeds (Shallows)", "Grass 1", "Grass 2", "Grass 3", "Grass, Dry", "Grass, Foundation", "Grass, Jungle", "Grass, Jungle (Rainforest)", "Grass, Other", "Gravel, Default", "Gravel, Desert", "Ice", "Ice, Navigable", "Rice Farm", "Rice Farm, 0%", "Rice Farm, 33%", "Rice Farm, 66%", "Rice Farm, Dead", "Road", "Road, Broken", "Road, Fungus", "Road, Gravel", "Rock 1", "Shallows", "Shallows, Azure", "Shallows, Mangrove", "Snow", "Snow, Foundation", "Snow, Light", "Snow, Strong", "Swamp, Bogland", "Swamp, Shallows", "Underbrush", "Underbrush, Jungle", "Underbrush, Leaves", "Underbrush, Snow", "Water 2D, Bridge", "Water 2D, Shoreless", "Water, Azure", "Water, Brown", "Water, Deep", "Water, Deep Ocean", "Water, Green", "Water, Medium", "Water, Shallow"})
        cbx_default_terrain.Location = New Point(8, 40)
        cbx_default_terrain.Name = "cbx_default_terrain"
        cbx_default_terrain.Size = New Size(243, 23)
        cbx_default_terrain.TabIndex = 8
        cbx_default_terrain.Text = "Default Terrain"
        ' 
        ' cbx_color_mood
        ' 
        cbx_color_mood.FormattingEnabled = True
        cbx_color_mood.Items.AddRange(New Object() {"Default", "Autumn", "Desert", "Jungle", "Winter", "Night"})
        cbx_color_mood.Location = New Point(8, 104)
        cbx_color_mood.Name = "cbx_color_mood"
        cbx_color_mood.Size = New Size(243, 23)
        cbx_color_mood.TabIndex = 10
        cbx_color_mood.Text = "Color Mood"
        ' 
        ' cbx_ai_map_type
        ' 
        cbx_ai_map_type.FormattingEnabled = True
        cbx_ai_map_type.Items.AddRange(New Object() {"Acclivity", "Acropolis", "African Clearing", "Aftermath", "Alpine Lakes", "Amazon Tunnel", "Arabia", "Archipelago", "Arena", "Atacama", "BR Battle On Ice", "BR El Dorado", "BR Fall of Axum", "BR Fall of Rome", "BR Majapahit Empire", "Baltic", "Black Forest", "Bog Islands", "Bogland", "Budapest", "Cenotes", "City of Lakes", "Coastal", "Coastal Forest", "Continental", "Crater", "Crater Lake", "Crossroads", "CtR Monsoon", "CtR Pyramid Descent", "CtR Random", "CtR Spiral", "Enclosed", "Eruption", "Fortress", "Four Lakes", "Frigid Lake", "Ghost Lake", "Gold Rush", "Golden Pit", "Golden Swamp", "Greenland", "Haboob", "Hamburger", "Hideout", "Highland", "Hill Fort", "Islands", "Kawasan", "Kilimanjaro", "Land Madness", "Land Nomad", "Lombardia", "Lowland", "Mangrove Jungle", "Marketplace", "Meadow", "Mediterranean", "MegaRandom", "Michi", "Migration", "Mongolia", "Morass", "Mountain Pass", "Mountain Range", "Mountain Ridge", "Nile Delta", "Nomad", "Northern Isles", "Oasis", "Pacific Islands", "Ravines", "Ring Fortress", "Rivers", "Runestones", "Sacred Springs", "Salt Marsh", "Sandbank", "Scandanavia", "Seize The Mountain", "Serengeti", "Shoals", "Socotra", "Steppe", "Team Islands", "Team Moats", "Valley", "Volcano Island", "Wade", "Water Nomad", "Wolf Hill", "Yucatan"})
        cbx_ai_map_type.Location = New Point(8, 72)
        cbx_ai_map_type.Name = "cbx_ai_map_type"
        cbx_ai_map_type.Size = New Size(243, 23)
        cbx_ai_map_type.TabIndex = 9
        cbx_ai_map_type.Text = "AI Map Type"
        ' 
        ' tp_terrain
        ' 
        tp_terrain.Location = New Point(4, 24)
        tp_terrain.Name = "tp_terrain"
        tp_terrain.Size = New Size(1152, 509)
        tp_terrain.TabIndex = 11
        tp_terrain.Text = "Terrain"
        tp_terrain.UseVisualStyleBackColor = True
        ' 
        ' tp_players
        ' 
        tp_players.Controls.Add(cbx_gaia_age)
        tp_players.Controls.Add(lbl_age)
        tp_players.Controls.Add(ComboBox6)
        tp_players.Controls.Add(ComboBox5)
        tp_players.Controls.Add(ComboBox4)
        tp_players.Controls.Add(ComboBox3)
        tp_players.Controls.Add(ComboBox2)
        tp_players.Controls.Add(ComboBox1)
        tp_players.Controls.Add(cbx_p2_age)
        tp_players.Controls.Add(cbx_p1_age)
        tp_players.Controls.Add(lbl_player_type)
        tp_players.Controls.Add(cbx_ai_p8)
        tp_players.Controls.Add(cbx_ai_p7)
        tp_players.Controls.Add(cbx_ai_p6)
        tp_players.Controls.Add(cbx_ai_p5)
        tp_players.Controls.Add(cbx_ai_p4)
        tp_players.Controls.Add(cbx_ai_p3)
        tp_players.Controls.Add(cbx_ai_p2)
        tp_players.Controls.Add(cbx_ai_p1)
        tp_players.Controls.Add(cbx_ai_gaia)
        tp_players.Controls.Add(lb_name_string_id)
        tp_players.Controls.Add(tbx_name_string_id_p8)
        tp_players.Controls.Add(tbx_name_string_id_p7)
        tp_players.Controls.Add(tbx_name_string_id_p6)
        tp_players.Controls.Add(tbx_name_string_id_p5)
        tp_players.Controls.Add(tbx_name_string_id_p4)
        tp_players.Controls.Add(tbx_name_string_id_p3)
        tp_players.Controls.Add(tbx_name_string_id_p2)
        tp_players.Controls.Add(tbx_name_string_id_p1)
        tp_players.Controls.Add(tbx_name_string_id_gaia)
        tp_players.Controls.Add(lb_tribe_name)
        tp_players.Controls.Add(tbx_tribe_name_p8)
        tp_players.Controls.Add(tbx_tribe_name_p7)
        tp_players.Controls.Add(tbx_tribe_name_p6)
        tp_players.Controls.Add(tbx_tribe_name_p5)
        tp_players.Controls.Add(tbx_tribe_name_p4)
        tp_players.Controls.Add(tbx_tribe_name_p3)
        tp_players.Controls.Add(tbx_tribe_name_p2)
        tp_players.Controls.Add(tbx_tribe_name_p1)
        tp_players.Controls.Add(tbx_tribe_name_gaia)
        tp_players.Controls.Add(cbx_color_p8)
        tp_players.Controls.Add(cbx_color_p7)
        tp_players.Controls.Add(cbx_color_p6)
        tp_players.Controls.Add(cbx_color_p5)
        tp_players.Controls.Add(cbx_color_p4)
        tp_players.Controls.Add(cbx_color_p3)
        tp_players.Controls.Add(cbx_color_p2)
        tp_players.Controls.Add(cbx_color_p1)
        tp_players.Controls.Add(lb_color)
        tp_players.Controls.Add(cbx_color_gaia)
        tp_players.Controls.Add(lb_player_8)
        tp_players.Controls.Add(lb_player_7)
        tp_players.Controls.Add(lb_player_6)
        tp_players.Controls.Add(lb_player_5)
        tp_players.Controls.Add(lb_player_4)
        tp_players.Controls.Add(lb_player_3)
        tp_players.Controls.Add(lb_player_2)
        tp_players.Controls.Add(lb_player_1)
        tp_players.Controls.Add(lb_gaia)
        tp_players.Controls.Add(NumericUpDown7)
        tp_players.Controls.Add(NumericUpDown6)
        tp_players.Controls.Add(NumericUpDown5)
        tp_players.Controls.Add(NumericUpDown4)
        tp_players.Controls.Add(NumericUpDown3)
        tp_players.Controls.Add(NumericUpDown2)
        tp_players.Controls.Add(NumericUpDown1)
        tp_players.Controls.Add(nud_priority_p1)
        tp_players.Controls.Add(nud_priority_gaia)
        tp_players.Controls.Add(lb_priority_gaia)
        tp_players.Controls.Add(nud_population_gaia)
        tp_players.Controls.Add(nud_population_p8)
        tp_players.Controls.Add(nud_population_p7)
        tp_players.Controls.Add(nud_population_p6)
        tp_players.Controls.Add(nud_population_p5)
        tp_players.Controls.Add(nud_population_p4)
        tp_players.Controls.Add(nud_population_p3)
        tp_players.Controls.Add(nud_population_p2)
        tp_players.Controls.Add(lb_pop)
        tp_players.Controls.Add(nud_population_p1)
        tp_players.Controls.Add(nud_gold_gaia)
        tp_players.Controls.Add(nud_gold_p8)
        tp_players.Controls.Add(nud_gold_p7)
        tp_players.Controls.Add(nud_gold_p6)
        tp_players.Controls.Add(nud_gold_p5)
        tp_players.Controls.Add(nud_gold_p4)
        tp_players.Controls.Add(nud_gold_p3)
        tp_players.Controls.Add(nud_gold_p2)
        tp_players.Controls.Add(lb_gold)
        tp_players.Controls.Add(nud_gold_p1)
        tp_players.Controls.Add(nud_stone_gaia)
        tp_players.Controls.Add(nud_stone_p8)
        tp_players.Controls.Add(nud_stone_p7)
        tp_players.Controls.Add(nud_stone_p6)
        tp_players.Controls.Add(nud_stone_p5)
        tp_players.Controls.Add(nud_stone_p4)
        tp_players.Controls.Add(nud_stone_p3)
        tp_players.Controls.Add(nud_stone_p2)
        tp_players.Controls.Add(lb_stone)
        tp_players.Controls.Add(nud_stone_p1)
        tp_players.Controls.Add(nud_wood_gaia)
        tp_players.Controls.Add(nud_wood_p8)
        tp_players.Controls.Add(nud_wood_p7)
        tp_players.Controls.Add(nud_wood_p6)
        tp_players.Controls.Add(nud_wood_p5)
        tp_players.Controls.Add(nud_wood_p4)
        tp_players.Controls.Add(nud_wood_p3)
        tp_players.Controls.Add(nud_wood_p2)
        tp_players.Controls.Add(lb_wood)
        tp_players.Controls.Add(nud_wood_p1)
        tp_players.Controls.Add(nud_food_gaia)
        tp_players.Controls.Add(nud_food_p8)
        tp_players.Controls.Add(nud_food_p7)
        tp_players.Controls.Add(nud_food_p6)
        tp_players.Controls.Add(nud_food_p5)
        tp_players.Controls.Add(nud_food_p4)
        tp_players.Controls.Add(nud_food_p3)
        tp_players.Controls.Add(nud_food_p2)
        tp_players.Controls.Add(lb_food)
        tp_players.Controls.Add(nud_food_p1)
        tp_players.Controls.Add(cbx_total_players)
        tp_players.Location = New Point(4, 24)
        tp_players.Name = "tp_players"
        tp_players.Padding = New Padding(3)
        tp_players.Size = New Size(1152, 509)
        tp_players.TabIndex = 1
        tp_players.Text = "Players"
        tp_players.UseVisualStyleBackColor = True
        ' 
        ' cbx_gaia_age
        ' 
        cbx_gaia_age.FormattingEnabled = True
        cbx_gaia_age.Location = New Point(136, 48)
        cbx_gaia_age.Name = "cbx_gaia_age"
        cbx_gaia_age.Size = New Size(100, 23)
        cbx_gaia_age.TabIndex = 224
        cbx_gaia_age.Text = "Starting Age"
        ' 
        ' lbl_age
        ' 
        lbl_age.AutoSize = True
        lbl_age.Location = New Point(136, 16)
        lbl_age.Name = "lbl_age"
        lbl_age.Size = New Size(72, 15)
        lbl_age.TabIndex = 223
        lbl_age.Text = "Starting Age"
        lbl_age.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(136, 304)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(100, 23)
        ComboBox6.TabIndex = 222
        ComboBox6.Text = "Starting Age"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(136, 272)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(100, 23)
        ComboBox5.TabIndex = 221
        ComboBox5.Text = "Starting Age"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(136, 240)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(100, 23)
        ComboBox4.TabIndex = 220
        ComboBox4.Text = "Starting Age"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(136, 208)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(100, 23)
        ComboBox3.TabIndex = 219
        ComboBox3.Text = "Starting Age"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(136, 176)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(100, 23)
        ComboBox2.TabIndex = 218
        ComboBox2.Text = "Starting Age"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(136, 144)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(100, 23)
        ComboBox1.TabIndex = 217
        ComboBox1.Text = "Starting Age"
        ' 
        ' cbx_p2_age
        ' 
        cbx_p2_age.FormattingEnabled = True
        cbx_p2_age.Location = New Point(136, 112)
        cbx_p2_age.Name = "cbx_p2_age"
        cbx_p2_age.Size = New Size(100, 23)
        cbx_p2_age.TabIndex = 216
        cbx_p2_age.Text = "Starting Age"
        ' 
        ' cbx_p1_age
        ' 
        cbx_p1_age.FormattingEnabled = True
        cbx_p1_age.Location = New Point(136, 80)
        cbx_p1_age.Name = "cbx_p1_age"
        cbx_p1_age.Size = New Size(100, 23)
        cbx_p1_age.TabIndex = 215
        cbx_p1_age.Text = "Starting Age"
        ' 
        ' lbl_player_type
        ' 
        lbl_player_type.AutoSize = True
        lbl_player_type.Location = New Point(888, 16)
        lbl_player_type.Name = "lbl_player_type"
        lbl_player_type.Size = New Size(41, 15)
        lbl_player_type.TabIndex = 214
        lbl_player_type.Text = "P Type"
        lbl_player_type.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbx_ai_p8
        ' 
        cbx_ai_p8.AutoSize = True
        cbx_ai_p8.Location = New Point(896, 304)
        cbx_ai_p8.Name = "cbx_ai_p8"
        cbx_ai_p8.Size = New Size(37, 19)
        cbx_ai_p8.TabIndex = 213
        cbx_ai_p8.Text = "AI"
        cbx_ai_p8.UseVisualStyleBackColor = True
        ' 
        ' cbx_ai_p7
        ' 
        cbx_ai_p7.AutoSize = True
        cbx_ai_p7.Location = New Point(896, 272)
        cbx_ai_p7.Name = "cbx_ai_p7"
        cbx_ai_p7.Size = New Size(37, 19)
        cbx_ai_p7.TabIndex = 212
        cbx_ai_p7.Text = "AI"
        cbx_ai_p7.UseVisualStyleBackColor = True
        ' 
        ' cbx_ai_p6
        ' 
        cbx_ai_p6.AutoSize = True
        cbx_ai_p6.Location = New Point(896, 240)
        cbx_ai_p6.Name = "cbx_ai_p6"
        cbx_ai_p6.Size = New Size(37, 19)
        cbx_ai_p6.TabIndex = 211
        cbx_ai_p6.Text = "AI"
        cbx_ai_p6.UseVisualStyleBackColor = True
        ' 
        ' cbx_ai_p5
        ' 
        cbx_ai_p5.AutoSize = True
        cbx_ai_p5.Location = New Point(896, 208)
        cbx_ai_p5.Name = "cbx_ai_p5"
        cbx_ai_p5.Size = New Size(37, 19)
        cbx_ai_p5.TabIndex = 210
        cbx_ai_p5.Text = "AI"
        cbx_ai_p5.UseVisualStyleBackColor = True
        ' 
        ' cbx_ai_p4
        ' 
        cbx_ai_p4.AutoSize = True
        cbx_ai_p4.Location = New Point(896, 176)
        cbx_ai_p4.Name = "cbx_ai_p4"
        cbx_ai_p4.Size = New Size(37, 19)
        cbx_ai_p4.TabIndex = 209
        cbx_ai_p4.Text = "AI"
        cbx_ai_p4.UseVisualStyleBackColor = True
        ' 
        ' cbx_ai_p3
        ' 
        cbx_ai_p3.AutoSize = True
        cbx_ai_p3.Location = New Point(896, 144)
        cbx_ai_p3.Name = "cbx_ai_p3"
        cbx_ai_p3.Size = New Size(37, 19)
        cbx_ai_p3.TabIndex = 208
        cbx_ai_p3.Text = "AI"
        cbx_ai_p3.UseVisualStyleBackColor = True
        ' 
        ' cbx_ai_p2
        ' 
        cbx_ai_p2.AutoSize = True
        cbx_ai_p2.Location = New Point(896, 112)
        cbx_ai_p2.Name = "cbx_ai_p2"
        cbx_ai_p2.Size = New Size(37, 19)
        cbx_ai_p2.TabIndex = 207
        cbx_ai_p2.Text = "AI"
        cbx_ai_p2.UseVisualStyleBackColor = True
        ' 
        ' cbx_ai_p1
        ' 
        cbx_ai_p1.AutoSize = True
        cbx_ai_p1.Location = New Point(896, 80)
        cbx_ai_p1.Name = "cbx_ai_p1"
        cbx_ai_p1.Size = New Size(37, 19)
        cbx_ai_p1.TabIndex = 206
        cbx_ai_p1.Text = "AI"
        cbx_ai_p1.UseVisualStyleBackColor = True
        ' 
        ' cbx_ai_gaia
        ' 
        cbx_ai_gaia.AutoSize = True
        cbx_ai_gaia.Location = New Point(896, 48)
        cbx_ai_gaia.Name = "cbx_ai_gaia"
        cbx_ai_gaia.Size = New Size(37, 19)
        cbx_ai_gaia.TabIndex = 205
        cbx_ai_gaia.Text = "AI"
        cbx_ai_gaia.UseVisualStyleBackColor = True
        ' 
        ' lb_name_string_id
        ' 
        lb_name_string_id.AutoSize = True
        lb_name_string_id.Location = New Point(792, 16)
        lb_name_string_id.Name = "lb_name_string_id"
        lb_name_string_id.Size = New Size(52, 15)
        lb_name_string_id.TabIndex = 204
        lb_name_string_id.Text = "String ID"
        lb_name_string_id.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbx_name_string_id_p8
        ' 
        tbx_name_string_id_p8.Location = New Point(792, 304)
        tbx_name_string_id_p8.MaxLength = 10
        tbx_name_string_id_p8.Name = "tbx_name_string_id_p8"
        tbx_name_string_id_p8.Size = New Size(100, 23)
        tbx_name_string_id_p8.TabIndex = 199
        ' 
        ' tbx_name_string_id_p7
        ' 
        tbx_name_string_id_p7.Location = New Point(792, 272)
        tbx_name_string_id_p7.MaxLength = 10
        tbx_name_string_id_p7.Name = "tbx_name_string_id_p7"
        tbx_name_string_id_p7.Size = New Size(100, 23)
        tbx_name_string_id_p7.TabIndex = 200
        ' 
        ' tbx_name_string_id_p6
        ' 
        tbx_name_string_id_p6.Location = New Point(792, 240)
        tbx_name_string_id_p6.MaxLength = 10
        tbx_name_string_id_p6.Name = "tbx_name_string_id_p6"
        tbx_name_string_id_p6.Size = New Size(100, 23)
        tbx_name_string_id_p6.TabIndex = 201
        ' 
        ' tbx_name_string_id_p5
        ' 
        tbx_name_string_id_p5.Location = New Point(792, 208)
        tbx_name_string_id_p5.MaxLength = 10
        tbx_name_string_id_p5.Name = "tbx_name_string_id_p5"
        tbx_name_string_id_p5.Size = New Size(100, 23)
        tbx_name_string_id_p5.TabIndex = 203
        ' 
        ' tbx_name_string_id_p4
        ' 
        tbx_name_string_id_p4.Location = New Point(792, 176)
        tbx_name_string_id_p4.MaxLength = 10
        tbx_name_string_id_p4.Name = "tbx_name_string_id_p4"
        tbx_name_string_id_p4.Size = New Size(100, 23)
        tbx_name_string_id_p4.TabIndex = 202
        ' 
        ' tbx_name_string_id_p3
        ' 
        tbx_name_string_id_p3.Location = New Point(792, 144)
        tbx_name_string_id_p3.MaxLength = 10
        tbx_name_string_id_p3.Name = "tbx_name_string_id_p3"
        tbx_name_string_id_p3.Size = New Size(100, 23)
        tbx_name_string_id_p3.TabIndex = 198
        ' 
        ' tbx_name_string_id_p2
        ' 
        tbx_name_string_id_p2.Location = New Point(792, 112)
        tbx_name_string_id_p2.MaxLength = 10
        tbx_name_string_id_p2.Name = "tbx_name_string_id_p2"
        tbx_name_string_id_p2.Size = New Size(100, 23)
        tbx_name_string_id_p2.TabIndex = 197
        ' 
        ' tbx_name_string_id_p1
        ' 
        tbx_name_string_id_p1.Location = New Point(792, 80)
        tbx_name_string_id_p1.MaxLength = 10
        tbx_name_string_id_p1.Name = "tbx_name_string_id_p1"
        tbx_name_string_id_p1.Size = New Size(100, 23)
        tbx_name_string_id_p1.TabIndex = 196
        ' 
        ' tbx_name_string_id_gaia
        ' 
        tbx_name_string_id_gaia.Location = New Point(792, 48)
        tbx_name_string_id_gaia.MaxLength = 10
        tbx_name_string_id_gaia.Name = "tbx_name_string_id_gaia"
        tbx_name_string_id_gaia.Size = New Size(100, 23)
        tbx_name_string_id_gaia.TabIndex = 195
        ' 
        ' lb_tribe_name
        ' 
        lb_tribe_name.AutoSize = True
        lb_tribe_name.Location = New Point(688, 16)
        lb_tribe_name.Name = "lb_tribe_name"
        lb_tribe_name.Size = New Size(67, 15)
        lb_tribe_name.TabIndex = 194
        lb_tribe_name.Text = "Tribe Name"
        lb_tribe_name.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbx_tribe_name_p8
        ' 
        tbx_tribe_name_p8.Location = New Point(688, 304)
        tbx_tribe_name_p8.MaxLength = 28
        tbx_tribe_name_p8.Name = "tbx_tribe_name_p8"
        tbx_tribe_name_p8.Size = New Size(100, 23)
        tbx_tribe_name_p8.TabIndex = 192
        ' 
        ' tbx_tribe_name_p7
        ' 
        tbx_tribe_name_p7.Location = New Point(688, 272)
        tbx_tribe_name_p7.MaxLength = 28
        tbx_tribe_name_p7.Name = "tbx_tribe_name_p7"
        tbx_tribe_name_p7.Size = New Size(100, 23)
        tbx_tribe_name_p7.TabIndex = 191
        ' 
        ' tbx_tribe_name_p6
        ' 
        tbx_tribe_name_p6.Location = New Point(688, 240)
        tbx_tribe_name_p6.MaxLength = 28
        tbx_tribe_name_p6.Name = "tbx_tribe_name_p6"
        tbx_tribe_name_p6.Size = New Size(100, 23)
        tbx_tribe_name_p6.TabIndex = 190
        ' 
        ' tbx_tribe_name_p5
        ' 
        tbx_tribe_name_p5.Location = New Point(688, 208)
        tbx_tribe_name_p5.MaxLength = 28
        tbx_tribe_name_p5.Name = "tbx_tribe_name_p5"
        tbx_tribe_name_p5.Size = New Size(100, 23)
        tbx_tribe_name_p5.TabIndex = 193
        ' 
        ' tbx_tribe_name_p4
        ' 
        tbx_tribe_name_p4.Location = New Point(688, 176)
        tbx_tribe_name_p4.MaxLength = 28
        tbx_tribe_name_p4.Name = "tbx_tribe_name_p4"
        tbx_tribe_name_p4.Size = New Size(100, 23)
        tbx_tribe_name_p4.TabIndex = 189
        ' 
        ' tbx_tribe_name_p3
        ' 
        tbx_tribe_name_p3.Location = New Point(688, 144)
        tbx_tribe_name_p3.MaxLength = 28
        tbx_tribe_name_p3.Name = "tbx_tribe_name_p3"
        tbx_tribe_name_p3.Size = New Size(100, 23)
        tbx_tribe_name_p3.TabIndex = 188
        ' 
        ' tbx_tribe_name_p2
        ' 
        tbx_tribe_name_p2.Location = New Point(688, 112)
        tbx_tribe_name_p2.MaxLength = 28
        tbx_tribe_name_p2.Name = "tbx_tribe_name_p2"
        tbx_tribe_name_p2.Size = New Size(100, 23)
        tbx_tribe_name_p2.TabIndex = 187
        ' 
        ' tbx_tribe_name_p1
        ' 
        tbx_tribe_name_p1.Location = New Point(688, 80)
        tbx_tribe_name_p1.MaxLength = 28
        tbx_tribe_name_p1.Name = "tbx_tribe_name_p1"
        tbx_tribe_name_p1.Size = New Size(100, 23)
        tbx_tribe_name_p1.TabIndex = 186
        ' 
        ' tbx_tribe_name_gaia
        ' 
        tbx_tribe_name_gaia.Location = New Point(688, 48)
        tbx_tribe_name_gaia.MaxLength = 28
        tbx_tribe_name_gaia.Name = "tbx_tribe_name_gaia"
        tbx_tribe_name_gaia.Size = New Size(100, 23)
        tbx_tribe_name_gaia.TabIndex = 185
        ' 
        ' cbx_color_p8
        ' 
        cbx_color_p8.FormattingEnabled = True
        cbx_color_p8.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_color_p8.Location = New Point(608, 304)
        cbx_color_p8.Name = "cbx_color_p8"
        cbx_color_p8.Size = New Size(75, 23)
        cbx_color_p8.TabIndex = 184
        cbx_color_p8.Text = "Color"
        ' 
        ' cbx_color_p7
        ' 
        cbx_color_p7.FormattingEnabled = True
        cbx_color_p7.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_color_p7.Location = New Point(608, 272)
        cbx_color_p7.Name = "cbx_color_p7"
        cbx_color_p7.Size = New Size(75, 23)
        cbx_color_p7.TabIndex = 183
        cbx_color_p7.Text = "Color"
        ' 
        ' cbx_color_p6
        ' 
        cbx_color_p6.FormattingEnabled = True
        cbx_color_p6.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_color_p6.Location = New Point(608, 240)
        cbx_color_p6.Name = "cbx_color_p6"
        cbx_color_p6.Size = New Size(75, 23)
        cbx_color_p6.TabIndex = 182
        cbx_color_p6.Text = "Color"
        ' 
        ' cbx_color_p5
        ' 
        cbx_color_p5.FormattingEnabled = True
        cbx_color_p5.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_color_p5.Location = New Point(608, 208)
        cbx_color_p5.Name = "cbx_color_p5"
        cbx_color_p5.Size = New Size(75, 23)
        cbx_color_p5.TabIndex = 181
        cbx_color_p5.Text = "Color"
        ' 
        ' cbx_color_p4
        ' 
        cbx_color_p4.FormattingEnabled = True
        cbx_color_p4.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_color_p4.Location = New Point(608, 176)
        cbx_color_p4.Name = "cbx_color_p4"
        cbx_color_p4.Size = New Size(75, 23)
        cbx_color_p4.TabIndex = 180
        cbx_color_p4.Text = "Color"
        ' 
        ' cbx_color_p3
        ' 
        cbx_color_p3.FormattingEnabled = True
        cbx_color_p3.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_color_p3.Location = New Point(608, 144)
        cbx_color_p3.Name = "cbx_color_p3"
        cbx_color_p3.Size = New Size(75, 23)
        cbx_color_p3.TabIndex = 179
        cbx_color_p3.Text = "Color"
        ' 
        ' cbx_color_p2
        ' 
        cbx_color_p2.FormattingEnabled = True
        cbx_color_p2.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_color_p2.Location = New Point(608, 112)
        cbx_color_p2.Name = "cbx_color_p2"
        cbx_color_p2.Size = New Size(75, 23)
        cbx_color_p2.TabIndex = 178
        cbx_color_p2.Text = "Color"
        ' 
        ' cbx_color_p1
        ' 
        cbx_color_p1.FormattingEnabled = True
        cbx_color_p1.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_color_p1.Location = New Point(608, 80)
        cbx_color_p1.Name = "cbx_color_p1"
        cbx_color_p1.Size = New Size(75, 23)
        cbx_color_p1.TabIndex = 177
        cbx_color_p1.Text = "Color"
        ' 
        ' lb_color
        ' 
        lb_color.AutoSize = True
        lb_color.Location = New Point(608, 16)
        lb_color.Name = "lb_color"
        lb_color.Size = New Size(36, 15)
        lb_color.TabIndex = 176
        lb_color.Text = "Color"
        lb_color.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbx_color_gaia
        ' 
        cbx_color_gaia.FormattingEnabled = True
        cbx_color_gaia.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_color_gaia.Location = New Point(608, 48)
        cbx_color_gaia.Name = "cbx_color_gaia"
        cbx_color_gaia.Size = New Size(75, 23)
        cbx_color_gaia.TabIndex = 175
        cbx_color_gaia.Text = "Color"
        ' 
        ' lb_player_8
        ' 
        lb_player_8.AutoSize = True
        lb_player_8.Location = New Point(8, 304)
        lb_player_8.Name = "lb_player_8"
        lb_player_8.Size = New Size(51, 15)
        lb_player_8.TabIndex = 174
        lb_player_8.Text = "Player 8:"
        lb_player_8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lb_player_7
        ' 
        lb_player_7.AutoSize = True
        lb_player_7.Location = New Point(8, 272)
        lb_player_7.Name = "lb_player_7"
        lb_player_7.Size = New Size(51, 15)
        lb_player_7.TabIndex = 173
        lb_player_7.Text = "Player 7:"
        lb_player_7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lb_player_6
        ' 
        lb_player_6.AutoSize = True
        lb_player_6.Location = New Point(8, 240)
        lb_player_6.Name = "lb_player_6"
        lb_player_6.Size = New Size(51, 15)
        lb_player_6.TabIndex = 172
        lb_player_6.Text = "Player 6:"
        lb_player_6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lb_player_5
        ' 
        lb_player_5.AutoSize = True
        lb_player_5.Location = New Point(8, 208)
        lb_player_5.Name = "lb_player_5"
        lb_player_5.Size = New Size(51, 15)
        lb_player_5.TabIndex = 171
        lb_player_5.Text = "Player 5:"
        lb_player_5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lb_player_4
        ' 
        lb_player_4.AutoSize = True
        lb_player_4.Location = New Point(8, 176)
        lb_player_4.Name = "lb_player_4"
        lb_player_4.Size = New Size(51, 15)
        lb_player_4.TabIndex = 170
        lb_player_4.Text = "Player 4:"
        lb_player_4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lb_player_3
        ' 
        lb_player_3.AutoSize = True
        lb_player_3.Location = New Point(8, 144)
        lb_player_3.Name = "lb_player_3"
        lb_player_3.Size = New Size(51, 15)
        lb_player_3.TabIndex = 169
        lb_player_3.Text = "Player 3:"
        lb_player_3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lb_player_2
        ' 
        lb_player_2.AutoSize = True
        lb_player_2.Location = New Point(8, 112)
        lb_player_2.Name = "lb_player_2"
        lb_player_2.Size = New Size(51, 15)
        lb_player_2.TabIndex = 168
        lb_player_2.Text = "Player 2:"
        lb_player_2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lb_player_1
        ' 
        lb_player_1.AutoSize = True
        lb_player_1.Location = New Point(8, 80)
        lb_player_1.Name = "lb_player_1"
        lb_player_1.Size = New Size(51, 15)
        lb_player_1.TabIndex = 167
        lb_player_1.Text = "Player 1:"
        lb_player_1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lb_gaia
        ' 
        lb_gaia.AutoSize = True
        lb_gaia.Location = New Point(8, 48)
        lb_gaia.Name = "lb_gaia"
        lb_gaia.Size = New Size(33, 15)
        lb_gaia.TabIndex = 166
        lb_gaia.Text = "Gaia:"
        lb_gaia.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' NumericUpDown7
        ' 
        NumericUpDown7.Location = New Point(568, 304)
        NumericUpDown7.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        NumericUpDown7.Name = "NumericUpDown7"
        NumericUpDown7.Size = New Size(32, 23)
        NumericUpDown7.TabIndex = 165
        NumericUpDown7.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' NumericUpDown6
        ' 
        NumericUpDown6.Location = New Point(568, 272)
        NumericUpDown6.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        NumericUpDown6.Name = "NumericUpDown6"
        NumericUpDown6.Size = New Size(32, 23)
        NumericUpDown6.TabIndex = 164
        NumericUpDown6.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' NumericUpDown5
        ' 
        NumericUpDown5.Location = New Point(568, 240)
        NumericUpDown5.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        NumericUpDown5.Name = "NumericUpDown5"
        NumericUpDown5.Size = New Size(32, 23)
        NumericUpDown5.TabIndex = 163
        NumericUpDown5.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' NumericUpDown4
        ' 
        NumericUpDown4.Location = New Point(568, 208)
        NumericUpDown4.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        NumericUpDown4.Name = "NumericUpDown4"
        NumericUpDown4.Size = New Size(32, 23)
        NumericUpDown4.TabIndex = 162
        NumericUpDown4.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Location = New Point(568, 176)
        NumericUpDown3.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(32, 23)
        NumericUpDown3.TabIndex = 161
        NumericUpDown3.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(568, 144)
        NumericUpDown2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(32, 23)
        NumericUpDown2.TabIndex = 160
        NumericUpDown2.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(568, 112)
        NumericUpDown1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(32, 23)
        NumericUpDown1.TabIndex = 159
        NumericUpDown1.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_priority_p1
        ' 
        nud_priority_p1.Location = New Point(568, 80)
        nud_priority_p1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_priority_p1.Name = "nud_priority_p1"
        nud_priority_p1.Size = New Size(32, 23)
        nud_priority_p1.TabIndex = 158
        nud_priority_p1.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_priority_gaia
        ' 
        nud_priority_gaia.Enabled = False
        nud_priority_gaia.Location = New Point(568, 48)
        nud_priority_gaia.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_priority_gaia.Name = "nud_priority_gaia"
        nud_priority_gaia.Size = New Size(32, 23)
        nud_priority_gaia.TabIndex = 157
        nud_priority_gaia.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' lb_priority_gaia
        ' 
        lb_priority_gaia.AutoSize = True
        lb_priority_gaia.Location = New Point(560, 16)
        lb_priority_gaia.Name = "lb_priority_gaia"
        lb_priority_gaia.Size = New Size(45, 15)
        lb_priority_gaia.TabIndex = 156
        lb_priority_gaia.Text = "Priority"
        lb_priority_gaia.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_population_gaia
        ' 
        nud_population_gaia.Location = New Point(504, 48)
        nud_population_gaia.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_population_gaia.Name = "nud_population_gaia"
        nud_population_gaia.Size = New Size(55, 23)
        nud_population_gaia.TabIndex = 155
        nud_population_gaia.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_population_p8
        ' 
        nud_population_p8.Location = New Point(504, 304)
        nud_population_p8.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_population_p8.Name = "nud_population_p8"
        nud_population_p8.Size = New Size(55, 23)
        nud_population_p8.TabIndex = 154
        nud_population_p8.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_population_p7
        ' 
        nud_population_p7.Location = New Point(504, 272)
        nud_population_p7.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_population_p7.Name = "nud_population_p7"
        nud_population_p7.Size = New Size(55, 23)
        nud_population_p7.TabIndex = 153
        nud_population_p7.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_population_p6
        ' 
        nud_population_p6.Location = New Point(504, 240)
        nud_population_p6.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_population_p6.Name = "nud_population_p6"
        nud_population_p6.Size = New Size(55, 23)
        nud_population_p6.TabIndex = 152
        nud_population_p6.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_population_p5
        ' 
        nud_population_p5.Location = New Point(504, 208)
        nud_population_p5.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_population_p5.Name = "nud_population_p5"
        nud_population_p5.Size = New Size(55, 23)
        nud_population_p5.TabIndex = 151
        nud_population_p5.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_population_p4
        ' 
        nud_population_p4.Location = New Point(504, 176)
        nud_population_p4.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_population_p4.Name = "nud_population_p4"
        nud_population_p4.Size = New Size(55, 23)
        nud_population_p4.TabIndex = 150
        nud_population_p4.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_population_p3
        ' 
        nud_population_p3.Location = New Point(504, 144)
        nud_population_p3.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_population_p3.Name = "nud_population_p3"
        nud_population_p3.Size = New Size(55, 23)
        nud_population_p3.TabIndex = 149
        nud_population_p3.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_population_p2
        ' 
        nud_population_p2.Location = New Point(504, 112)
        nud_population_p2.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_population_p2.Name = "nud_population_p2"
        nud_population_p2.Size = New Size(55, 23)
        nud_population_p2.TabIndex = 148
        nud_population_p2.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_pop
        ' 
        lb_pop.AutoSize = True
        lb_pop.Location = New Point(504, 16)
        lb_pop.Name = "lb_pop"
        lb_pop.Size = New Size(28, 15)
        lb_pop.TabIndex = 147
        lb_pop.Text = "Pop"
        lb_pop.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_population_p1
        ' 
        nud_population_p1.Location = New Point(504, 80)
        nud_population_p1.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_population_p1.Name = "nud_population_p1"
        nud_population_p1.Size = New Size(55, 23)
        nud_population_p1.TabIndex = 146
        nud_population_p1.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gold_gaia
        ' 
        nud_gold_gaia.Location = New Point(440, 48)
        nud_gold_gaia.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gold_gaia.Name = "nud_gold_gaia"
        nud_gold_gaia.Size = New Size(55, 23)
        nud_gold_gaia.TabIndex = 145
        nud_gold_gaia.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gold_p8
        ' 
        nud_gold_p8.Location = New Point(440, 304)
        nud_gold_p8.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gold_p8.Name = "nud_gold_p8"
        nud_gold_p8.Size = New Size(55, 23)
        nud_gold_p8.TabIndex = 144
        nud_gold_p8.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gold_p7
        ' 
        nud_gold_p7.Location = New Point(440, 272)
        nud_gold_p7.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gold_p7.Name = "nud_gold_p7"
        nud_gold_p7.Size = New Size(55, 23)
        nud_gold_p7.TabIndex = 143
        nud_gold_p7.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gold_p6
        ' 
        nud_gold_p6.Location = New Point(440, 240)
        nud_gold_p6.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gold_p6.Name = "nud_gold_p6"
        nud_gold_p6.Size = New Size(55, 23)
        nud_gold_p6.TabIndex = 142
        nud_gold_p6.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gold_p5
        ' 
        nud_gold_p5.Location = New Point(440, 208)
        nud_gold_p5.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gold_p5.Name = "nud_gold_p5"
        nud_gold_p5.Size = New Size(55, 23)
        nud_gold_p5.TabIndex = 141
        nud_gold_p5.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gold_p4
        ' 
        nud_gold_p4.Location = New Point(440, 176)
        nud_gold_p4.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gold_p4.Name = "nud_gold_p4"
        nud_gold_p4.Size = New Size(55, 23)
        nud_gold_p4.TabIndex = 140
        nud_gold_p4.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gold_p3
        ' 
        nud_gold_p3.Location = New Point(440, 144)
        nud_gold_p3.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gold_p3.Name = "nud_gold_p3"
        nud_gold_p3.Size = New Size(55, 23)
        nud_gold_p3.TabIndex = 139
        nud_gold_p3.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gold_p2
        ' 
        nud_gold_p2.Location = New Point(440, 112)
        nud_gold_p2.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gold_p2.Name = "nud_gold_p2"
        nud_gold_p2.Size = New Size(55, 23)
        nud_gold_p2.TabIndex = 138
        nud_gold_p2.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_gold
        ' 
        lb_gold.AutoSize = True
        lb_gold.Location = New Point(440, 16)
        lb_gold.Name = "lb_gold"
        lb_gold.Size = New Size(37, 15)
        lb_gold.TabIndex = 137
        lb_gold.Text = "Stone"
        lb_gold.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_gold_p1
        ' 
        nud_gold_p1.Location = New Point(440, 80)
        nud_gold_p1.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gold_p1.Name = "nud_gold_p1"
        nud_gold_p1.Size = New Size(55, 23)
        nud_gold_p1.TabIndex = 136
        nud_gold_p1.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_stone_gaia
        ' 
        nud_stone_gaia.Location = New Point(376, 48)
        nud_stone_gaia.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_stone_gaia.Name = "nud_stone_gaia"
        nud_stone_gaia.Size = New Size(55, 23)
        nud_stone_gaia.TabIndex = 135
        nud_stone_gaia.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_stone_p8
        ' 
        nud_stone_p8.Location = New Point(376, 304)
        nud_stone_p8.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_stone_p8.Name = "nud_stone_p8"
        nud_stone_p8.Size = New Size(55, 23)
        nud_stone_p8.TabIndex = 134
        nud_stone_p8.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_stone_p7
        ' 
        nud_stone_p7.Location = New Point(376, 272)
        nud_stone_p7.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_stone_p7.Name = "nud_stone_p7"
        nud_stone_p7.Size = New Size(55, 23)
        nud_stone_p7.TabIndex = 133
        nud_stone_p7.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_stone_p6
        ' 
        nud_stone_p6.Location = New Point(376, 240)
        nud_stone_p6.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_stone_p6.Name = "nud_stone_p6"
        nud_stone_p6.Size = New Size(55, 23)
        nud_stone_p6.TabIndex = 132
        nud_stone_p6.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_stone_p5
        ' 
        nud_stone_p5.Location = New Point(376, 208)
        nud_stone_p5.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_stone_p5.Name = "nud_stone_p5"
        nud_stone_p5.Size = New Size(55, 23)
        nud_stone_p5.TabIndex = 131
        nud_stone_p5.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_stone_p4
        ' 
        nud_stone_p4.Location = New Point(376, 176)
        nud_stone_p4.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_stone_p4.Name = "nud_stone_p4"
        nud_stone_p4.Size = New Size(55, 23)
        nud_stone_p4.TabIndex = 130
        nud_stone_p4.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_stone_p3
        ' 
        nud_stone_p3.Location = New Point(376, 144)
        nud_stone_p3.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_stone_p3.Name = "nud_stone_p3"
        nud_stone_p3.Size = New Size(55, 23)
        nud_stone_p3.TabIndex = 129
        nud_stone_p3.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_stone_p2
        ' 
        nud_stone_p2.Location = New Point(376, 112)
        nud_stone_p2.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_stone_p2.Name = "nud_stone_p2"
        nud_stone_p2.Size = New Size(55, 23)
        nud_stone_p2.TabIndex = 128
        nud_stone_p2.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_stone
        ' 
        lb_stone.AutoSize = True
        lb_stone.Location = New Point(376, 16)
        lb_stone.Name = "lb_stone"
        lb_stone.Size = New Size(37, 15)
        lb_stone.TabIndex = 127
        lb_stone.Text = "Stone"
        lb_stone.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_stone_p1
        ' 
        nud_stone_p1.Location = New Point(376, 80)
        nud_stone_p1.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_stone_p1.Name = "nud_stone_p1"
        nud_stone_p1.Size = New Size(55, 23)
        nud_stone_p1.TabIndex = 126
        nud_stone_p1.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_wood_gaia
        ' 
        nud_wood_gaia.Location = New Point(312, 48)
        nud_wood_gaia.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_wood_gaia.Name = "nud_wood_gaia"
        nud_wood_gaia.Size = New Size(55, 23)
        nud_wood_gaia.TabIndex = 125
        nud_wood_gaia.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_wood_p8
        ' 
        nud_wood_p8.Location = New Point(312, 304)
        nud_wood_p8.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_wood_p8.Name = "nud_wood_p8"
        nud_wood_p8.Size = New Size(55, 23)
        nud_wood_p8.TabIndex = 124
        nud_wood_p8.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_wood_p7
        ' 
        nud_wood_p7.Location = New Point(312, 272)
        nud_wood_p7.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_wood_p7.Name = "nud_wood_p7"
        nud_wood_p7.Size = New Size(55, 23)
        nud_wood_p7.TabIndex = 123
        nud_wood_p7.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_wood_p6
        ' 
        nud_wood_p6.Location = New Point(312, 240)
        nud_wood_p6.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_wood_p6.Name = "nud_wood_p6"
        nud_wood_p6.Size = New Size(55, 23)
        nud_wood_p6.TabIndex = 122
        nud_wood_p6.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_wood_p5
        ' 
        nud_wood_p5.Location = New Point(312, 208)
        nud_wood_p5.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_wood_p5.Name = "nud_wood_p5"
        nud_wood_p5.Size = New Size(55, 23)
        nud_wood_p5.TabIndex = 121
        nud_wood_p5.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_wood_p4
        ' 
        nud_wood_p4.Location = New Point(312, 176)
        nud_wood_p4.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_wood_p4.Name = "nud_wood_p4"
        nud_wood_p4.Size = New Size(55, 23)
        nud_wood_p4.TabIndex = 120
        nud_wood_p4.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_wood_p3
        ' 
        nud_wood_p3.Location = New Point(312, 144)
        nud_wood_p3.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_wood_p3.Name = "nud_wood_p3"
        nud_wood_p3.Size = New Size(55, 23)
        nud_wood_p3.TabIndex = 119
        nud_wood_p3.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_wood_p2
        ' 
        nud_wood_p2.Location = New Point(312, 112)
        nud_wood_p2.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_wood_p2.Name = "nud_wood_p2"
        nud_wood_p2.Size = New Size(55, 23)
        nud_wood_p2.TabIndex = 118
        nud_wood_p2.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_wood
        ' 
        lb_wood.AutoSize = True
        lb_wood.Location = New Point(312, 16)
        lb_wood.Name = "lb_wood"
        lb_wood.Size = New Size(39, 15)
        lb_wood.TabIndex = 117
        lb_wood.Text = "Wood"
        lb_wood.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_wood_p1
        ' 
        nud_wood_p1.Location = New Point(312, 80)
        nud_wood_p1.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_wood_p1.Name = "nud_wood_p1"
        nud_wood_p1.Size = New Size(55, 23)
        nud_wood_p1.TabIndex = 116
        nud_wood_p1.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_food_gaia
        ' 
        nud_food_gaia.Location = New Point(248, 48)
        nud_food_gaia.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_food_gaia.Name = "nud_food_gaia"
        nud_food_gaia.Size = New Size(55, 23)
        nud_food_gaia.TabIndex = 115
        nud_food_gaia.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_food_p8
        ' 
        nud_food_p8.Location = New Point(248, 304)
        nud_food_p8.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_food_p8.Name = "nud_food_p8"
        nud_food_p8.Size = New Size(55, 23)
        nud_food_p8.TabIndex = 114
        nud_food_p8.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_food_p7
        ' 
        nud_food_p7.Location = New Point(248, 272)
        nud_food_p7.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_food_p7.Name = "nud_food_p7"
        nud_food_p7.Size = New Size(55, 23)
        nud_food_p7.TabIndex = 113
        nud_food_p7.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_food_p6
        ' 
        nud_food_p6.Location = New Point(248, 240)
        nud_food_p6.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_food_p6.Name = "nud_food_p6"
        nud_food_p6.Size = New Size(55, 23)
        nud_food_p6.TabIndex = 112
        nud_food_p6.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_food_p5
        ' 
        nud_food_p5.Location = New Point(248, 208)
        nud_food_p5.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_food_p5.Name = "nud_food_p5"
        nud_food_p5.Size = New Size(55, 23)
        nud_food_p5.TabIndex = 111
        nud_food_p5.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_food_p4
        ' 
        nud_food_p4.Location = New Point(248, 176)
        nud_food_p4.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_food_p4.Name = "nud_food_p4"
        nud_food_p4.Size = New Size(55, 23)
        nud_food_p4.TabIndex = 110
        nud_food_p4.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_food_p3
        ' 
        nud_food_p3.Location = New Point(248, 144)
        nud_food_p3.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_food_p3.Name = "nud_food_p3"
        nud_food_p3.Size = New Size(55, 23)
        nud_food_p3.TabIndex = 109
        nud_food_p3.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_food_p2
        ' 
        nud_food_p2.Location = New Point(248, 112)
        nud_food_p2.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_food_p2.Name = "nud_food_p2"
        nud_food_p2.Size = New Size(55, 23)
        nud_food_p2.TabIndex = 108
        nud_food_p2.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_food
        ' 
        lb_food.AutoSize = True
        lb_food.Location = New Point(248, 16)
        lb_food.Name = "lb_food"
        lb_food.Size = New Size(34, 15)
        lb_food.TabIndex = 107
        lb_food.Text = "Food"
        lb_food.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_food_p1
        ' 
        nud_food_p1.Location = New Point(248, 80)
        nud_food_p1.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_food_p1.Name = "nud_food_p1"
        nud_food_p1.Size = New Size(55, 23)
        nud_food_p1.TabIndex = 106
        nud_food_p1.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' cbx_total_players
        ' 
        cbx_total_players.FormattingEnabled = True
        cbx_total_players.Items.AddRange(New Object() {"1 Player", "2 Players", "3 Players", "4 Players", "5 Players", "6 Players", "7 Players", "8 Players"})
        cbx_total_players.Location = New Point(8, 16)
        cbx_total_players.Name = "cbx_total_players"
        cbx_total_players.Size = New Size(88, 23)
        cbx_total_players.TabIndex = 105
        cbx_total_players.Text = "Total Players"
        ' 
        ' tp_units
        ' 
        tp_units.Controls.Add(cbx_unit_player)
        tp_units.Controls.Add(btn_remove_unit)
        tp_units.Controls.Add(btn_create_unit)
        tp_units.Controls.Add(lbx_map_xy)
        tp_units.Controls.Add(lbx_units)
        tp_units.Location = New Point(4, 24)
        tp_units.Name = "tp_units"
        tp_units.Padding = New Padding(3)
        tp_units.Size = New Size(1152, 509)
        tp_units.TabIndex = 3
        tp_units.Text = "Units"
        tp_units.UseVisualStyleBackColor = True
        ' 
        ' cbx_unit_player
        ' 
        cbx_unit_player.FormattingEnabled = True
        cbx_unit_player.Items.AddRange(New Object() {"Gaia", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6", "Player 7", "Player 8"})
        cbx_unit_player.Location = New Point(488, 64)
        cbx_unit_player.Name = "cbx_unit_player"
        cbx_unit_player.Size = New Size(121, 23)
        cbx_unit_player.TabIndex = 4
        cbx_unit_player.Text = "Player"
        ' 
        ' btn_remove_unit
        ' 
        btn_remove_unit.Location = New Point(488, 35)
        btn_remove_unit.Name = "btn_remove_unit"
        btn_remove_unit.Size = New Size(75, 23)
        btn_remove_unit.TabIndex = 3
        btn_remove_unit.Text = "Remove Unit"
        btn_remove_unit.UseVisualStyleBackColor = True
        ' 
        ' btn_create_unit
        ' 
        btn_create_unit.Location = New Point(488, 6)
        btn_create_unit.Name = "btn_create_unit"
        btn_create_unit.Size = New Size(75, 23)
        btn_create_unit.TabIndex = 2
        btn_create_unit.Text = "Create"
        btn_create_unit.UseVisualStyleBackColor = True
        ' 
        ' lbx_map_xy
        ' 
        lbx_map_xy.FormattingEnabled = True
        lbx_map_xy.ItemHeight = 15
        lbx_map_xy.Location = New Point(247, 6)
        lbx_map_xy.Name = "lbx_map_xy"
        lbx_map_xy.Size = New Size(235, 439)
        lbx_map_xy.TabIndex = 1
        ' 
        ' lbx_units
        ' 
        lbx_units.FormattingEnabled = True
        lbx_units.ItemHeight = 15
        lbx_units.Location = New Point(6, 6)
        lbx_units.Name = "lbx_units"
        lbx_units.Size = New Size(235, 439)
        lbx_units.TabIndex = 0
        ' 
        ' tp_diplomacy
        ' 
        tp_diplomacy.Controls.Add(cbx_random_starting_points)
        tp_diplomacy.Controls.Add(cbx_choose_teams)
        tp_diplomacy.Controls.Add(cbx_lock_teams)
        tp_diplomacy.Controls.Add(cbx_max_teams)
        tp_diplomacy.Controls.Add(cbx_p8_av_them)
        tp_diplomacy.Controls.Add(cbx_p7_av_them)
        tp_diplomacy.Controls.Add(cbx_p6_av_them)
        tp_diplomacy.Controls.Add(cbx_p5_av_them)
        tp_diplomacy.Controls.Add(cbx_p4_av_them)
        tp_diplomacy.Controls.Add(cbx_p3_av_them)
        tp_diplomacy.Controls.Add(cbx_p2_av_them)
        tp_diplomacy.Controls.Add(cbx_p1_av_them)
        tp_diplomacy.Controls.Add(cbx_p8_av_me)
        tp_diplomacy.Controls.Add(cbx_p7_av_me)
        tp_diplomacy.Controls.Add(cbx_p6_av_me)
        tp_diplomacy.Controls.Add(btn_p8_to_p7_diplo)
        tp_diplomacy.Controls.Add(btn_p8_to_p6_diplo)
        tp_diplomacy.Controls.Add(btn_p8_to_p5_diplo)
        tp_diplomacy.Controls.Add(btn_p8_to_p4_diplo)
        tp_diplomacy.Controls.Add(btn_p8_to_p3_diplo)
        tp_diplomacy.Controls.Add(btn_p8_to_p2_diplo)
        tp_diplomacy.Controls.Add(btn_p8_to_p1_diplo)
        tp_diplomacy.Controls.Add(btn_p7_to_p8_diplo)
        tp_diplomacy.Controls.Add(btn_p7_to_p6_diplo)
        tp_diplomacy.Controls.Add(btn_p7_to_p5_diplo)
        tp_diplomacy.Controls.Add(btn_p7_to_p4_diplo)
        tp_diplomacy.Controls.Add(btn_p7_to_p3_diplo)
        tp_diplomacy.Controls.Add(btn_p7_to_p2_diplo)
        tp_diplomacy.Controls.Add(btn_p7_to_p1_diplo)
        tp_diplomacy.Controls.Add(btn_p6_to_p8_diplo)
        tp_diplomacy.Controls.Add(btn_p6_to_p7_diplo)
        tp_diplomacy.Controls.Add(btn_p6_to_p5_diplo)
        tp_diplomacy.Controls.Add(btn_p6_to_p4_diplo)
        tp_diplomacy.Controls.Add(btn_p6_to_p3_diplo)
        tp_diplomacy.Controls.Add(btn_p6_to_p2_diplo)
        tp_diplomacy.Controls.Add(btn_p6_to_p1_diplo)
        tp_diplomacy.Controls.Add(cbx_p5_av_me)
        tp_diplomacy.Controls.Add(btn_p5_to_p8_diplo)
        tp_diplomacy.Controls.Add(btn_p5_to_p7_diplo)
        tp_diplomacy.Controls.Add(btn_p5_to_p6_diplo)
        tp_diplomacy.Controls.Add(btn_p5_to_p4_diplo)
        tp_diplomacy.Controls.Add(btn_p5_to_p3_diplo)
        tp_diplomacy.Controls.Add(btn_p5_to_p2_diplo)
        tp_diplomacy.Controls.Add(btn_p5_to_p1_diplo)
        tp_diplomacy.Controls.Add(cbx_p4_av_me)
        tp_diplomacy.Controls.Add(btn_p4_to_p8_diplo)
        tp_diplomacy.Controls.Add(btn_p4_to_p7_diplo)
        tp_diplomacy.Controls.Add(btn_p4_to_p6_diplo)
        tp_diplomacy.Controls.Add(btn_p4_to_p5_diplo)
        tp_diplomacy.Controls.Add(btn_p4_to_p3_diplo)
        tp_diplomacy.Controls.Add(btn_p4_to_p2_diplo)
        tp_diplomacy.Controls.Add(btn_p4_to_p1_diplo)
        tp_diplomacy.Controls.Add(cbx_p3_av_me)
        tp_diplomacy.Controls.Add(btn_p3_to_p8_diplo)
        tp_diplomacy.Controls.Add(btn_p3_to_p7_diplo)
        tp_diplomacy.Controls.Add(btn_p3_to_p6_diplo)
        tp_diplomacy.Controls.Add(btn_p3_to_p5_diplo)
        tp_diplomacy.Controls.Add(btn_p3_to_p4_diplo)
        tp_diplomacy.Controls.Add(btn_p3_to_p2_diplo)
        tp_diplomacy.Controls.Add(btn_p3_to_p1_diplo)
        tp_diplomacy.Controls.Add(cbx_p2_av_me)
        tp_diplomacy.Controls.Add(btn_p2_to_p8_diplo)
        tp_diplomacy.Controls.Add(btn_p2_to_p7_diplo)
        tp_diplomacy.Controls.Add(btn_p2_to_p6_diplo)
        tp_diplomacy.Controls.Add(btn_p2_to_p5_diplo)
        tp_diplomacy.Controls.Add(btn_p2_to_p4_diplo)
        tp_diplomacy.Controls.Add(cbx_p1_av_me)
        tp_diplomacy.Controls.Add(btn_p2_to_p1_diplo)
        tp_diplomacy.Controls.Add(btn_p2_to_p3_diplo)
        tp_diplomacy.Controls.Add(btn_p1_to_p8_diplo)
        tp_diplomacy.Controls.Add(btn_p1_to_p7_diplo)
        tp_diplomacy.Controls.Add(btn_p1_to_p6_diplo)
        tp_diplomacy.Controls.Add(btn_p1_to_p5_diplo)
        tp_diplomacy.Controls.Add(btn_p1_to_p4_diplo)
        tp_diplomacy.Controls.Add(btn_p1_to_p3_diplo)
        tp_diplomacy.Controls.Add(lbl_allied_victory_them)
        tp_diplomacy.Controls.Add(lbl_p8_them)
        tp_diplomacy.Controls.Add(lbl_p7_them)
        tp_diplomacy.Controls.Add(lbl_p6_them)
        tp_diplomacy.Controls.Add(lbl_p5_them)
        tp_diplomacy.Controls.Add(lbl_p4_them)
        tp_diplomacy.Controls.Add(lbl_them)
        tp_diplomacy.Controls.Add(lbl_me)
        tp_diplomacy.Controls.Add(lbl_p3_them)
        tp_diplomacy.Controls.Add(lbl_p2_them)
        tp_diplomacy.Controls.Add(lbl_p1_them)
        tp_diplomacy.Controls.Add(lbl_allied_victory_me)
        tp_diplomacy.Controls.Add(lbl_p8_me)
        tp_diplomacy.Controls.Add(lbl_p7_me)
        tp_diplomacy.Controls.Add(lbl_p6_me)
        tp_diplomacy.Controls.Add(lbl_p5_me)
        tp_diplomacy.Controls.Add(lbl_p4_me)
        tp_diplomacy.Controls.Add(lbl_p3_me)
        tp_diplomacy.Controls.Add(lbl_p2_me)
        tp_diplomacy.Controls.Add(lbl_p1_me)
        tp_diplomacy.Controls.Add(lbl_middle)
        tp_diplomacy.Controls.Add(btn_p1_to_p2_diplo)
        tp_diplomacy.Location = New Point(4, 24)
        tp_diplomacy.Name = "tp_diplomacy"
        tp_diplomacy.Padding = New Padding(3)
        tp_diplomacy.Size = New Size(1152, 509)
        tp_diplomacy.TabIndex = 4
        tp_diplomacy.Text = "Diplomacy"
        tp_diplomacy.UseVisualStyleBackColor = True
        ' 
        ' cbx_random_starting_points
        ' 
        cbx_random_starting_points.AutoSize = True
        cbx_random_starting_points.Location = New Point(776, 93)
        cbx_random_starting_points.Name = "cbx_random_starting_points"
        cbx_random_starting_points.Size = New Size(151, 19)
        cbx_random_starting_points.TabIndex = 99
        cbx_random_starting_points.Text = "Random Starting Points"
        cbx_random_starting_points.UseVisualStyleBackColor = True
        ' 
        ' cbx_choose_teams
        ' 
        cbx_choose_teams.AutoSize = True
        cbx_choose_teams.Location = New Point(776, 68)
        cbx_choose_teams.Name = "cbx_choose_teams"
        cbx_choose_teams.Size = New Size(102, 19)
        cbx_choose_teams.TabIndex = 98
        cbx_choose_teams.Text = "Choose Teams"
        cbx_choose_teams.UseVisualStyleBackColor = True
        ' 
        ' cbx_lock_teams
        ' 
        cbx_lock_teams.AutoSize = True
        cbx_lock_teams.Location = New Point(776, 45)
        cbx_lock_teams.Name = "cbx_lock_teams"
        cbx_lock_teams.Size = New Size(87, 19)
        cbx_lock_teams.TabIndex = 97
        cbx_lock_teams.Text = "Lock Teams"
        cbx_lock_teams.UseVisualStyleBackColor = True
        ' 
        ' cbx_max_teams
        ' 
        cbx_max_teams.FormattingEnabled = True
        cbx_max_teams.Items.AddRange(New Object() {"2 Teams", "3 Teams", "4 Teams"})
        cbx_max_teams.Location = New Point(649, 43)
        cbx_max_teams.Name = "cbx_max_teams"
        cbx_max_teams.Size = New Size(121, 23)
        cbx_max_teams.TabIndex = 96
        cbx_max_teams.Text = "Max Teams"
        ' 
        ' cbx_p8_av_them
        ' 
        cbx_p8_av_them.AutoSize = True
        cbx_p8_av_them.Location = New Point(537, 289)
        cbx_p8_av_them.Name = "cbx_p8_av_them"
        cbx_p8_av_them.Size = New Size(40, 19)
        cbx_p8_av_them.TabIndex = 95
        cbx_p8_av_them.Text = "AV"
        cbx_p8_av_them.UseVisualStyleBackColor = True
        ' 
        ' cbx_p7_av_them
        ' 
        cbx_p7_av_them.AutoSize = True
        cbx_p7_av_them.Location = New Point(471, 289)
        cbx_p7_av_them.Name = "cbx_p7_av_them"
        cbx_p7_av_them.Size = New Size(40, 19)
        cbx_p7_av_them.TabIndex = 94
        cbx_p7_av_them.Text = "AV"
        cbx_p7_av_them.UseVisualStyleBackColor = True
        ' 
        ' cbx_p6_av_them
        ' 
        cbx_p6_av_them.AutoSize = True
        cbx_p6_av_them.Location = New Point(405, 289)
        cbx_p6_av_them.Name = "cbx_p6_av_them"
        cbx_p6_av_them.Size = New Size(40, 19)
        cbx_p6_av_them.TabIndex = 93
        cbx_p6_av_them.Text = "AV"
        cbx_p6_av_them.UseVisualStyleBackColor = True
        ' 
        ' cbx_p5_av_them
        ' 
        cbx_p5_av_them.AutoSize = True
        cbx_p5_av_them.Location = New Point(339, 289)
        cbx_p5_av_them.Name = "cbx_p5_av_them"
        cbx_p5_av_them.Size = New Size(40, 19)
        cbx_p5_av_them.TabIndex = 92
        cbx_p5_av_them.Text = "AV"
        cbx_p5_av_them.UseVisualStyleBackColor = True
        ' 
        ' cbx_p4_av_them
        ' 
        cbx_p4_av_them.AutoSize = True
        cbx_p4_av_them.Location = New Point(273, 289)
        cbx_p4_av_them.Name = "cbx_p4_av_them"
        cbx_p4_av_them.Size = New Size(40, 19)
        cbx_p4_av_them.TabIndex = 91
        cbx_p4_av_them.Text = "AV"
        cbx_p4_av_them.UseVisualStyleBackColor = True
        ' 
        ' cbx_p3_av_them
        ' 
        cbx_p3_av_them.AutoSize = True
        cbx_p3_av_them.Location = New Point(207, 289)
        cbx_p3_av_them.Name = "cbx_p3_av_them"
        cbx_p3_av_them.Size = New Size(40, 19)
        cbx_p3_av_them.TabIndex = 90
        cbx_p3_av_them.Text = "AV"
        cbx_p3_av_them.UseVisualStyleBackColor = True
        ' 
        ' cbx_p2_av_them
        ' 
        cbx_p2_av_them.AutoSize = True
        cbx_p2_av_them.Location = New Point(141, 289)
        cbx_p2_av_them.Name = "cbx_p2_av_them"
        cbx_p2_av_them.Size = New Size(40, 19)
        cbx_p2_av_them.TabIndex = 89
        cbx_p2_av_them.Text = "AV"
        cbx_p2_av_them.UseVisualStyleBackColor = True
        ' 
        ' cbx_p1_av_them
        ' 
        cbx_p1_av_them.AutoSize = True
        cbx_p1_av_them.Location = New Point(75, 289)
        cbx_p1_av_them.Name = "cbx_p1_av_them"
        cbx_p1_av_them.Size = New Size(40, 19)
        cbx_p1_av_them.TabIndex = 88
        cbx_p1_av_them.Text = "AV"
        cbx_p1_av_them.UseVisualStyleBackColor = True
        ' 
        ' cbx_p8_av_me
        ' 
        cbx_p8_av_me.AutoSize = True
        cbx_p8_av_me.Location = New Point(603, 258)
        cbx_p8_av_me.Name = "cbx_p8_av_me"
        cbx_p8_av_me.Size = New Size(40, 19)
        cbx_p8_av_me.TabIndex = 87
        cbx_p8_av_me.Text = "AV"
        cbx_p8_av_me.UseVisualStyleBackColor = True
        ' 
        ' cbx_p7_av_me
        ' 
        cbx_p7_av_me.AutoSize = True
        cbx_p7_av_me.Location = New Point(603, 227)
        cbx_p7_av_me.Name = "cbx_p7_av_me"
        cbx_p7_av_me.Size = New Size(40, 19)
        cbx_p7_av_me.TabIndex = 85
        cbx_p7_av_me.Text = "AV"
        cbx_p7_av_me.UseVisualStyleBackColor = True
        ' 
        ' cbx_p6_av_me
        ' 
        cbx_p6_av_me.AutoSize = True
        cbx_p6_av_me.Location = New Point(603, 196)
        cbx_p6_av_me.Name = "cbx_p6_av_me"
        cbx_p6_av_me.Size = New Size(40, 19)
        cbx_p6_av_me.TabIndex = 84
        cbx_p6_av_me.Text = "AV"
        cbx_p6_av_me.UseVisualStyleBackColor = True
        ' 
        ' btn_p8_to_p7_diplo
        ' 
        btn_p8_to_p7_diplo.Location = New Point(471, 258)
        btn_p8_to_p7_diplo.Name = "btn_p8_to_p7_diplo"
        btn_p8_to_p7_diplo.Size = New Size(60, 25)
        btn_p8_to_p7_diplo.TabIndex = 83
        btn_p8_to_p7_diplo.Text = "Enemy"
        btn_p8_to_p7_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p8_to_p6_diplo
        ' 
        btn_p8_to_p6_diplo.Location = New Point(405, 258)
        btn_p8_to_p6_diplo.Name = "btn_p8_to_p6_diplo"
        btn_p8_to_p6_diplo.Size = New Size(60, 25)
        btn_p8_to_p6_diplo.TabIndex = 82
        btn_p8_to_p6_diplo.Text = "Enemy"
        btn_p8_to_p6_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p8_to_p5_diplo
        ' 
        btn_p8_to_p5_diplo.Location = New Point(339, 258)
        btn_p8_to_p5_diplo.Name = "btn_p8_to_p5_diplo"
        btn_p8_to_p5_diplo.Size = New Size(60, 25)
        btn_p8_to_p5_diplo.TabIndex = 81
        btn_p8_to_p5_diplo.Text = "Enemy"
        btn_p8_to_p5_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p8_to_p4_diplo
        ' 
        btn_p8_to_p4_diplo.Location = New Point(273, 258)
        btn_p8_to_p4_diplo.Name = "btn_p8_to_p4_diplo"
        btn_p8_to_p4_diplo.Size = New Size(60, 25)
        btn_p8_to_p4_diplo.TabIndex = 80
        btn_p8_to_p4_diplo.Text = "Enemy"
        btn_p8_to_p4_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p8_to_p3_diplo
        ' 
        btn_p8_to_p3_diplo.Location = New Point(207, 258)
        btn_p8_to_p3_diplo.Name = "btn_p8_to_p3_diplo"
        btn_p8_to_p3_diplo.Size = New Size(60, 25)
        btn_p8_to_p3_diplo.TabIndex = 79
        btn_p8_to_p3_diplo.Text = "Enemy"
        btn_p8_to_p3_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p8_to_p2_diplo
        ' 
        btn_p8_to_p2_diplo.Location = New Point(141, 258)
        btn_p8_to_p2_diplo.Name = "btn_p8_to_p2_diplo"
        btn_p8_to_p2_diplo.Size = New Size(60, 25)
        btn_p8_to_p2_diplo.TabIndex = 78
        btn_p8_to_p2_diplo.Text = "Enemy"
        btn_p8_to_p2_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p8_to_p1_diplo
        ' 
        btn_p8_to_p1_diplo.Location = New Point(75, 258)
        btn_p8_to_p1_diplo.Name = "btn_p8_to_p1_diplo"
        btn_p8_to_p1_diplo.Size = New Size(60, 25)
        btn_p8_to_p1_diplo.TabIndex = 77
        btn_p8_to_p1_diplo.Text = "Enemy"
        btn_p8_to_p1_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p7_to_p8_diplo
        ' 
        btn_p7_to_p8_diplo.Location = New Point(537, 227)
        btn_p7_to_p8_diplo.Name = "btn_p7_to_p8_diplo"
        btn_p7_to_p8_diplo.Size = New Size(60, 25)
        btn_p7_to_p8_diplo.TabIndex = 76
        btn_p7_to_p8_diplo.Text = "Enemy"
        btn_p7_to_p8_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p7_to_p6_diplo
        ' 
        btn_p7_to_p6_diplo.Location = New Point(405, 227)
        btn_p7_to_p6_diplo.Name = "btn_p7_to_p6_diplo"
        btn_p7_to_p6_diplo.Size = New Size(60, 25)
        btn_p7_to_p6_diplo.TabIndex = 75
        btn_p7_to_p6_diplo.Text = "Enemy"
        btn_p7_to_p6_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p7_to_p5_diplo
        ' 
        btn_p7_to_p5_diplo.Location = New Point(339, 227)
        btn_p7_to_p5_diplo.Name = "btn_p7_to_p5_diplo"
        btn_p7_to_p5_diplo.Size = New Size(60, 25)
        btn_p7_to_p5_diplo.TabIndex = 74
        btn_p7_to_p5_diplo.Text = "Enemy"
        btn_p7_to_p5_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p7_to_p4_diplo
        ' 
        btn_p7_to_p4_diplo.Location = New Point(273, 227)
        btn_p7_to_p4_diplo.Name = "btn_p7_to_p4_diplo"
        btn_p7_to_p4_diplo.Size = New Size(60, 25)
        btn_p7_to_p4_diplo.TabIndex = 73
        btn_p7_to_p4_diplo.Text = "Enemy"
        btn_p7_to_p4_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p7_to_p3_diplo
        ' 
        btn_p7_to_p3_diplo.Location = New Point(207, 227)
        btn_p7_to_p3_diplo.Name = "btn_p7_to_p3_diplo"
        btn_p7_to_p3_diplo.Size = New Size(60, 25)
        btn_p7_to_p3_diplo.TabIndex = 72
        btn_p7_to_p3_diplo.Text = "Enemy"
        btn_p7_to_p3_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p7_to_p2_diplo
        ' 
        btn_p7_to_p2_diplo.Location = New Point(141, 227)
        btn_p7_to_p2_diplo.Name = "btn_p7_to_p2_diplo"
        btn_p7_to_p2_diplo.Size = New Size(60, 25)
        btn_p7_to_p2_diplo.TabIndex = 71
        btn_p7_to_p2_diplo.Text = "Enemy"
        btn_p7_to_p2_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p7_to_p1_diplo
        ' 
        btn_p7_to_p1_diplo.Location = New Point(75, 227)
        btn_p7_to_p1_diplo.Name = "btn_p7_to_p1_diplo"
        btn_p7_to_p1_diplo.Size = New Size(60, 25)
        btn_p7_to_p1_diplo.TabIndex = 70
        btn_p7_to_p1_diplo.Text = "Enemy"
        btn_p7_to_p1_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p6_to_p8_diplo
        ' 
        btn_p6_to_p8_diplo.Location = New Point(537, 196)
        btn_p6_to_p8_diplo.Name = "btn_p6_to_p8_diplo"
        btn_p6_to_p8_diplo.Size = New Size(60, 25)
        btn_p6_to_p8_diplo.TabIndex = 69
        btn_p6_to_p8_diplo.Text = "Enemy"
        btn_p6_to_p8_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p6_to_p7_diplo
        ' 
        btn_p6_to_p7_diplo.Location = New Point(471, 196)
        btn_p6_to_p7_diplo.Name = "btn_p6_to_p7_diplo"
        btn_p6_to_p7_diplo.Size = New Size(60, 25)
        btn_p6_to_p7_diplo.TabIndex = 68
        btn_p6_to_p7_diplo.Text = "Enemy"
        btn_p6_to_p7_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p6_to_p5_diplo
        ' 
        btn_p6_to_p5_diplo.Location = New Point(339, 196)
        btn_p6_to_p5_diplo.Name = "btn_p6_to_p5_diplo"
        btn_p6_to_p5_diplo.Size = New Size(60, 25)
        btn_p6_to_p5_diplo.TabIndex = 67
        btn_p6_to_p5_diplo.Text = "Enemy"
        btn_p6_to_p5_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p6_to_p4_diplo
        ' 
        btn_p6_to_p4_diplo.Location = New Point(273, 196)
        btn_p6_to_p4_diplo.Name = "btn_p6_to_p4_diplo"
        btn_p6_to_p4_diplo.Size = New Size(60, 25)
        btn_p6_to_p4_diplo.TabIndex = 66
        btn_p6_to_p4_diplo.Text = "Enemy"
        btn_p6_to_p4_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p6_to_p3_diplo
        ' 
        btn_p6_to_p3_diplo.Location = New Point(207, 196)
        btn_p6_to_p3_diplo.Name = "btn_p6_to_p3_diplo"
        btn_p6_to_p3_diplo.Size = New Size(60, 25)
        btn_p6_to_p3_diplo.TabIndex = 65
        btn_p6_to_p3_diplo.Text = "Enemy"
        btn_p6_to_p3_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p6_to_p2_diplo
        ' 
        btn_p6_to_p2_diplo.Location = New Point(141, 196)
        btn_p6_to_p2_diplo.Name = "btn_p6_to_p2_diplo"
        btn_p6_to_p2_diplo.Size = New Size(60, 25)
        btn_p6_to_p2_diplo.TabIndex = 64
        btn_p6_to_p2_diplo.Text = "Enemy"
        btn_p6_to_p2_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p6_to_p1_diplo
        ' 
        btn_p6_to_p1_diplo.Location = New Point(75, 196)
        btn_p6_to_p1_diplo.Name = "btn_p6_to_p1_diplo"
        btn_p6_to_p1_diplo.Size = New Size(60, 25)
        btn_p6_to_p1_diplo.TabIndex = 63
        btn_p6_to_p1_diplo.Text = "Enemy"
        btn_p6_to_p1_diplo.UseVisualStyleBackColor = True
        ' 
        ' cbx_p5_av_me
        ' 
        cbx_p5_av_me.AutoSize = True
        cbx_p5_av_me.Location = New Point(603, 165)
        cbx_p5_av_me.Name = "cbx_p5_av_me"
        cbx_p5_av_me.Size = New Size(40, 19)
        cbx_p5_av_me.TabIndex = 62
        cbx_p5_av_me.Text = "AV"
        cbx_p5_av_me.UseVisualStyleBackColor = True
        ' 
        ' btn_p5_to_p8_diplo
        ' 
        btn_p5_to_p8_diplo.Location = New Point(537, 165)
        btn_p5_to_p8_diplo.Name = "btn_p5_to_p8_diplo"
        btn_p5_to_p8_diplo.Size = New Size(60, 25)
        btn_p5_to_p8_diplo.TabIndex = 61
        btn_p5_to_p8_diplo.Text = "Enemy"
        btn_p5_to_p8_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p5_to_p7_diplo
        ' 
        btn_p5_to_p7_diplo.Location = New Point(471, 165)
        btn_p5_to_p7_diplo.Name = "btn_p5_to_p7_diplo"
        btn_p5_to_p7_diplo.Size = New Size(60, 25)
        btn_p5_to_p7_diplo.TabIndex = 60
        btn_p5_to_p7_diplo.Text = "Enemy"
        btn_p5_to_p7_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p5_to_p6_diplo
        ' 
        btn_p5_to_p6_diplo.Location = New Point(405, 165)
        btn_p5_to_p6_diplo.Name = "btn_p5_to_p6_diplo"
        btn_p5_to_p6_diplo.Size = New Size(60, 25)
        btn_p5_to_p6_diplo.TabIndex = 59
        btn_p5_to_p6_diplo.Text = "Enemy"
        btn_p5_to_p6_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p5_to_p4_diplo
        ' 
        btn_p5_to_p4_diplo.Location = New Point(273, 165)
        btn_p5_to_p4_diplo.Name = "btn_p5_to_p4_diplo"
        btn_p5_to_p4_diplo.Size = New Size(60, 25)
        btn_p5_to_p4_diplo.TabIndex = 58
        btn_p5_to_p4_diplo.Text = "Enemy"
        btn_p5_to_p4_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p5_to_p3_diplo
        ' 
        btn_p5_to_p3_diplo.Location = New Point(207, 165)
        btn_p5_to_p3_diplo.Name = "btn_p5_to_p3_diplo"
        btn_p5_to_p3_diplo.Size = New Size(60, 25)
        btn_p5_to_p3_diplo.TabIndex = 57
        btn_p5_to_p3_diplo.Text = "Enemy"
        btn_p5_to_p3_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p5_to_p2_diplo
        ' 
        btn_p5_to_p2_diplo.Location = New Point(141, 165)
        btn_p5_to_p2_diplo.Name = "btn_p5_to_p2_diplo"
        btn_p5_to_p2_diplo.Size = New Size(60, 25)
        btn_p5_to_p2_diplo.TabIndex = 56
        btn_p5_to_p2_diplo.Text = "Enemy"
        btn_p5_to_p2_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p5_to_p1_diplo
        ' 
        btn_p5_to_p1_diplo.Location = New Point(75, 165)
        btn_p5_to_p1_diplo.Name = "btn_p5_to_p1_diplo"
        btn_p5_to_p1_diplo.Size = New Size(60, 25)
        btn_p5_to_p1_diplo.TabIndex = 55
        btn_p5_to_p1_diplo.Text = "Enemy"
        btn_p5_to_p1_diplo.UseVisualStyleBackColor = True
        ' 
        ' cbx_p4_av_me
        ' 
        cbx_p4_av_me.AutoSize = True
        cbx_p4_av_me.Location = New Point(603, 134)
        cbx_p4_av_me.Name = "cbx_p4_av_me"
        cbx_p4_av_me.Size = New Size(40, 19)
        cbx_p4_av_me.TabIndex = 54
        cbx_p4_av_me.Text = "AV"
        cbx_p4_av_me.UseVisualStyleBackColor = True
        ' 
        ' btn_p4_to_p8_diplo
        ' 
        btn_p4_to_p8_diplo.Location = New Point(537, 134)
        btn_p4_to_p8_diplo.Name = "btn_p4_to_p8_diplo"
        btn_p4_to_p8_diplo.Size = New Size(60, 25)
        btn_p4_to_p8_diplo.TabIndex = 53
        btn_p4_to_p8_diplo.Text = "Enemy"
        btn_p4_to_p8_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p4_to_p7_diplo
        ' 
        btn_p4_to_p7_diplo.Location = New Point(471, 134)
        btn_p4_to_p7_diplo.Name = "btn_p4_to_p7_diplo"
        btn_p4_to_p7_diplo.Size = New Size(60, 25)
        btn_p4_to_p7_diplo.TabIndex = 52
        btn_p4_to_p7_diplo.Text = "Enemy"
        btn_p4_to_p7_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p4_to_p6_diplo
        ' 
        btn_p4_to_p6_diplo.Location = New Point(405, 134)
        btn_p4_to_p6_diplo.Name = "btn_p4_to_p6_diplo"
        btn_p4_to_p6_diplo.Size = New Size(60, 25)
        btn_p4_to_p6_diplo.TabIndex = 51
        btn_p4_to_p6_diplo.Text = "Enemy"
        btn_p4_to_p6_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p4_to_p5_diplo
        ' 
        btn_p4_to_p5_diplo.Location = New Point(339, 134)
        btn_p4_to_p5_diplo.Name = "btn_p4_to_p5_diplo"
        btn_p4_to_p5_diplo.Size = New Size(60, 25)
        btn_p4_to_p5_diplo.TabIndex = 50
        btn_p4_to_p5_diplo.Text = "Enemy"
        btn_p4_to_p5_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p4_to_p3_diplo
        ' 
        btn_p4_to_p3_diplo.Location = New Point(207, 134)
        btn_p4_to_p3_diplo.Name = "btn_p4_to_p3_diplo"
        btn_p4_to_p3_diplo.Size = New Size(60, 25)
        btn_p4_to_p3_diplo.TabIndex = 49
        btn_p4_to_p3_diplo.Text = "Enemy"
        btn_p4_to_p3_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p4_to_p2_diplo
        ' 
        btn_p4_to_p2_diplo.Location = New Point(141, 134)
        btn_p4_to_p2_diplo.Name = "btn_p4_to_p2_diplo"
        btn_p4_to_p2_diplo.Size = New Size(60, 25)
        btn_p4_to_p2_diplo.TabIndex = 48
        btn_p4_to_p2_diplo.Text = "Enemy"
        btn_p4_to_p2_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p4_to_p1_diplo
        ' 
        btn_p4_to_p1_diplo.Location = New Point(75, 134)
        btn_p4_to_p1_diplo.Name = "btn_p4_to_p1_diplo"
        btn_p4_to_p1_diplo.Size = New Size(60, 25)
        btn_p4_to_p1_diplo.TabIndex = 47
        btn_p4_to_p1_diplo.Text = "Enemy"
        btn_p4_to_p1_diplo.UseVisualStyleBackColor = True
        ' 
        ' cbx_p3_av_me
        ' 
        cbx_p3_av_me.AutoSize = True
        cbx_p3_av_me.Location = New Point(603, 103)
        cbx_p3_av_me.Name = "cbx_p3_av_me"
        cbx_p3_av_me.Size = New Size(40, 19)
        cbx_p3_av_me.TabIndex = 46
        cbx_p3_av_me.Text = "AV"
        cbx_p3_av_me.UseVisualStyleBackColor = True
        ' 
        ' btn_p3_to_p8_diplo
        ' 
        btn_p3_to_p8_diplo.Location = New Point(537, 103)
        btn_p3_to_p8_diplo.Name = "btn_p3_to_p8_diplo"
        btn_p3_to_p8_diplo.Size = New Size(60, 25)
        btn_p3_to_p8_diplo.TabIndex = 45
        btn_p3_to_p8_diplo.Text = "Enemy"
        btn_p3_to_p8_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p3_to_p7_diplo
        ' 
        btn_p3_to_p7_diplo.Location = New Point(471, 103)
        btn_p3_to_p7_diplo.Name = "btn_p3_to_p7_diplo"
        btn_p3_to_p7_diplo.Size = New Size(60, 25)
        btn_p3_to_p7_diplo.TabIndex = 44
        btn_p3_to_p7_diplo.Text = "Enemy"
        btn_p3_to_p7_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p3_to_p6_diplo
        ' 
        btn_p3_to_p6_diplo.Location = New Point(405, 103)
        btn_p3_to_p6_diplo.Name = "btn_p3_to_p6_diplo"
        btn_p3_to_p6_diplo.Size = New Size(60, 25)
        btn_p3_to_p6_diplo.TabIndex = 43
        btn_p3_to_p6_diplo.Text = "Enemy"
        btn_p3_to_p6_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p3_to_p5_diplo
        ' 
        btn_p3_to_p5_diplo.Location = New Point(339, 103)
        btn_p3_to_p5_diplo.Name = "btn_p3_to_p5_diplo"
        btn_p3_to_p5_diplo.Size = New Size(60, 25)
        btn_p3_to_p5_diplo.TabIndex = 42
        btn_p3_to_p5_diplo.Text = "Enemy"
        btn_p3_to_p5_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p3_to_p4_diplo
        ' 
        btn_p3_to_p4_diplo.Location = New Point(273, 103)
        btn_p3_to_p4_diplo.Name = "btn_p3_to_p4_diplo"
        btn_p3_to_p4_diplo.Size = New Size(60, 25)
        btn_p3_to_p4_diplo.TabIndex = 41
        btn_p3_to_p4_diplo.Text = "Enemy"
        btn_p3_to_p4_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p3_to_p2_diplo
        ' 
        btn_p3_to_p2_diplo.Location = New Point(141, 103)
        btn_p3_to_p2_diplo.Name = "btn_p3_to_p2_diplo"
        btn_p3_to_p2_diplo.Size = New Size(60, 25)
        btn_p3_to_p2_diplo.TabIndex = 40
        btn_p3_to_p2_diplo.Text = "Enemy"
        btn_p3_to_p2_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p3_to_p1_diplo
        ' 
        btn_p3_to_p1_diplo.Location = New Point(75, 103)
        btn_p3_to_p1_diplo.Name = "btn_p3_to_p1_diplo"
        btn_p3_to_p1_diplo.Size = New Size(60, 25)
        btn_p3_to_p1_diplo.TabIndex = 39
        btn_p3_to_p1_diplo.Text = "Enemy"
        btn_p3_to_p1_diplo.UseVisualStyleBackColor = True
        ' 
        ' cbx_p2_av_me
        ' 
        cbx_p2_av_me.AutoSize = True
        cbx_p2_av_me.Location = New Point(603, 72)
        cbx_p2_av_me.Name = "cbx_p2_av_me"
        cbx_p2_av_me.Size = New Size(40, 19)
        cbx_p2_av_me.TabIndex = 38
        cbx_p2_av_me.Text = "AV"
        cbx_p2_av_me.UseVisualStyleBackColor = True
        ' 
        ' btn_p2_to_p8_diplo
        ' 
        btn_p2_to_p8_diplo.Location = New Point(537, 72)
        btn_p2_to_p8_diplo.Name = "btn_p2_to_p8_diplo"
        btn_p2_to_p8_diplo.Size = New Size(60, 25)
        btn_p2_to_p8_diplo.TabIndex = 37
        btn_p2_to_p8_diplo.Text = "Enemy"
        btn_p2_to_p8_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p2_to_p7_diplo
        ' 
        btn_p2_to_p7_diplo.Location = New Point(471, 72)
        btn_p2_to_p7_diplo.Name = "btn_p2_to_p7_diplo"
        btn_p2_to_p7_diplo.Size = New Size(60, 25)
        btn_p2_to_p7_diplo.TabIndex = 36
        btn_p2_to_p7_diplo.Text = "Enemy"
        btn_p2_to_p7_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p2_to_p6_diplo
        ' 
        btn_p2_to_p6_diplo.Location = New Point(405, 72)
        btn_p2_to_p6_diplo.Name = "btn_p2_to_p6_diplo"
        btn_p2_to_p6_diplo.Size = New Size(60, 25)
        btn_p2_to_p6_diplo.TabIndex = 35
        btn_p2_to_p6_diplo.Text = "Enemy"
        btn_p2_to_p6_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p2_to_p5_diplo
        ' 
        btn_p2_to_p5_diplo.Location = New Point(339, 72)
        btn_p2_to_p5_diplo.Name = "btn_p2_to_p5_diplo"
        btn_p2_to_p5_diplo.Size = New Size(60, 25)
        btn_p2_to_p5_diplo.TabIndex = 34
        btn_p2_to_p5_diplo.Text = "Enemy"
        btn_p2_to_p5_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p2_to_p4_diplo
        ' 
        btn_p2_to_p4_diplo.Location = New Point(273, 72)
        btn_p2_to_p4_diplo.Name = "btn_p2_to_p4_diplo"
        btn_p2_to_p4_diplo.Size = New Size(60, 25)
        btn_p2_to_p4_diplo.TabIndex = 33
        btn_p2_to_p4_diplo.Text = "Enemy"
        btn_p2_to_p4_diplo.UseVisualStyleBackColor = True
        ' 
        ' cbx_p1_av_me
        ' 
        cbx_p1_av_me.AutoSize = True
        cbx_p1_av_me.Location = New Point(603, 41)
        cbx_p1_av_me.Name = "cbx_p1_av_me"
        cbx_p1_av_me.Size = New Size(40, 19)
        cbx_p1_av_me.TabIndex = 32
        cbx_p1_av_me.Text = "AV"
        cbx_p1_av_me.UseVisualStyleBackColor = True
        ' 
        ' btn_p2_to_p1_diplo
        ' 
        btn_p2_to_p1_diplo.Location = New Point(75, 72)
        btn_p2_to_p1_diplo.Name = "btn_p2_to_p1_diplo"
        btn_p2_to_p1_diplo.Size = New Size(60, 25)
        btn_p2_to_p1_diplo.TabIndex = 31
        btn_p2_to_p1_diplo.Text = "Enemy"
        btn_p2_to_p1_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p2_to_p3_diplo
        ' 
        btn_p2_to_p3_diplo.Location = New Point(207, 72)
        btn_p2_to_p3_diplo.Name = "btn_p2_to_p3_diplo"
        btn_p2_to_p3_diplo.Size = New Size(60, 25)
        btn_p2_to_p3_diplo.TabIndex = 30
        btn_p2_to_p3_diplo.Text = "Enemy"
        btn_p2_to_p3_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p1_to_p8_diplo
        ' 
        btn_p1_to_p8_diplo.Location = New Point(537, 41)
        btn_p1_to_p8_diplo.Name = "btn_p1_to_p8_diplo"
        btn_p1_to_p8_diplo.Size = New Size(60, 25)
        btn_p1_to_p8_diplo.TabIndex = 29
        btn_p1_to_p8_diplo.Text = "Enemy"
        btn_p1_to_p8_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p1_to_p7_diplo
        ' 
        btn_p1_to_p7_diplo.Location = New Point(471, 41)
        btn_p1_to_p7_diplo.Name = "btn_p1_to_p7_diplo"
        btn_p1_to_p7_diplo.Size = New Size(60, 25)
        btn_p1_to_p7_diplo.TabIndex = 28
        btn_p1_to_p7_diplo.Text = "Enemy"
        btn_p1_to_p7_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p1_to_p6_diplo
        ' 
        btn_p1_to_p6_diplo.Location = New Point(405, 41)
        btn_p1_to_p6_diplo.Name = "btn_p1_to_p6_diplo"
        btn_p1_to_p6_diplo.Size = New Size(60, 25)
        btn_p1_to_p6_diplo.TabIndex = 27
        btn_p1_to_p6_diplo.Text = "Enemy"
        btn_p1_to_p6_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p1_to_p5_diplo
        ' 
        btn_p1_to_p5_diplo.Location = New Point(339, 41)
        btn_p1_to_p5_diplo.Name = "btn_p1_to_p5_diplo"
        btn_p1_to_p5_diplo.Size = New Size(60, 25)
        btn_p1_to_p5_diplo.TabIndex = 26
        btn_p1_to_p5_diplo.Text = "Enemy"
        btn_p1_to_p5_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p1_to_p4_diplo
        ' 
        btn_p1_to_p4_diplo.Location = New Point(273, 41)
        btn_p1_to_p4_diplo.Name = "btn_p1_to_p4_diplo"
        btn_p1_to_p4_diplo.Size = New Size(60, 25)
        btn_p1_to_p4_diplo.TabIndex = 25
        btn_p1_to_p4_diplo.Text = "Enemy"
        btn_p1_to_p4_diplo.UseVisualStyleBackColor = True
        ' 
        ' btn_p1_to_p3_diplo
        ' 
        btn_p1_to_p3_diplo.Location = New Point(207, 41)
        btn_p1_to_p3_diplo.Name = "btn_p1_to_p3_diplo"
        btn_p1_to_p3_diplo.Size = New Size(60, 25)
        btn_p1_to_p3_diplo.TabIndex = 24
        btn_p1_to_p3_diplo.Text = "Enemy"
        btn_p1_to_p3_diplo.UseVisualStyleBackColor = True
        ' 
        ' lbl_allied_victory_them
        ' 
        lbl_allied_victory_them.AutoSize = True
        lbl_allied_victory_them.Location = New Point(603, 23)
        lbl_allied_victory_them.Name = "lbl_allied_victory_them"
        lbl_allied_victory_them.Size = New Size(21, 15)
        lbl_allied_victory_them.TabIndex = 21
        lbl_allied_victory_them.Text = "AV"
        ' 
        ' lbl_p8_them
        ' 
        lbl_p8_them.AutoSize = True
        lbl_p8_them.Location = New Point(537, 23)
        lbl_p8_them.Name = "lbl_p8_them"
        lbl_p8_them.Size = New Size(20, 15)
        lbl_p8_them.TabIndex = 20
        lbl_p8_them.Text = "P8"
        ' 
        ' lbl_p7_them
        ' 
        lbl_p7_them.AutoSize = True
        lbl_p7_them.Location = New Point(471, 23)
        lbl_p7_them.Name = "lbl_p7_them"
        lbl_p7_them.Size = New Size(20, 15)
        lbl_p7_them.TabIndex = 19
        lbl_p7_them.Text = "P7"
        ' 
        ' lbl_p6_them
        ' 
        lbl_p6_them.AutoSize = True
        lbl_p6_them.Location = New Point(405, 23)
        lbl_p6_them.Name = "lbl_p6_them"
        lbl_p6_them.Size = New Size(20, 15)
        lbl_p6_them.TabIndex = 18
        lbl_p6_them.Text = "P6"
        ' 
        ' lbl_p5_them
        ' 
        lbl_p5_them.AutoSize = True
        lbl_p5_them.Location = New Point(339, 23)
        lbl_p5_them.Name = "lbl_p5_them"
        lbl_p5_them.Size = New Size(20, 15)
        lbl_p5_them.TabIndex = 17
        lbl_p5_them.Text = "P5"
        ' 
        ' lbl_p4_them
        ' 
        lbl_p4_them.AutoSize = True
        lbl_p4_them.Location = New Point(273, 23)
        lbl_p4_them.Name = "lbl_p4_them"
        lbl_p4_them.Size = New Size(20, 15)
        lbl_p4_them.TabIndex = 16
        lbl_p4_them.Text = "P4"
        ' 
        ' lbl_them
        ' 
        lbl_them.AutoSize = True
        lbl_them.Location = New Point(6, 23)
        lbl_them.Name = "lbl_them"
        lbl_them.Size = New Size(37, 15)
        lbl_them.TabIndex = 15
        lbl_them.Text = "Them"
        ' 
        ' lbl_me
        ' 
        lbl_me.AutoSize = True
        lbl_me.Location = New Point(49, 8)
        lbl_me.Name = "lbl_me"
        lbl_me.Size = New Size(24, 15)
        lbl_me.TabIndex = 14
        lbl_me.Text = "Me"
        ' 
        ' lbl_p3_them
        ' 
        lbl_p3_them.AutoSize = True
        lbl_p3_them.Location = New Point(207, 23)
        lbl_p3_them.Name = "lbl_p3_them"
        lbl_p3_them.Size = New Size(20, 15)
        lbl_p3_them.TabIndex = 13
        lbl_p3_them.Text = "P3"
        ' 
        ' lbl_p2_them
        ' 
        lbl_p2_them.AutoSize = True
        lbl_p2_them.Location = New Point(141, 23)
        lbl_p2_them.Name = "lbl_p2_them"
        lbl_p2_them.Size = New Size(20, 15)
        lbl_p2_them.TabIndex = 12
        lbl_p2_them.Text = "P2"
        ' 
        ' lbl_p1_them
        ' 
        lbl_p1_them.AutoSize = True
        lbl_p1_them.Location = New Point(75, 23)
        lbl_p1_them.Name = "lbl_p1_them"
        lbl_p1_them.Size = New Size(20, 15)
        lbl_p1_them.TabIndex = 11
        lbl_p1_them.Text = "P1"
        ' 
        ' lbl_allied_victory_me
        ' 
        lbl_allied_victory_me.AutoSize = True
        lbl_allied_victory_me.Location = New Point(48, 289)
        lbl_allied_victory_me.Name = "lbl_allied_victory_me"
        lbl_allied_victory_me.Size = New Size(21, 15)
        lbl_allied_victory_me.TabIndex = 10
        lbl_allied_victory_me.Text = "AV"
        ' 
        ' lbl_p8_me
        ' 
        lbl_p8_me.AutoSize = True
        lbl_p8_me.Location = New Point(49, 258)
        lbl_p8_me.Name = "lbl_p8_me"
        lbl_p8_me.Size = New Size(20, 15)
        lbl_p8_me.TabIndex = 9
        lbl_p8_me.Text = "P8"
        ' 
        ' lbl_p7_me
        ' 
        lbl_p7_me.AutoSize = True
        lbl_p7_me.Location = New Point(49, 227)
        lbl_p7_me.Name = "lbl_p7_me"
        lbl_p7_me.Size = New Size(20, 15)
        lbl_p7_me.TabIndex = 8
        lbl_p7_me.Text = "P7"
        ' 
        ' lbl_p6_me
        ' 
        lbl_p6_me.AutoSize = True
        lbl_p6_me.Location = New Point(49, 196)
        lbl_p6_me.Name = "lbl_p6_me"
        lbl_p6_me.Size = New Size(20, 15)
        lbl_p6_me.TabIndex = 7
        lbl_p6_me.Text = "P6"
        ' 
        ' lbl_p5_me
        ' 
        lbl_p5_me.AutoSize = True
        lbl_p5_me.Location = New Point(49, 165)
        lbl_p5_me.Name = "lbl_p5_me"
        lbl_p5_me.Size = New Size(20, 15)
        lbl_p5_me.TabIndex = 6
        lbl_p5_me.Text = "P5"
        ' 
        ' lbl_p4_me
        ' 
        lbl_p4_me.AutoSize = True
        lbl_p4_me.Location = New Point(49, 134)
        lbl_p4_me.Name = "lbl_p4_me"
        lbl_p4_me.Size = New Size(20, 15)
        lbl_p4_me.TabIndex = 5
        lbl_p4_me.Text = "P4"
        ' 
        ' lbl_p3_me
        ' 
        lbl_p3_me.AutoSize = True
        lbl_p3_me.Location = New Point(49, 103)
        lbl_p3_me.Name = "lbl_p3_me"
        lbl_p3_me.Size = New Size(20, 15)
        lbl_p3_me.TabIndex = 4
        lbl_p3_me.Text = "P3"
        ' 
        ' lbl_p2_me
        ' 
        lbl_p2_me.AutoSize = True
        lbl_p2_me.Location = New Point(49, 72)
        lbl_p2_me.Name = "lbl_p2_me"
        lbl_p2_me.Size = New Size(20, 15)
        lbl_p2_me.TabIndex = 3
        lbl_p2_me.Text = "P2"
        ' 
        ' lbl_p1_me
        ' 
        lbl_p1_me.AutoSize = True
        lbl_p1_me.Location = New Point(49, 41)
        lbl_p1_me.Name = "lbl_p1_me"
        lbl_p1_me.Size = New Size(20, 15)
        lbl_p1_me.TabIndex = 2
        lbl_p1_me.Text = "P1"
        ' 
        ' lbl_middle
        ' 
        lbl_middle.AutoSize = True
        lbl_middle.Location = New Point(49, 23)
        lbl_middle.Name = "lbl_middle"
        lbl_middle.Size = New Size(22, 15)
        lbl_middle.TabIndex = 1
        lbl_middle.Text = "---"
        ' 
        ' btn_p1_to_p2_diplo
        ' 
        btn_p1_to_p2_diplo.Location = New Point(141, 41)
        btn_p1_to_p2_diplo.Name = "btn_p1_to_p2_diplo"
        btn_p1_to_p2_diplo.Size = New Size(60, 25)
        btn_p1_to_p2_diplo.TabIndex = 0
        btn_p1_to_p2_diplo.Text = "Enemy"
        btn_p1_to_p2_diplo.UseVisualStyleBackColor = True
        ' 
        ' tp_victory
        ' 
        tp_victory.Location = New Point(4, 24)
        tp_victory.Name = "tp_victory"
        tp_victory.Padding = New Padding(3)
        tp_victory.Size = New Size(1152, 509)
        tp_victory.TabIndex = 5
        tp_victory.Text = "Victory"
        tp_victory.UseVisualStyleBackColor = True
        ' 
        ' tp_options
        ' 
        tp_options.Location = New Point(4, 24)
        tp_options.Name = "tp_options"
        tp_options.Padding = New Padding(3)
        tp_options.Size = New Size(1152, 509)
        tp_options.TabIndex = 6
        tp_options.Text = "Options"
        tp_options.UseVisualStyleBackColor = True
        ' 
        ' tp_messages
        ' 
        tp_messages.Location = New Point(4, 24)
        tp_messages.Name = "tp_messages"
        tp_messages.Padding = New Padding(3)
        tp_messages.Size = New Size(1152, 509)
        tp_messages.TabIndex = 7
        tp_messages.Text = "Messages"
        tp_messages.UseVisualStyleBackColor = True
        ' 
        ' tp_cinematics
        ' 
        tp_cinematics.Location = New Point(4, 24)
        tp_cinematics.Name = "tp_cinematics"
        tp_cinematics.Padding = New Padding(3)
        tp_cinematics.Size = New Size(1152, 509)
        tp_cinematics.TabIndex = 8
        tp_cinematics.Text = "Cinematics"
        tp_cinematics.UseVisualStyleBackColor = True
        ' 
        ' tp_triggers
        ' 
        tp_triggers.Location = New Point(4, 24)
        tp_triggers.Name = "tp_triggers"
        tp_triggers.Padding = New Padding(3)
        tp_triggers.Size = New Size(1152, 509)
        tp_triggers.TabIndex = 9
        tp_triggers.Text = "Triggers"
        tp_triggers.UseVisualStyleBackColor = True
        ' 
        ' tp_about
        ' 
        tp_about.Location = New Point(4, 24)
        tp_about.Name = "tp_about"
        tp_about.Padding = New Padding(3)
        tp_about.Size = New Size(1152, 509)
        tp_about.TabIndex = 10
        tp_about.Text = "About"
        tp_about.UseVisualStyleBackColor = True
        ' 
        ' ofd_scenario
        ' 
        ofd_scenario.DefaultExt = "aoe2scenario"
        ofd_scenario.FileName = "*.aoe2scenario"
        ofd_scenario.Filter = """AoE2 Scenario""|*aoe2scenario"
        ofd_scenario.InitialDirectory = "C:\"
        ' 
        ' sfd_scenario
        ' 
        sfd_scenario.DefaultExt = "aoe2scenario"
        sfd_scenario.FileName = "*.aoe2scenario"
        sfd_scenario.Filter = """AoE2 Scenario""|*aoe2scenario"
        sfd_scenario.InitialDirectory = "C:\"
        ' 
        ' ofd_aoe2de_path
        ' 
        ofd_aoe2de_path.FileName = "AoE2DE_s.exe"
        ofd_aoe2de_path.Filter = """Age of Empires 2 DE""|*.exe"
        ofd_aoe2de_path.InitialDirectory = """C:\Program Files (x86)\Steam\steamapps\common\AoE2DE"""
        ' 
        ' tbx_script_filename
        ' 
        tbx_script_filename.Location = New Point(8, 160)
        tbx_script_filename.Name = "tbx_script_filename"
        tbx_script_filename.Size = New Size(240, 23)
        tbx_script_filename.TabIndex = 12
        tbx_script_filename.Text = "Script Filename"
        ' 
        ' frm_scenario_maker
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 561)
        Controls.Add(tc_main)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_scenario_maker"
        Text = "AoE2DE Scenario Maker"
        tc_main.ResumeLayout(False)
        tp_file.ResumeLayout(False)
        tp_file.PerformLayout()
        tp_map.ResumeLayout(False)
        tp_map.PerformLayout()
        CType(nud_mwh_size, ComponentModel.ISupportInitialize).EndInit()
        tp_players.ResumeLayout(False)
        tp_players.PerformLayout()
        CType(NumericUpDown7, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown6, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_priority_p1, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_priority_gaia, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_population_gaia, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_population_p8, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_population_p7, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_population_p6, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_population_p5, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_population_p4, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_population_p3, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_population_p2, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_population_p1, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gold_gaia, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gold_p8, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gold_p7, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gold_p6, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gold_p5, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gold_p4, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gold_p3, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gold_p2, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gold_p1, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_stone_gaia, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_stone_p8, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_stone_p7, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_stone_p6, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_stone_p5, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_stone_p4, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_stone_p3, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_stone_p2, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_stone_p1, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_wood_gaia, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_wood_p8, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_wood_p7, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_wood_p6, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_wood_p5, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_wood_p4, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_wood_p3, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_wood_p2, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_wood_p1, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_food_gaia, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_food_p8, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_food_p7, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_food_p6, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_food_p5, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_food_p4, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_food_p3, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_food_p2, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_food_p1, ComponentModel.ISupportInitialize).EndInit()
        tp_units.ResumeLayout(False)
        tp_diplomacy.ResumeLayout(False)
        tp_diplomacy.PerformLayout()
        ResumeLayout(False)
    End Sub

    Public WithEvents tc_main As TabControl
    Public WithEvents tp_map As TabPage
    Public WithEvents cbx_map_size As ComboBox
    Public WithEvents nud_mwh_size As NumericUpDown
    Public WithEvents cbx_team_positions As CheckBox
    Public WithEvents cbx_default_terrain As ComboBox
    Public WithEvents cbx_color_mood As ComboBox
    Public WithEvents cbx_ai_map_type As ComboBox
    Public WithEvents tp_players As TabPage
    Public WithEvents lb_name_string_id As Label
    Public WithEvents tbx_name_string_id_p8 As TextBox
    Public WithEvents tbx_name_string_id_p7 As TextBox
    Public WithEvents tbx_name_string_id_p6 As TextBox
    Public WithEvents tbx_name_string_id_p5 As TextBox
    Public WithEvents tbx_name_string_id_p4 As TextBox
    Public WithEvents tbx_name_string_id_p3 As TextBox
    Public WithEvents tbx_name_string_id_p2 As TextBox
    Public WithEvents tbx_name_string_id_p1 As TextBox
    Public WithEvents tbx_name_string_id_gaia As TextBox
    Public WithEvents lb_tribe_name As Label
    Public WithEvents tbx_tribe_name_p8 As TextBox
    Public WithEvents tbx_tribe_name_p7 As TextBox
    Public WithEvents tbx_tribe_name_p6 As TextBox
    Public WithEvents tbx_tribe_name_p5 As TextBox
    Public WithEvents tbx_tribe_name_p4 As TextBox
    Public WithEvents tbx_tribe_name_p3 As TextBox
    Public WithEvents tbx_tribe_name_p2 As TextBox
    Public WithEvents tbx_tribe_name_p1 As TextBox
    Public WithEvents tbx_tribe_name_gaia As TextBox
    Public WithEvents cbx_color_p8 As ComboBox
    Public WithEvents cbx_color_p7 As ComboBox
    Public WithEvents cbx_color_p6 As ComboBox
    Public WithEvents cbx_color_p5 As ComboBox
    Public WithEvents cbx_color_p4 As ComboBox
    Public WithEvents cbx_color_p3 As ComboBox
    Public WithEvents cbx_color_p2 As ComboBox
    Public WithEvents cbx_color_p1 As ComboBox
    Public WithEvents lb_color As Label
    Public WithEvents cbx_color_gaia As ComboBox
    Public WithEvents lb_player_8 As Label
    Public WithEvents lb_player_7 As Label
    Public WithEvents lb_player_6 As Label
    Public WithEvents lb_player_5 As Label
    Public WithEvents lb_player_4 As Label
    Public WithEvents lb_player_3 As Label
    Public WithEvents lb_player_2 As Label
    Public WithEvents lb_player_1 As Label
    Public WithEvents lb_gaia As Label
    Public WithEvents NumericUpDown7 As NumericUpDown
    Public WithEvents NumericUpDown6 As NumericUpDown
    Public WithEvents NumericUpDown5 As NumericUpDown
    Public WithEvents NumericUpDown4 As NumericUpDown
    Public WithEvents NumericUpDown3 As NumericUpDown
    Public WithEvents NumericUpDown2 As NumericUpDown
    Public WithEvents NumericUpDown1 As NumericUpDown
    Public WithEvents nud_priority_p1 As NumericUpDown
    Public WithEvents nud_priority_gaia As NumericUpDown
    Public WithEvents lb_priority_gaia As Label
    Public WithEvents nud_population_gaia As NumericUpDown
    Public WithEvents nud_population_p8 As NumericUpDown
    Public WithEvents nud_population_p7 As NumericUpDown
    Public WithEvents nud_population_p6 As NumericUpDown
    Public WithEvents nud_population_p5 As NumericUpDown
    Public WithEvents nud_population_p4 As NumericUpDown
    Public WithEvents nud_population_p3 As NumericUpDown
    Public WithEvents nud_population_p2 As NumericUpDown
    Public WithEvents lb_pop As Label
    Public WithEvents nud_population_p1 As NumericUpDown
    Public WithEvents nud_gold_gaia As NumericUpDown
    Public WithEvents nud_gold_p8 As NumericUpDown
    Public WithEvents nud_gold_p7 As NumericUpDown
    Public WithEvents nud_gold_p6 As NumericUpDown
    Public WithEvents nud_gold_p5 As NumericUpDown
    Public WithEvents nud_gold_p4 As NumericUpDown
    Public WithEvents nud_gold_p3 As NumericUpDown
    Public WithEvents nud_gold_p2 As NumericUpDown
    Public WithEvents lb_gold As Label
    Public WithEvents nud_gold_p1 As NumericUpDown
    Public WithEvents nud_stone_gaia As NumericUpDown
    Public WithEvents nud_stone_p8 As NumericUpDown
    Public WithEvents nud_stone_p7 As NumericUpDown
    Public WithEvents nud_stone_p6 As NumericUpDown
    Public WithEvents nud_stone_p5 As NumericUpDown
    Public WithEvents nud_stone_p4 As NumericUpDown
    Public WithEvents nud_stone_p3 As NumericUpDown
    Public WithEvents nud_stone_p2 As NumericUpDown
    Public WithEvents lb_stone As Label
    Public WithEvents nud_stone_p1 As NumericUpDown
    Public WithEvents nud_wood_gaia As NumericUpDown
    Public WithEvents nud_wood_p8 As NumericUpDown
    Public WithEvents nud_wood_p7 As NumericUpDown
    Public WithEvents nud_wood_p6 As NumericUpDown
    Public WithEvents nud_wood_p5 As NumericUpDown
    Public WithEvents nud_wood_p4 As NumericUpDown
    Public WithEvents nud_wood_p3 As NumericUpDown
    Public WithEvents nud_wood_p2 As NumericUpDown
    Public WithEvents lb_wood As Label
    Public WithEvents nud_wood_p1 As NumericUpDown
    Public WithEvents nud_food_gaia As NumericUpDown
    Public WithEvents nud_food_p8 As NumericUpDown
    Public WithEvents nud_food_p7 As NumericUpDown
    Public WithEvents nud_food_p6 As NumericUpDown
    Public WithEvents nud_food_p5 As NumericUpDown
    Public WithEvents nud_food_p4 As NumericUpDown
    Public WithEvents nud_food_p3 As NumericUpDown
    Public WithEvents nud_food_p2 As NumericUpDown
    Public WithEvents lb_food As Label
    Public WithEvents nud_food_p1 As NumericUpDown
    Public WithEvents cbx_total_players As ComboBox
    Public WithEvents tp_file As TabPage
    Public WithEvents ofd_scenario As OpenFileDialog
    Public WithEvents sfd_scenario As SaveFileDialog
    Public WithEvents btn_save As Button
    Public WithEvents btn_load As Button
    Public WithEvents lbl_load_path As Label
    Public WithEvents lbl_save_path As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Public WithEvents cbx_ai_p8 As CheckBox
    Public WithEvents cbx_ai_p7 As CheckBox
    Public WithEvents cbx_ai_p6 As CheckBox
    Public WithEvents cbx_ai_p5 As CheckBox
    Public WithEvents cbx_ai_p4 As CheckBox
    Public WithEvents cbx_ai_p3 As CheckBox
    Public WithEvents cbx_ai_p2 As CheckBox
    Public WithEvents cbx_ai_p1 As CheckBox
    Public WithEvents cbx_ai_gaia As CheckBox
    Public WithEvents lbl_player_type As Label
    Public WithEvents btn_new_scenario As Button
    Public WithEvents tp_units As TabPage
    Public WithEvents lbx_units As ListBox
    Public WithEvents lbx_map_xy As ListBox
    Public WithEvents btn_remove_unit As Button
    Public WithEvents btn_create_unit As Button
    Public WithEvents tp_diplomacy As TabPage
    Public WithEvents tp_victory As TabPage
    Public WithEvents tp_options As TabPage
    Public WithEvents tp_messages As TabPage
    Public WithEvents tp_cinematics As TabPage
    Public WithEvents tp_triggers As TabPage
    Friend WithEvents tp_about As TabPage
    Public WithEvents cbx_unit_player As ComboBox
    Public WithEvents lbl_middle As Label
    Public WithEvents lbl_p7_me As Label
    Public WithEvents lbl_p6_me As Label
    Public WithEvents lbl_p5_me As Label
    Public WithEvents lbl_p4_me As Label
    Public WithEvents lbl_p3_me As Label
    Public WithEvents lbl_p2_me As Label
    Public WithEvents lbl_p1_me As Label
    Public WithEvents lbl_p8_me As Label
    Public WithEvents lbl_allied_victory_me As Label
    Public WithEvents lbl_them As Label
    Public WithEvents lbl_me As Label
    Public WithEvents lbl_p3_them As Label
    Public WithEvents lbl_p2_them As Label
    Public WithEvents lbl_p1_them As Label
    Public WithEvents lbl_p4_them As Label
    Public WithEvents lbl_p6_them As Label
    Public WithEvents lbl_p5_them As Label
    Public WithEvents lbl_allied_victory_them As Label
    Public WithEvents lbl_p8_them As Label
    Public WithEvents lbl_p7_them As Label
    Public WithEvents btn_p1_to_p2_diplo As Button
    Public WithEvents btn_p1_to_p8_diplo As Button
    Public WithEvents btn_p1_to_p7_diplo As Button
    Public WithEvents btn_p1_to_p6_diplo As Button
    Public WithEvents btn_p1_to_p5_diplo As Button
    Public WithEvents btn_p1_to_p4_diplo As Button
    Public WithEvents btn_p1_to_p3_diplo As Button
    Public WithEvents btn_p2_to_p1_diplo As Button
    Public WithEvents btn_p2_to_p3_diplo As Button
    Friend WithEvents cbx_p1_av_me As CheckBox
    Friend WithEvents cbx_p2_av_me As CheckBox
    Public WithEvents btn_p2_to_p8_diplo As Button
    Public WithEvents btn_p2_to_p7_diplo As Button
    Public WithEvents btn_p2_to_p6_diplo As Button
    Public WithEvents btn_p2_to_p5_diplo As Button
    Public WithEvents btn_p2_to_p4_diplo As Button
    Public WithEvents btn_p4_to_p8_diplo As Button
    Public WithEvents btn_p4_to_p7_diplo As Button
    Public WithEvents btn_p4_to_p6_diplo As Button
    Public WithEvents btn_p4_to_p5_diplo As Button
    Public WithEvents btn_p4_to_p3_diplo As Button
    Public WithEvents btn_p4_to_p2_diplo As Button
    Public WithEvents btn_p4_to_p1_diplo As Button
    Friend WithEvents cbx_p3_av_me As CheckBox
    Public WithEvents btn_p3_to_p8_diplo As Button
    Public WithEvents btn_p3_to_p7_diplo As Button
    Public WithEvents btn_p3_to_p6_diplo As Button
    Public WithEvents btn_p3_to_p5_diplo As Button
    Public WithEvents btn_p3_to_p4_diplo As Button
    Public WithEvents btn_p3_to_p2_diplo As Button
    Public WithEvents btn_p3_to_p1_diplo As Button
    Friend WithEvents cbx_p4_av_me As CheckBox
    Friend WithEvents cbx_p8_av_me As CheckBox
    Friend WithEvents cbx_p7_av_me As CheckBox
    Friend WithEvents cbx_p6_av_me As CheckBox
    Public WithEvents btn_p8_to_p7_diplo As Button
    Public WithEvents btn_p8_to_p6_diplo As Button
    Public WithEvents btn_p8_to_p5_diplo As Button
    Public WithEvents btn_p8_to_p4_diplo As Button
    Public WithEvents btn_p8_to_p3_diplo As Button
    Public WithEvents btn_p8_to_p2_diplo As Button
    Public WithEvents btn_p8_to_p1_diplo As Button
    Public WithEvents btn_p7_to_p8_diplo As Button
    Public WithEvents btn_p7_to_p6_diplo As Button
    Public WithEvents btn_p7_to_p5_diplo As Button
    Public WithEvents btn_p7_to_p4_diplo As Button
    Public WithEvents btn_p7_to_p3_diplo As Button
    Public WithEvents btn_p7_to_p2_diplo As Button
    Public WithEvents btn_p7_to_p1_diplo As Button
    Public WithEvents btn_p6_to_p8_diplo As Button
    Public WithEvents btn_p6_to_p7_diplo As Button
    Public WithEvents btn_p6_to_p5_diplo As Button
    Public WithEvents btn_p6_to_p4_diplo As Button
    Public WithEvents btn_p6_to_p3_diplo As Button
    Public WithEvents btn_p6_to_p2_diplo As Button
    Public WithEvents btn_p6_to_p1_diplo As Button
    Friend WithEvents cbx_p5_av_me As CheckBox
    Public WithEvents btn_p5_to_p8_diplo As Button
    Public WithEvents btn_p5_to_p7_diplo As Button
    Public WithEvents btn_p5_to_p6_diplo As Button
    Public WithEvents btn_p5_to_p4_diplo As Button
    Public WithEvents btn_p5_to_p3_diplo As Button
    Public WithEvents btn_p5_to_p2_diplo As Button
    Public WithEvents btn_p5_to_p1_diplo As Button
    Friend WithEvents cbx_p8_av_them As CheckBox
    Friend WithEvents cbx_p7_av_them As CheckBox
    Friend WithEvents cbx_p6_av_them As CheckBox
    Friend WithEvents cbx_p5_av_them As CheckBox
    Friend WithEvents cbx_p4_av_them As CheckBox
    Friend WithEvents cbx_p3_av_them As CheckBox
    Friend WithEvents cbx_p2_av_them As CheckBox
    Friend WithEvents cbx_p1_av_them As CheckBox
    Public WithEvents cbx_max_teams As ComboBox
    Public WithEvents cbx_lock_teams As CheckBox
    Public WithEvents cbx_random_starting_points As CheckBox
    Public WithEvents cbx_choose_teams As CheckBox
    Public WithEvents ComboBox1 As ComboBox
    Public WithEvents cbx_p2_age As ComboBox
    Public WithEvents cbx_p1_age As ComboBox
    Public WithEvents ComboBox3 As ComboBox
    Public WithEvents ComboBox2 As ComboBox
    Public WithEvents ComboBox6 As ComboBox
    Public WithEvents ComboBox5 As ComboBox
    Public WithEvents ComboBox4 As ComboBox
    Public WithEvents lbl_age As Label
    Public WithEvents cbx_gaia_age As ComboBox
    Friend WithEvents tp_terrain As TabPage
    Public WithEvents btn_test As Button
    Public WithEvents ofd_aoe2de_path As OpenFileDialog
    Public WithEvents tbx_script_filename As TextBox
End Class
