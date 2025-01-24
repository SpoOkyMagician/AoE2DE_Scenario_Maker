<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        tbx_script_filename = New TextBox()
        cbx_map_size = New ComboBox()
        nud_mwh_size = New NumericUpDown()
        cbx_team_positions = New CheckBox()
        cbx_default_terrain = New ComboBox()
        cbx_color_mood = New ComboBox()
        cbx_ai_map_type = New ComboBox()
        tp_terrain = New TabPage()
        cbx_use_layers = New CheckBox()
        lbl_y_terrain = New Label()
        lbx_y_terrain = New ListBox()
        lbl_x_terrain = New Label()
        lbl_elevation = New Label()
        lbl_layer_terrain = New Label()
        lbl_base_terrain = New Label()
        lbx_layer_terrain = New ListBox()
        lbx_elevation = New ListBox()
        Button1 = New Button()
        lbx_x_terrain = New ListBox()
        lbx_base_terrain = New ListBox()
        tp_players = New TabPage()
        cbx_p8_lock_personality = New CheckBox()
        cbx_p7_lock_personality = New CheckBox()
        cbx_p6_lock_personality = New CheckBox()
        cbx_p5_lock_personality = New CheckBox()
        cbx_p4_lock_personality = New CheckBox()
        cbx_p3_lock_personality = New CheckBox()
        cbx_p2_lock_personality = New CheckBox()
        cbx_p1_lock_personality = New CheckBox()
        cbx_gaia_lock_personality = New CheckBox()
        cbx_p8_lock_civ = New CheckBox()
        cbx_p7_lock_civ = New CheckBox()
        cbx_p6_lock_civ = New CheckBox()
        cbx_p5_lock_civ = New CheckBox()
        cbx_p4_lock_civ = New CheckBox()
        cbx_p3_lock_civ = New CheckBox()
        cbx_p2_lock_civ = New CheckBox()
        cbx_p1_lock_civ = New CheckBox()
        cbx_gaia_lock_civ = New CheckBox()
        cbx_p8_architecture = New ComboBox()
        cbx_p7_architecture = New ComboBox()
        cbx_p6_architecture = New ComboBox()
        cbx_p5_architecture = New ComboBox()
        cbx_p4_architecture = New ComboBox()
        cbx_p3_architecture = New ComboBox()
        cbx_p2_architecture = New ComboBox()
        cbx_p1_architecture = New ComboBox()
        cbx_gaia_architecture = New ComboBox()
        lbl_architecture = New Label()
        lbl_civilization = New Label()
        cbx_p8_civilization = New ComboBox()
        cbx_p7_civilization = New ComboBox()
        cbx_p6_civilization = New ComboBox()
        cbx_p5_civilization = New ComboBox()
        cbx_p4_civilization = New ComboBox()
        cbx_p3_civilization = New ComboBox()
        cbx_p2_civilization = New ComboBox()
        cbx_p1_civilization = New ComboBox()
        cbx_gaia_civilization = New ComboBox()
        lbl_ai_personality = New Label()
        cbx_p8_ai_personality = New ComboBox()
        cbx_p7_ai_personality = New ComboBox()
        cbx_p6_ai_personality = New ComboBox()
        cbx_p5_ai_personality = New ComboBox()
        cbx_p4_ai_personality = New ComboBox()
        cbx_p3_ai_personality = New ComboBox()
        cbx_p2_ai_personality = New ComboBox()
        cbx_gaia_ai_personality = New ComboBox()
        cbx_p1_ai_personality = New ComboBox()
        cbx_gaia_age = New ComboBox()
        lbl_age = New Label()
        cbx_p8_age = New ComboBox()
        cbx_p7_age = New ComboBox()
        cbx_p6_age = New ComboBox()
        cbx_p5_age = New ComboBox()
        cbx_p4_age = New ComboBox()
        cbx_p3_age = New ComboBox()
        cbx_p2_age = New ComboBox()
        cbx_p1_age = New ComboBox()
        lbl_player_type = New Label()
        cbx_p8_ai = New CheckBox()
        cbx_p7_ai = New CheckBox()
        cbx_p6_ai = New CheckBox()
        cbx_p5_ai = New CheckBox()
        cbx_p4_ai = New CheckBox()
        cbx_p3_ai = New CheckBox()
        cbx_p2_ai = New CheckBox()
        cbx_p1_ai = New CheckBox()
        cbx_gaia_ai = New CheckBox()
        lb_name_string_id = New Label()
        tbx_p8_name_string_id = New TextBox()
        tbx_p7_name_string_id = New TextBox()
        tbx_p6_name_string_id = New TextBox()
        tbx_p5_name_string_id = New TextBox()
        tbx_p4_name_string_id = New TextBox()
        tbx_p3_name_string_id = New TextBox()
        tbx_p2_name_string_id = New TextBox()
        tbx_p1_name_string_id = New TextBox()
        tbx_gaia_name_string_id = New TextBox()
        lb_tribe_name = New Label()
        tbx_p8_tribe_name = New TextBox()
        tbx_p7_tribe_name = New TextBox()
        tbx_p6_tribe_name = New TextBox()
        tbx_p5_tribe_name = New TextBox()
        tbx_p4_tribe_name = New TextBox()
        tbx_p3_tribe_name = New TextBox()
        tbx_p2_tribe_name = New TextBox()
        tbx_p1_tribe_name = New TextBox()
        tbx_gaia_tribe_name = New TextBox()
        cbx_p8_color = New ComboBox()
        cbx_p7_color = New ComboBox()
        cbx_p6_color = New ComboBox()
        cbx_p5_color = New ComboBox()
        cbx_p4_color = New ComboBox()
        cbx_p3_color = New ComboBox()
        cbx_p2_color = New ComboBox()
        cbx_p1_color = New ComboBox()
        lb_color = New Label()
        cbx_gaia_color = New ComboBox()
        lb_player_8 = New Label()
        lb_player_7 = New Label()
        lb_player_6 = New Label()
        lb_player_5 = New Label()
        lb_player_4 = New Label()
        lb_player_3 = New Label()
        lb_player_2 = New Label()
        lb_player_1 = New Label()
        lb_gaia = New Label()
        nud_p8_priority = New NumericUpDown()
        nud_p7_priority = New NumericUpDown()
        nud_p6_priority = New NumericUpDown()
        nud_p5_priority = New NumericUpDown()
        nud_p4_priority = New NumericUpDown()
        nud_p3_priority = New NumericUpDown()
        nud_p2_priority = New NumericUpDown()
        nud_p1_priority = New NumericUpDown()
        nud_gaia_priority = New NumericUpDown()
        lb_priority_gaia = New Label()
        nud_gaia_population = New NumericUpDown()
        nud_p8_population = New NumericUpDown()
        nud_p7_population = New NumericUpDown()
        nud_p6_population = New NumericUpDown()
        nud_p5_population = New NumericUpDown()
        nud_p4_population = New NumericUpDown()
        nud_p3_population = New NumericUpDown()
        nud_p2_population = New NumericUpDown()
        lb_pop = New Label()
        nud_p1_population = New NumericUpDown()
        nud_gaia_gold = New NumericUpDown()
        nud_p8_gold = New NumericUpDown()
        nud_p7_gold = New NumericUpDown()
        nud_p6_gold = New NumericUpDown()
        nud_p5_gold = New NumericUpDown()
        nud_p4_gold = New NumericUpDown()
        nud_p3_gold = New NumericUpDown()
        nud_p2_gold = New NumericUpDown()
        lb_gold = New Label()
        nud_p1_gold = New NumericUpDown()
        nud_gaia_stone = New NumericUpDown()
        nud_p8_stone = New NumericUpDown()
        nud_p7_stone = New NumericUpDown()
        nud_p6_stone = New NumericUpDown()
        nud_p5_stone = New NumericUpDown()
        nud_p4_stone = New NumericUpDown()
        nud_p3_stone = New NumericUpDown()
        nud_p2_stone = New NumericUpDown()
        lb_stone = New Label()
        nud_p1_stone = New NumericUpDown()
        nud_gaia_wood = New NumericUpDown()
        nud_p8_wood = New NumericUpDown()
        nud_p7_wood = New NumericUpDown()
        nud_p6_wood = New NumericUpDown()
        nud_p5_wood = New NumericUpDown()
        nud_p4_wood = New NumericUpDown()
        nud_p3_wood = New NumericUpDown()
        nud_p2_wood = New NumericUpDown()
        lb_wood = New Label()
        nud_p1_wood = New NumericUpDown()
        nud_gaia_food = New NumericUpDown()
        nud_p8_food = New NumericUpDown()
        nud_p7_food = New NumericUpDown()
        nud_p6_food = New NumericUpDown()
        nud_p5_food = New NumericUpDown()
        nud_p4_food = New NumericUpDown()
        nud_p3_food = New NumericUpDown()
        nud_p2_food = New NumericUpDown()
        lb_food = New Label()
        nud_p1_food = New NumericUpDown()
        cbx_total_players = New ComboBox()
        tp_units = New TabPage()
        cbx_unit_player = New ComboBox()
        btn_remove_unit = New Button()
        btn_create_unit = New Button()
        lbx_objects = New ListBox()
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
        lbl_aoe2de_sm = New Label()
        ofd_scenario = New OpenFileDialog()
        sfd_scenario = New SaveFileDialog()
        ofd_aoe2de_path = New OpenFileDialog()
        lbx_map_y = New ListBox()
        lbx_map_x = New ListBox()
        lbx_placed_objects = New ListBox()
        tc_main.SuspendLayout()
        tp_file.SuspendLayout()
        tp_map.SuspendLayout()
        CType(nud_mwh_size, ComponentModel.ISupportInitialize).BeginInit()
        tp_terrain.SuspendLayout()
        tp_players.SuspendLayout()
        CType(nud_p8_priority, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p7_priority, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p6_priority, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p5_priority, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p4_priority, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p3_priority, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p2_priority, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p1_priority, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gaia_priority, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gaia_population, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p8_population, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p7_population, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p6_population, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p5_population, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p4_population, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p3_population, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p2_population, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p1_population, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gaia_gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p8_gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p7_gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p6_gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p5_gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p4_gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p3_gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p2_gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p1_gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gaia_stone, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p8_stone, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p7_stone, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p6_stone, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p5_stone, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p4_stone, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p3_stone, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p2_stone, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p1_stone, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gaia_wood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p8_wood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p7_wood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p6_wood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p5_wood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p4_wood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p3_wood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p2_wood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p1_wood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_gaia_food, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p8_food, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p7_food, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p6_food, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p5_food, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p4_food, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p3_food, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p2_food, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_p1_food, ComponentModel.ISupportInitialize).BeginInit()
        tp_units.SuspendLayout()
        tp_diplomacy.SuspendLayout()
        tp_about.SuspendLayout()
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
        tc_main.Size = New Size(1436, 537)
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
        tp_file.Size = New Size(1428, 509)
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
        tp_map.Size = New Size(1428, 509)
        tp_map.TabIndex = 0
        tp_map.Text = "Map"
        tp_map.UseVisualStyleBackColor = True
        ' 
        ' tbx_script_filename
        ' 
        tbx_script_filename.Location = New Point(8, 160)
        tbx_script_filename.Name = "tbx_script_filename"
        tbx_script_filename.Size = New Size(240, 23)
        tbx_script_filename.TabIndex = 12
        tbx_script_filename.Text = "Script Filename"
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
        tp_terrain.Controls.Add(cbx_use_layers)
        tp_terrain.Controls.Add(lbl_y_terrain)
        tp_terrain.Controls.Add(lbx_y_terrain)
        tp_terrain.Controls.Add(lbl_x_terrain)
        tp_terrain.Controls.Add(lbl_elevation)
        tp_terrain.Controls.Add(lbl_layer_terrain)
        tp_terrain.Controls.Add(lbl_base_terrain)
        tp_terrain.Controls.Add(lbx_layer_terrain)
        tp_terrain.Controls.Add(lbx_elevation)
        tp_terrain.Controls.Add(Button1)
        tp_terrain.Controls.Add(lbx_x_terrain)
        tp_terrain.Controls.Add(lbx_base_terrain)
        tp_terrain.Location = New Point(4, 24)
        tp_terrain.Name = "tp_terrain"
        tp_terrain.Size = New Size(1428, 509)
        tp_terrain.TabIndex = 11
        tp_terrain.Text = "Terrain"
        tp_terrain.UseVisualStyleBackColor = True
        ' 
        ' cbx_use_layers
        ' 
        cbx_use_layers.AutoSize = True
        cbx_use_layers.Location = New Point(664, 64)
        cbx_use_layers.Name = "cbx_use_layers"
        cbx_use_layers.Size = New Size(105, 19)
        cbx_use_layers.TabIndex = 14
        cbx_use_layers.Text = "Layering Mode"
        cbx_use_layers.UseVisualStyleBackColor = True
        ' 
        ' lbl_y_terrain
        ' 
        lbl_y_terrain.AutoSize = True
        lbl_y_terrain.Location = New Point(512, 8)
        lbl_y_terrain.Name = "lbl_y_terrain"
        lbl_y_terrain.Size = New Size(14, 15)
        lbl_y_terrain.TabIndex = 13
        lbl_y_terrain.Text = "Y"
        ' 
        ' lbx_y_terrain
        ' 
        lbx_y_terrain.FormattingEnabled = True
        lbx_y_terrain.ItemHeight = 15
        lbx_y_terrain.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365", "366", "367", "368", "369", "370", "371", "372", "373", "374", "375", "376", "377", "378", "379", "380", "381", "382", "383", "384", "385", "386", "387", "388", "389", "390", "391", "392", "393", "394", "395", "396", "397", "398", "399", "400", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "418", "419", "420", "421", "422", "423", "424", "425", "426", "427", "428", "429", "430", "431", "432", "433", "434", "435", "436", "437", "438", "439", "440", "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454", "455", "456", "457", "458", "459", "460", "461", "462", "463", "464", "465", "466", "467", "468", "469", "470", "471", "472", "473", "474", "475", "476", "477", "478", "479"})
        lbx_y_terrain.Location = New Point(512, 32)
        lbx_y_terrain.Name = "lbx_y_terrain"
        lbx_y_terrain.Size = New Size(48, 469)
        lbx_y_terrain.TabIndex = 12
        ' 
        ' lbl_x_terrain
        ' 
        lbl_x_terrain.AutoSize = True
        lbl_x_terrain.Location = New Point(456, 8)
        lbl_x_terrain.Name = "lbl_x_terrain"
        lbl_x_terrain.Size = New Size(14, 15)
        lbl_x_terrain.TabIndex = 11
        lbl_x_terrain.Text = "X"
        ' 
        ' lbl_elevation
        ' 
        lbl_elevation.AutoSize = True
        lbl_elevation.Location = New Point(568, 8)
        lbl_elevation.Name = "lbl_elevation"
        lbl_elevation.Size = New Size(55, 15)
        lbl_elevation.TabIndex = 10
        lbl_elevation.Text = "Elevation"
        ' 
        ' lbl_layer_terrain
        ' 
        lbl_layer_terrain.AutoSize = True
        lbl_layer_terrain.Location = New Point(232, 8)
        lbl_layer_terrain.Name = "lbl_layer_terrain"
        lbl_layer_terrain.Size = New Size(73, 15)
        lbl_layer_terrain.TabIndex = 9
        lbl_layer_terrain.Text = "Layer Terrain"
        ' 
        ' lbl_base_terrain
        ' 
        lbl_base_terrain.AutoSize = True
        lbl_base_terrain.Location = New Point(8, 8)
        lbl_base_terrain.Name = "lbl_base_terrain"
        lbl_base_terrain.Size = New Size(69, 15)
        lbl_base_terrain.TabIndex = 8
        lbl_base_terrain.Text = "Base Terrain"
        ' 
        ' lbx_layer_terrain
        ' 
        lbx_layer_terrain.FormattingEnabled = True
        lbx_layer_terrain.ItemHeight = 15
        lbx_layer_terrain.Items.AddRange(New Object() {"Beach", "Beach (Non-Navigable)", "Beach (Non-Navigable), Wet Gravel", "Beach (Non-Navigable), Wet Rock", "Beach (Non-Navigable), Wet Sand", "Beach, Ice", "Beach, Vegetation", "Beach, Wet", "Beach, Wet Gravel", "Beach, Wet Rock", "Beach, White", "Beach, White, Vegetation", "Black", "Desert, Cracked", "Desert, Quicksand", "Desert, Sand", "Dirt 1", "Dirt 2", "Dirt 3", "Dirt 4", "Dirt, Mud", "Dirt, Savannah", "Farm", "Farm, 0%", "Farm, 33%", "Farm, 67%", "Farm, Dead", "Forest, Acacia", "Forest, Autumn", "Forest, Autumn Snow", "Forest, Bamboo", "Forest, Baobab", "Forest, Birch", "Forest, Bush", "Forest, Dead", "Forest, Dragon Tree", "Forest, Jungle", "Forest, Mangrove", "Forest, Mediterranean", "Forest, Oak", "Forest, Oak Bush", "Forest, Palm Desert", "Forest, Palm Grass", "Forest, Pine", "Forest, Pine Snow", "Forest, Rainforest", "Forest, Reeds", "Forest, Reeds (Beach)", "Forest, Reeds (Shallow)", "Grass 1", "Grass 2", "Grass 3", "Grass, Dry", "Grass, Foundation", "Grass, Jungle", "Grass, Jungle (Rainforest)", "Grass, Other", "Gravel, Default", "Gravel, Desert", "Ice", "Ice, Navigable", "Rice Farm", "Rice Farm, 0%", "Rice Farm, 33%", "Rice Farm, 66%", "Rice Farm, Dead", "Road", "Road, Broken", "Road, Fungus", "Road, Gravel", "Rock 1", "Shallows", "Shallows, Azure", "Shallows, Mangrove", "Snow", "Snow, Foundation", "Snow, Light", "Snow, Strong", "Swamp, Bogland", "Swamp, Shallows", "Underbrush", "Underbrush, Jungle", "Underbrush, Leaves", "Underbrush, Snow", "Water 2D, Bridge", "Water 2D, Shoreless", "Water, Azure", "Water, Brown", "Water, Deep", "Water, Deep Ocean", "Water, Green", "Water, Medium", "Water, Shallow"})
        lbx_layer_terrain.Location = New Point(232, 32)
        lbx_layer_terrain.Name = "lbx_layer_terrain"
        lbx_layer_terrain.Size = New Size(216, 469)
        lbx_layer_terrain.TabIndex = 7
        ' 
        ' lbx_elevation
        ' 
        lbx_elevation.FormattingEnabled = True
        lbx_elevation.ItemHeight = 15
        lbx_elevation.Items.AddRange(New Object() {"Elevation 1", "Elevation 2", "Elevation 3", "Elevation 4", "Elevation 5", "Elevation 6", "Elevation 7"})
        lbx_elevation.Location = New Point(568, 32)
        lbx_elevation.Name = "lbx_elevation"
        lbx_elevation.Size = New Size(88, 109)
        lbx_elevation.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(664, 32)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 25)
        Button1.TabIndex = 5
        Button1.Text = "Set"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lbx_x_terrain
        ' 
        lbx_x_terrain.FormattingEnabled = True
        lbx_x_terrain.ItemHeight = 15
        lbx_x_terrain.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365", "366", "367", "368", "369", "370", "371", "372", "373", "374", "375", "376", "377", "378", "379", "380", "381", "382", "383", "384", "385", "386", "387", "388", "389", "390", "391", "392", "393", "394", "395", "396", "397", "398", "399", "400", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "418", "419", "420", "421", "422", "423", "424", "425", "426", "427", "428", "429", "430", "431", "432", "433", "434", "435", "436", "437", "438", "439", "440", "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454", "455", "456", "457", "458", "459", "460", "461", "462", "463", "464", "465", "466", "467", "468", "469", "470", "471", "472", "473", "474", "475", "476", "477", "478", "479"})
        lbx_x_terrain.Location = New Point(456, 32)
        lbx_x_terrain.Name = "lbx_x_terrain"
        lbx_x_terrain.Size = New Size(48, 469)
        lbx_x_terrain.TabIndex = 4
        ' 
        ' lbx_base_terrain
        ' 
        lbx_base_terrain.FormattingEnabled = True
        lbx_base_terrain.ItemHeight = 15
        lbx_base_terrain.Items.AddRange(New Object() {"Beach", "Beach (Non-Navigable)", "Beach (Non-Navigable), Wet Gravel", "Beach (Non-Navigable), Wet Rock", "Beach (Non-Navigable), Wet Sand", "Beach, Ice", "Beach, Vegetation", "Beach, Wet", "Beach, Wet Gravel", "Beach, Wet Rock", "Beach, White", "Beach, White, Vegetation", "Black", "Desert, Cracked", "Desert, Quicksand", "Desert, Sand", "Dirt 1", "Dirt 2", "Dirt 3", "Dirt 4", "Dirt, Mud", "Dirt, Savannah", "Farm", "Farm, 0%", "Farm, 33%", "Farm, 67%", "Farm, Dead", "Forest, Acacia", "Forest, Autumn", "Forest, Autumn Snow", "Forest, Bamboo", "Forest, Baobab", "Forest, Birch", "Forest, Bush", "Forest, Dead", "Forest, Dragon Tree", "Forest, Jungle", "Forest, Mangrove", "Forest, Mediterranean", "Forest, Oak", "Forest, Oak Bush", "Forest, Palm Desert", "Forest, Palm Grass", "Forest, Pine", "Forest, Pine Snow", "Forest, Rainforest", "Forest, Reeds", "Forest, Reeds (Beach)", "Forest, Reeds (Shallow)", "Grass 1", "Grass 2", "Grass 3", "Grass, Dry", "Grass, Foundation", "Grass, Jungle", "Grass, Jungle (Rainforest)", "Grass, Other", "Gravel, Default", "Gravel, Desert", "Ice", "Ice, Navigable", "Rice Farm", "Rice Farm, 0%", "Rice Farm, 33%", "Rice Farm, 66%", "Rice Farm, Dead", "Road", "Road, Broken", "Road, Fungus", "Road, Gravel", "Rock 1", "Shallows", "Shallows, Azure", "Shallows, Mangrove", "Snow", "Snow, Foundation", "Snow, Light", "Snow, Strong", "Swamp, Bogland", "Swamp, Shallows", "Underbrush", "Underbrush, Jungle", "Underbrush, Leaves", "Underbrush, Snow", "Water 2D, Bridge", "Water 2D, Shoreless", "Water, Azure", "Water, Brown", "Water, Deep", "Water, Deep Ocean", "Water, Green", "Water, Medium", "Water, Shallow"})
        lbx_base_terrain.Location = New Point(8, 32)
        lbx_base_terrain.Name = "lbx_base_terrain"
        lbx_base_terrain.Size = New Size(216, 469)
        lbx_base_terrain.TabIndex = 3
        ' 
        ' tp_players
        ' 
        tp_players.Controls.Add(cbx_p8_lock_personality)
        tp_players.Controls.Add(cbx_p7_lock_personality)
        tp_players.Controls.Add(cbx_p6_lock_personality)
        tp_players.Controls.Add(cbx_p5_lock_personality)
        tp_players.Controls.Add(cbx_p4_lock_personality)
        tp_players.Controls.Add(cbx_p3_lock_personality)
        tp_players.Controls.Add(cbx_p2_lock_personality)
        tp_players.Controls.Add(cbx_p1_lock_personality)
        tp_players.Controls.Add(cbx_gaia_lock_personality)
        tp_players.Controls.Add(cbx_p8_lock_civ)
        tp_players.Controls.Add(cbx_p7_lock_civ)
        tp_players.Controls.Add(cbx_p6_lock_civ)
        tp_players.Controls.Add(cbx_p5_lock_civ)
        tp_players.Controls.Add(cbx_p4_lock_civ)
        tp_players.Controls.Add(cbx_p3_lock_civ)
        tp_players.Controls.Add(cbx_p2_lock_civ)
        tp_players.Controls.Add(cbx_p1_lock_civ)
        tp_players.Controls.Add(cbx_gaia_lock_civ)
        tp_players.Controls.Add(cbx_p8_architecture)
        tp_players.Controls.Add(cbx_p7_architecture)
        tp_players.Controls.Add(cbx_p6_architecture)
        tp_players.Controls.Add(cbx_p5_architecture)
        tp_players.Controls.Add(cbx_p4_architecture)
        tp_players.Controls.Add(cbx_p3_architecture)
        tp_players.Controls.Add(cbx_p2_architecture)
        tp_players.Controls.Add(cbx_p1_architecture)
        tp_players.Controls.Add(cbx_gaia_architecture)
        tp_players.Controls.Add(lbl_architecture)
        tp_players.Controls.Add(lbl_civilization)
        tp_players.Controls.Add(cbx_p8_civilization)
        tp_players.Controls.Add(cbx_p7_civilization)
        tp_players.Controls.Add(cbx_p6_civilization)
        tp_players.Controls.Add(cbx_p5_civilization)
        tp_players.Controls.Add(cbx_p4_civilization)
        tp_players.Controls.Add(cbx_p3_civilization)
        tp_players.Controls.Add(cbx_p2_civilization)
        tp_players.Controls.Add(cbx_p1_civilization)
        tp_players.Controls.Add(cbx_gaia_civilization)
        tp_players.Controls.Add(lbl_ai_personality)
        tp_players.Controls.Add(cbx_p8_ai_personality)
        tp_players.Controls.Add(cbx_p7_ai_personality)
        tp_players.Controls.Add(cbx_p6_ai_personality)
        tp_players.Controls.Add(cbx_p5_ai_personality)
        tp_players.Controls.Add(cbx_p4_ai_personality)
        tp_players.Controls.Add(cbx_p3_ai_personality)
        tp_players.Controls.Add(cbx_p2_ai_personality)
        tp_players.Controls.Add(cbx_gaia_ai_personality)
        tp_players.Controls.Add(cbx_p1_ai_personality)
        tp_players.Controls.Add(cbx_gaia_age)
        tp_players.Controls.Add(lbl_age)
        tp_players.Controls.Add(cbx_p8_age)
        tp_players.Controls.Add(cbx_p7_age)
        tp_players.Controls.Add(cbx_p6_age)
        tp_players.Controls.Add(cbx_p5_age)
        tp_players.Controls.Add(cbx_p4_age)
        tp_players.Controls.Add(cbx_p3_age)
        tp_players.Controls.Add(cbx_p2_age)
        tp_players.Controls.Add(cbx_p1_age)
        tp_players.Controls.Add(lbl_player_type)
        tp_players.Controls.Add(cbx_p8_ai)
        tp_players.Controls.Add(cbx_p7_ai)
        tp_players.Controls.Add(cbx_p6_ai)
        tp_players.Controls.Add(cbx_p5_ai)
        tp_players.Controls.Add(cbx_p4_ai)
        tp_players.Controls.Add(cbx_p3_ai)
        tp_players.Controls.Add(cbx_p2_ai)
        tp_players.Controls.Add(cbx_p1_ai)
        tp_players.Controls.Add(cbx_gaia_ai)
        tp_players.Controls.Add(lb_name_string_id)
        tp_players.Controls.Add(tbx_p8_name_string_id)
        tp_players.Controls.Add(tbx_p7_name_string_id)
        tp_players.Controls.Add(tbx_p6_name_string_id)
        tp_players.Controls.Add(tbx_p5_name_string_id)
        tp_players.Controls.Add(tbx_p4_name_string_id)
        tp_players.Controls.Add(tbx_p3_name_string_id)
        tp_players.Controls.Add(tbx_p2_name_string_id)
        tp_players.Controls.Add(tbx_p1_name_string_id)
        tp_players.Controls.Add(tbx_gaia_name_string_id)
        tp_players.Controls.Add(lb_tribe_name)
        tp_players.Controls.Add(tbx_p8_tribe_name)
        tp_players.Controls.Add(tbx_p7_tribe_name)
        tp_players.Controls.Add(tbx_p6_tribe_name)
        tp_players.Controls.Add(tbx_p5_tribe_name)
        tp_players.Controls.Add(tbx_p4_tribe_name)
        tp_players.Controls.Add(tbx_p3_tribe_name)
        tp_players.Controls.Add(tbx_p2_tribe_name)
        tp_players.Controls.Add(tbx_p1_tribe_name)
        tp_players.Controls.Add(tbx_gaia_tribe_name)
        tp_players.Controls.Add(cbx_p8_color)
        tp_players.Controls.Add(cbx_p7_color)
        tp_players.Controls.Add(cbx_p6_color)
        tp_players.Controls.Add(cbx_p5_color)
        tp_players.Controls.Add(cbx_p4_color)
        tp_players.Controls.Add(cbx_p3_color)
        tp_players.Controls.Add(cbx_p2_color)
        tp_players.Controls.Add(cbx_p1_color)
        tp_players.Controls.Add(lb_color)
        tp_players.Controls.Add(cbx_gaia_color)
        tp_players.Controls.Add(lb_player_8)
        tp_players.Controls.Add(lb_player_7)
        tp_players.Controls.Add(lb_player_6)
        tp_players.Controls.Add(lb_player_5)
        tp_players.Controls.Add(lb_player_4)
        tp_players.Controls.Add(lb_player_3)
        tp_players.Controls.Add(lb_player_2)
        tp_players.Controls.Add(lb_player_1)
        tp_players.Controls.Add(lb_gaia)
        tp_players.Controls.Add(nud_p8_priority)
        tp_players.Controls.Add(nud_p7_priority)
        tp_players.Controls.Add(nud_p6_priority)
        tp_players.Controls.Add(nud_p5_priority)
        tp_players.Controls.Add(nud_p4_priority)
        tp_players.Controls.Add(nud_p3_priority)
        tp_players.Controls.Add(nud_p2_priority)
        tp_players.Controls.Add(nud_p1_priority)
        tp_players.Controls.Add(nud_gaia_priority)
        tp_players.Controls.Add(lb_priority_gaia)
        tp_players.Controls.Add(nud_gaia_population)
        tp_players.Controls.Add(nud_p8_population)
        tp_players.Controls.Add(nud_p7_population)
        tp_players.Controls.Add(nud_p6_population)
        tp_players.Controls.Add(nud_p5_population)
        tp_players.Controls.Add(nud_p4_population)
        tp_players.Controls.Add(nud_p3_population)
        tp_players.Controls.Add(nud_p2_population)
        tp_players.Controls.Add(lb_pop)
        tp_players.Controls.Add(nud_p1_population)
        tp_players.Controls.Add(nud_gaia_gold)
        tp_players.Controls.Add(nud_p8_gold)
        tp_players.Controls.Add(nud_p7_gold)
        tp_players.Controls.Add(nud_p6_gold)
        tp_players.Controls.Add(nud_p5_gold)
        tp_players.Controls.Add(nud_p4_gold)
        tp_players.Controls.Add(nud_p3_gold)
        tp_players.Controls.Add(nud_p2_gold)
        tp_players.Controls.Add(lb_gold)
        tp_players.Controls.Add(nud_p1_gold)
        tp_players.Controls.Add(nud_gaia_stone)
        tp_players.Controls.Add(nud_p8_stone)
        tp_players.Controls.Add(nud_p7_stone)
        tp_players.Controls.Add(nud_p6_stone)
        tp_players.Controls.Add(nud_p5_stone)
        tp_players.Controls.Add(nud_p4_stone)
        tp_players.Controls.Add(nud_p3_stone)
        tp_players.Controls.Add(nud_p2_stone)
        tp_players.Controls.Add(lb_stone)
        tp_players.Controls.Add(nud_p1_stone)
        tp_players.Controls.Add(nud_gaia_wood)
        tp_players.Controls.Add(nud_p8_wood)
        tp_players.Controls.Add(nud_p7_wood)
        tp_players.Controls.Add(nud_p6_wood)
        tp_players.Controls.Add(nud_p5_wood)
        tp_players.Controls.Add(nud_p4_wood)
        tp_players.Controls.Add(nud_p3_wood)
        tp_players.Controls.Add(nud_p2_wood)
        tp_players.Controls.Add(lb_wood)
        tp_players.Controls.Add(nud_p1_wood)
        tp_players.Controls.Add(nud_gaia_food)
        tp_players.Controls.Add(nud_p8_food)
        tp_players.Controls.Add(nud_p7_food)
        tp_players.Controls.Add(nud_p6_food)
        tp_players.Controls.Add(nud_p5_food)
        tp_players.Controls.Add(nud_p4_food)
        tp_players.Controls.Add(nud_p3_food)
        tp_players.Controls.Add(nud_p2_food)
        tp_players.Controls.Add(lb_food)
        tp_players.Controls.Add(nud_p1_food)
        tp_players.Controls.Add(cbx_total_players)
        tp_players.Location = New Point(4, 24)
        tp_players.Name = "tp_players"
        tp_players.Padding = New Padding(3)
        tp_players.Size = New Size(1428, 509)
        tp_players.TabIndex = 1
        tp_players.Text = "Players"
        tp_players.UseVisualStyleBackColor = True
        ' 
        ' cbx_p8_lock_personality
        ' 
        cbx_p8_lock_personality.AutoSize = True
        cbx_p8_lock_personality.Location = New Point(1312, 304)
        cbx_p8_lock_personality.Name = "cbx_p8_lock_personality"
        cbx_p8_lock_personality.Size = New Size(112, 19)
        cbx_p8_lock_personality.TabIndex = 272
        cbx_p8_lock_personality.Text = "Lock Personality"
        cbx_p8_lock_personality.UseVisualStyleBackColor = True
        ' 
        ' cbx_p7_lock_personality
        ' 
        cbx_p7_lock_personality.AutoSize = True
        cbx_p7_lock_personality.Location = New Point(1312, 272)
        cbx_p7_lock_personality.Name = "cbx_p7_lock_personality"
        cbx_p7_lock_personality.Size = New Size(112, 19)
        cbx_p7_lock_personality.TabIndex = 271
        cbx_p7_lock_personality.Text = "Lock Personality"
        cbx_p7_lock_personality.UseVisualStyleBackColor = True
        ' 
        ' cbx_p6_lock_personality
        ' 
        cbx_p6_lock_personality.AutoSize = True
        cbx_p6_lock_personality.Location = New Point(1312, 240)
        cbx_p6_lock_personality.Name = "cbx_p6_lock_personality"
        cbx_p6_lock_personality.Size = New Size(112, 19)
        cbx_p6_lock_personality.TabIndex = 270
        cbx_p6_lock_personality.Text = "Lock Personality"
        cbx_p6_lock_personality.UseVisualStyleBackColor = True
        ' 
        ' cbx_p5_lock_personality
        ' 
        cbx_p5_lock_personality.AutoSize = True
        cbx_p5_lock_personality.Location = New Point(1312, 208)
        cbx_p5_lock_personality.Name = "cbx_p5_lock_personality"
        cbx_p5_lock_personality.Size = New Size(112, 19)
        cbx_p5_lock_personality.TabIndex = 269
        cbx_p5_lock_personality.Text = "Lock Personality"
        cbx_p5_lock_personality.UseVisualStyleBackColor = True
        ' 
        ' cbx_p4_lock_personality
        ' 
        cbx_p4_lock_personality.AutoSize = True
        cbx_p4_lock_personality.Location = New Point(1312, 176)
        cbx_p4_lock_personality.Name = "cbx_p4_lock_personality"
        cbx_p4_lock_personality.Size = New Size(112, 19)
        cbx_p4_lock_personality.TabIndex = 268
        cbx_p4_lock_personality.Text = "Lock Personality"
        cbx_p4_lock_personality.UseVisualStyleBackColor = True
        ' 
        ' cbx_p3_lock_personality
        ' 
        cbx_p3_lock_personality.AutoSize = True
        cbx_p3_lock_personality.Location = New Point(1312, 144)
        cbx_p3_lock_personality.Name = "cbx_p3_lock_personality"
        cbx_p3_lock_personality.Size = New Size(112, 19)
        cbx_p3_lock_personality.TabIndex = 267
        cbx_p3_lock_personality.Text = "Lock Personality"
        cbx_p3_lock_personality.UseVisualStyleBackColor = True
        ' 
        ' cbx_p2_lock_personality
        ' 
        cbx_p2_lock_personality.AutoSize = True
        cbx_p2_lock_personality.Location = New Point(1312, 112)
        cbx_p2_lock_personality.Name = "cbx_p2_lock_personality"
        cbx_p2_lock_personality.Size = New Size(112, 19)
        cbx_p2_lock_personality.TabIndex = 266
        cbx_p2_lock_personality.Text = "Lock Personality"
        cbx_p2_lock_personality.UseVisualStyleBackColor = True
        ' 
        ' cbx_p1_lock_personality
        ' 
        cbx_p1_lock_personality.AutoSize = True
        cbx_p1_lock_personality.Location = New Point(1312, 80)
        cbx_p1_lock_personality.Name = "cbx_p1_lock_personality"
        cbx_p1_lock_personality.Size = New Size(112, 19)
        cbx_p1_lock_personality.TabIndex = 265
        cbx_p1_lock_personality.Text = "Lock Personality"
        cbx_p1_lock_personality.UseVisualStyleBackColor = True
        ' 
        ' cbx_gaia_lock_personality
        ' 
        cbx_gaia_lock_personality.AutoSize = True
        cbx_gaia_lock_personality.Location = New Point(1312, 48)
        cbx_gaia_lock_personality.Name = "cbx_gaia_lock_personality"
        cbx_gaia_lock_personality.Size = New Size(112, 19)
        cbx_gaia_lock_personality.TabIndex = 264
        cbx_gaia_lock_personality.Text = "Lock Personality"
        cbx_gaia_lock_personality.UseVisualStyleBackColor = True
        ' 
        ' cbx_p8_lock_civ
        ' 
        cbx_p8_lock_civ.AutoSize = True
        cbx_p8_lock_civ.Location = New Point(1240, 304)
        cbx_p8_lock_civ.Name = "cbx_p8_lock_civ"
        cbx_p8_lock_civ.Size = New Size(71, 19)
        cbx_p8_lock_civ.TabIndex = 263
        cbx_p8_lock_civ.Text = "Lock Civ"
        cbx_p8_lock_civ.UseVisualStyleBackColor = True
        ' 
        ' cbx_p7_lock_civ
        ' 
        cbx_p7_lock_civ.AutoSize = True
        cbx_p7_lock_civ.Location = New Point(1240, 272)
        cbx_p7_lock_civ.Name = "cbx_p7_lock_civ"
        cbx_p7_lock_civ.Size = New Size(71, 19)
        cbx_p7_lock_civ.TabIndex = 262
        cbx_p7_lock_civ.Text = "Lock Civ"
        cbx_p7_lock_civ.UseVisualStyleBackColor = True
        ' 
        ' cbx_p6_lock_civ
        ' 
        cbx_p6_lock_civ.AutoSize = True
        cbx_p6_lock_civ.Location = New Point(1240, 240)
        cbx_p6_lock_civ.Name = "cbx_p6_lock_civ"
        cbx_p6_lock_civ.Size = New Size(71, 19)
        cbx_p6_lock_civ.TabIndex = 261
        cbx_p6_lock_civ.Text = "Lock Civ"
        cbx_p6_lock_civ.UseVisualStyleBackColor = True
        ' 
        ' cbx_p5_lock_civ
        ' 
        cbx_p5_lock_civ.AutoSize = True
        cbx_p5_lock_civ.Location = New Point(1240, 208)
        cbx_p5_lock_civ.Name = "cbx_p5_lock_civ"
        cbx_p5_lock_civ.Size = New Size(71, 19)
        cbx_p5_lock_civ.TabIndex = 260
        cbx_p5_lock_civ.Text = "Lock Civ"
        cbx_p5_lock_civ.UseVisualStyleBackColor = True
        ' 
        ' cbx_p4_lock_civ
        ' 
        cbx_p4_lock_civ.AutoSize = True
        cbx_p4_lock_civ.Location = New Point(1240, 176)
        cbx_p4_lock_civ.Name = "cbx_p4_lock_civ"
        cbx_p4_lock_civ.Size = New Size(71, 19)
        cbx_p4_lock_civ.TabIndex = 259
        cbx_p4_lock_civ.Text = "Lock Civ"
        cbx_p4_lock_civ.UseVisualStyleBackColor = True
        ' 
        ' cbx_p3_lock_civ
        ' 
        cbx_p3_lock_civ.AutoSize = True
        cbx_p3_lock_civ.Location = New Point(1240, 144)
        cbx_p3_lock_civ.Name = "cbx_p3_lock_civ"
        cbx_p3_lock_civ.Size = New Size(71, 19)
        cbx_p3_lock_civ.TabIndex = 258
        cbx_p3_lock_civ.Text = "Lock Civ"
        cbx_p3_lock_civ.UseVisualStyleBackColor = True
        ' 
        ' cbx_p2_lock_civ
        ' 
        cbx_p2_lock_civ.AutoSize = True
        cbx_p2_lock_civ.Location = New Point(1240, 112)
        cbx_p2_lock_civ.Name = "cbx_p2_lock_civ"
        cbx_p2_lock_civ.Size = New Size(71, 19)
        cbx_p2_lock_civ.TabIndex = 257
        cbx_p2_lock_civ.Text = "Lock Civ"
        cbx_p2_lock_civ.UseVisualStyleBackColor = True
        ' 
        ' cbx_p1_lock_civ
        ' 
        cbx_p1_lock_civ.AutoSize = True
        cbx_p1_lock_civ.Location = New Point(1240, 80)
        cbx_p1_lock_civ.Name = "cbx_p1_lock_civ"
        cbx_p1_lock_civ.Size = New Size(71, 19)
        cbx_p1_lock_civ.TabIndex = 256
        cbx_p1_lock_civ.Text = "Lock Civ"
        cbx_p1_lock_civ.UseVisualStyleBackColor = True
        ' 
        ' cbx_gaia_lock_civ
        ' 
        cbx_gaia_lock_civ.AutoSize = True
        cbx_gaia_lock_civ.Location = New Point(1240, 48)
        cbx_gaia_lock_civ.Name = "cbx_gaia_lock_civ"
        cbx_gaia_lock_civ.Size = New Size(71, 19)
        cbx_gaia_lock_civ.TabIndex = 255
        cbx_gaia_lock_civ.Text = "Lock Civ"
        cbx_gaia_lock_civ.UseVisualStyleBackColor = True
        ' 
        ' cbx_p8_architecture
        ' 
        cbx_p8_architecture.FormattingEnabled = True
        cbx_p8_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p8_architecture.Location = New Point(1128, 304)
        cbx_p8_architecture.Name = "cbx_p8_architecture"
        cbx_p8_architecture.Size = New Size(104, 23)
        cbx_p8_architecture.TabIndex = 254
        cbx_p8_architecture.Text = "Civilization"
        ' 
        ' cbx_p7_architecture
        ' 
        cbx_p7_architecture.FormattingEnabled = True
        cbx_p7_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p7_architecture.Location = New Point(1128, 272)
        cbx_p7_architecture.Name = "cbx_p7_architecture"
        cbx_p7_architecture.Size = New Size(104, 23)
        cbx_p7_architecture.TabIndex = 253
        cbx_p7_architecture.Text = "Civilization"
        ' 
        ' cbx_p6_architecture
        ' 
        cbx_p6_architecture.FormattingEnabled = True
        cbx_p6_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p6_architecture.Location = New Point(1128, 240)
        cbx_p6_architecture.Name = "cbx_p6_architecture"
        cbx_p6_architecture.Size = New Size(104, 23)
        cbx_p6_architecture.TabIndex = 252
        cbx_p6_architecture.Text = "Civilization"
        ' 
        ' cbx_p5_architecture
        ' 
        cbx_p5_architecture.FormattingEnabled = True
        cbx_p5_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p5_architecture.Location = New Point(1128, 208)
        cbx_p5_architecture.Name = "cbx_p5_architecture"
        cbx_p5_architecture.Size = New Size(104, 23)
        cbx_p5_architecture.TabIndex = 251
        cbx_p5_architecture.Text = "Civilization"
        ' 
        ' cbx_p4_architecture
        ' 
        cbx_p4_architecture.FormattingEnabled = True
        cbx_p4_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p4_architecture.Location = New Point(1128, 176)
        cbx_p4_architecture.Name = "cbx_p4_architecture"
        cbx_p4_architecture.Size = New Size(104, 23)
        cbx_p4_architecture.TabIndex = 250
        cbx_p4_architecture.Text = "Civilization"
        ' 
        ' cbx_p3_architecture
        ' 
        cbx_p3_architecture.FormattingEnabled = True
        cbx_p3_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p3_architecture.Location = New Point(1128, 144)
        cbx_p3_architecture.Name = "cbx_p3_architecture"
        cbx_p3_architecture.Size = New Size(104, 23)
        cbx_p3_architecture.TabIndex = 249
        cbx_p3_architecture.Text = "Civilization"
        ' 
        ' cbx_p2_architecture
        ' 
        cbx_p2_architecture.FormattingEnabled = True
        cbx_p2_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p2_architecture.Location = New Point(1128, 112)
        cbx_p2_architecture.Name = "cbx_p2_architecture"
        cbx_p2_architecture.Size = New Size(104, 23)
        cbx_p2_architecture.TabIndex = 248
        cbx_p2_architecture.Text = "Civilization"
        ' 
        ' cbx_p1_architecture
        ' 
        cbx_p1_architecture.FormattingEnabled = True
        cbx_p1_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p1_architecture.Location = New Point(1128, 80)
        cbx_p1_architecture.Name = "cbx_p1_architecture"
        cbx_p1_architecture.Size = New Size(104, 23)
        cbx_p1_architecture.TabIndex = 247
        cbx_p1_architecture.Text = "Civilization"
        ' 
        ' cbx_gaia_architecture
        ' 
        cbx_gaia_architecture.FormattingEnabled = True
        cbx_gaia_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_gaia_architecture.Location = New Point(1128, 48)
        cbx_gaia_architecture.Name = "cbx_gaia_architecture"
        cbx_gaia_architecture.Size = New Size(104, 23)
        cbx_gaia_architecture.TabIndex = 246
        cbx_gaia_architecture.Text = "Civilization"
        ' 
        ' lbl_architecture
        ' 
        lbl_architecture.AutoSize = True
        lbl_architecture.Location = New Point(1128, 16)
        lbl_architecture.Name = "lbl_architecture"
        lbl_architecture.Size = New Size(72, 15)
        lbl_architecture.TabIndex = 245
        lbl_architecture.Text = "Architecture"
        lbl_architecture.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_civilization
        ' 
        lbl_civilization.AutoSize = True
        lbl_civilization.Location = New Point(1016, 16)
        lbl_civilization.Name = "lbl_civilization"
        lbl_civilization.Size = New Size(65, 15)
        lbl_civilization.TabIndex = 244
        lbl_civilization.Text = "Civilization"
        lbl_civilization.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbx_p8_civilization
        ' 
        cbx_p8_civilization.FormattingEnabled = True
        cbx_p8_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p8_civilization.Location = New Point(1016, 304)
        cbx_p8_civilization.Name = "cbx_p8_civilization"
        cbx_p8_civilization.Size = New Size(104, 23)
        cbx_p8_civilization.TabIndex = 243
        cbx_p8_civilization.Text = "Civilization"
        ' 
        ' cbx_p7_civilization
        ' 
        cbx_p7_civilization.FormattingEnabled = True
        cbx_p7_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p7_civilization.Location = New Point(1016, 272)
        cbx_p7_civilization.Name = "cbx_p7_civilization"
        cbx_p7_civilization.Size = New Size(104, 23)
        cbx_p7_civilization.TabIndex = 242
        cbx_p7_civilization.Text = "Civilization"
        ' 
        ' cbx_p6_civilization
        ' 
        cbx_p6_civilization.FormattingEnabled = True
        cbx_p6_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p6_civilization.Location = New Point(1016, 240)
        cbx_p6_civilization.Name = "cbx_p6_civilization"
        cbx_p6_civilization.Size = New Size(104, 23)
        cbx_p6_civilization.TabIndex = 241
        cbx_p6_civilization.Text = "Civilization"
        ' 
        ' cbx_p5_civilization
        ' 
        cbx_p5_civilization.FormattingEnabled = True
        cbx_p5_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p5_civilization.Location = New Point(1016, 208)
        cbx_p5_civilization.Name = "cbx_p5_civilization"
        cbx_p5_civilization.Size = New Size(104, 23)
        cbx_p5_civilization.TabIndex = 240
        cbx_p5_civilization.Text = "Civilization"
        ' 
        ' cbx_p4_civilization
        ' 
        cbx_p4_civilization.FormattingEnabled = True
        cbx_p4_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p4_civilization.Location = New Point(1016, 176)
        cbx_p4_civilization.Name = "cbx_p4_civilization"
        cbx_p4_civilization.Size = New Size(104, 23)
        cbx_p4_civilization.TabIndex = 239
        cbx_p4_civilization.Text = "Civilization"
        ' 
        ' cbx_p3_civilization
        ' 
        cbx_p3_civilization.FormattingEnabled = True
        cbx_p3_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p3_civilization.Location = New Point(1016, 144)
        cbx_p3_civilization.Name = "cbx_p3_civilization"
        cbx_p3_civilization.Size = New Size(104, 23)
        cbx_p3_civilization.TabIndex = 238
        cbx_p3_civilization.Text = "Civilization"
        ' 
        ' cbx_p2_civilization
        ' 
        cbx_p2_civilization.FormattingEnabled = True
        cbx_p2_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p2_civilization.Location = New Point(1016, 112)
        cbx_p2_civilization.Name = "cbx_p2_civilization"
        cbx_p2_civilization.Size = New Size(104, 23)
        cbx_p2_civilization.TabIndex = 237
        cbx_p2_civilization.Text = "Civilization"
        ' 
        ' cbx_p1_civilization
        ' 
        cbx_p1_civilization.FormattingEnabled = True
        cbx_p1_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p1_civilization.Location = New Point(1016, 80)
        cbx_p1_civilization.Name = "cbx_p1_civilization"
        cbx_p1_civilization.Size = New Size(104, 23)
        cbx_p1_civilization.TabIndex = 236
        cbx_p1_civilization.Text = "Civilization"
        ' 
        ' cbx_gaia_civilization
        ' 
        cbx_gaia_civilization.FormattingEnabled = True
        cbx_gaia_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_gaia_civilization.Location = New Point(1016, 48)
        cbx_gaia_civilization.Name = "cbx_gaia_civilization"
        cbx_gaia_civilization.Size = New Size(104, 23)
        cbx_gaia_civilization.TabIndex = 235
        cbx_gaia_civilization.Text = "Civilization"
        ' 
        ' lbl_ai_personality
        ' 
        lbl_ai_personality.AutoSize = True
        lbl_ai_personality.Location = New Point(896, 16)
        lbl_ai_personality.Name = "lbl_ai_personality"
        lbl_ai_personality.Size = New Size(79, 15)
        lbl_ai_personality.TabIndex = 234
        lbl_ai_personality.Text = "AI Personality"
        lbl_ai_personality.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbx_p8_ai_personality
        ' 
        cbx_p8_ai_personality.FormattingEnabled = True
        cbx_p8_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p8_ai_personality.Location = New Point(896, 304)
        cbx_p8_ai_personality.Name = "cbx_p8_ai_personality"
        cbx_p8_ai_personality.Size = New Size(112, 23)
        cbx_p8_ai_personality.TabIndex = 233
        cbx_p8_ai_personality.Text = "AI Personality"
        ' 
        ' cbx_p7_ai_personality
        ' 
        cbx_p7_ai_personality.FormattingEnabled = True
        cbx_p7_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p7_ai_personality.Location = New Point(896, 272)
        cbx_p7_ai_personality.Name = "cbx_p7_ai_personality"
        cbx_p7_ai_personality.Size = New Size(112, 23)
        cbx_p7_ai_personality.TabIndex = 232
        cbx_p7_ai_personality.Text = "AI Personality"
        ' 
        ' cbx_p6_ai_personality
        ' 
        cbx_p6_ai_personality.FormattingEnabled = True
        cbx_p6_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p6_ai_personality.Location = New Point(896, 240)
        cbx_p6_ai_personality.Name = "cbx_p6_ai_personality"
        cbx_p6_ai_personality.Size = New Size(112, 23)
        cbx_p6_ai_personality.TabIndex = 231
        cbx_p6_ai_personality.Text = "AI Personality"
        ' 
        ' cbx_p5_ai_personality
        ' 
        cbx_p5_ai_personality.FormattingEnabled = True
        cbx_p5_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p5_ai_personality.Location = New Point(896, 208)
        cbx_p5_ai_personality.Name = "cbx_p5_ai_personality"
        cbx_p5_ai_personality.Size = New Size(112, 23)
        cbx_p5_ai_personality.TabIndex = 230
        cbx_p5_ai_personality.Text = "AI Personality"
        ' 
        ' cbx_p4_ai_personality
        ' 
        cbx_p4_ai_personality.FormattingEnabled = True
        cbx_p4_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p4_ai_personality.Location = New Point(896, 176)
        cbx_p4_ai_personality.Name = "cbx_p4_ai_personality"
        cbx_p4_ai_personality.Size = New Size(112, 23)
        cbx_p4_ai_personality.TabIndex = 229
        cbx_p4_ai_personality.Text = "AI Personality"
        ' 
        ' cbx_p3_ai_personality
        ' 
        cbx_p3_ai_personality.FormattingEnabled = True
        cbx_p3_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p3_ai_personality.Location = New Point(896, 144)
        cbx_p3_ai_personality.Name = "cbx_p3_ai_personality"
        cbx_p3_ai_personality.Size = New Size(112, 23)
        cbx_p3_ai_personality.TabIndex = 228
        cbx_p3_ai_personality.Text = "AI Personality"
        ' 
        ' cbx_p2_ai_personality
        ' 
        cbx_p2_ai_personality.FormattingEnabled = True
        cbx_p2_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p2_ai_personality.Location = New Point(896, 112)
        cbx_p2_ai_personality.Name = "cbx_p2_ai_personality"
        cbx_p2_ai_personality.Size = New Size(112, 23)
        cbx_p2_ai_personality.TabIndex = 227
        cbx_p2_ai_personality.Text = "AI Personality"
        ' 
        ' cbx_gaia_ai_personality
        ' 
        cbx_gaia_ai_personality.FormattingEnabled = True
        cbx_gaia_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_gaia_ai_personality.Location = New Point(896, 48)
        cbx_gaia_ai_personality.Name = "cbx_gaia_ai_personality"
        cbx_gaia_ai_personality.Size = New Size(112, 23)
        cbx_gaia_ai_personality.TabIndex = 226
        cbx_gaia_ai_personality.Text = "AI Personality"
        ' 
        ' cbx_p1_ai_personality
        ' 
        cbx_p1_ai_personality.FormattingEnabled = True
        cbx_p1_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p1_ai_personality.Location = New Point(896, 80)
        cbx_p1_ai_personality.Name = "cbx_p1_ai_personality"
        cbx_p1_ai_personality.Size = New Size(112, 23)
        cbx_p1_ai_personality.TabIndex = 225
        cbx_p1_ai_personality.Text = "AI Personality"
        ' 
        ' cbx_gaia_age
        ' 
        cbx_gaia_age.FormattingEnabled = True
        cbx_gaia_age.Location = New Point(104, 48)
        cbx_gaia_age.Name = "cbx_gaia_age"
        cbx_gaia_age.Size = New Size(100, 23)
        cbx_gaia_age.TabIndex = 224
        cbx_gaia_age.Text = "Starting Age"
        ' 
        ' lbl_age
        ' 
        lbl_age.AutoSize = True
        lbl_age.Location = New Point(104, 16)
        lbl_age.Name = "lbl_age"
        lbl_age.Size = New Size(72, 15)
        lbl_age.TabIndex = 223
        lbl_age.Text = "Starting Age"
        lbl_age.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbx_p8_age
        ' 
        cbx_p8_age.FormattingEnabled = True
        cbx_p8_age.Location = New Point(104, 304)
        cbx_p8_age.Name = "cbx_p8_age"
        cbx_p8_age.Size = New Size(100, 23)
        cbx_p8_age.TabIndex = 222
        cbx_p8_age.Text = "Starting Age"
        ' 
        ' cbx_p7_age
        ' 
        cbx_p7_age.FormattingEnabled = True
        cbx_p7_age.Location = New Point(104, 272)
        cbx_p7_age.Name = "cbx_p7_age"
        cbx_p7_age.Size = New Size(100, 23)
        cbx_p7_age.TabIndex = 221
        cbx_p7_age.Text = "Starting Age"
        ' 
        ' cbx_p6_age
        ' 
        cbx_p6_age.FormattingEnabled = True
        cbx_p6_age.Location = New Point(104, 240)
        cbx_p6_age.Name = "cbx_p6_age"
        cbx_p6_age.Size = New Size(100, 23)
        cbx_p6_age.TabIndex = 220
        cbx_p6_age.Text = "Starting Age"
        ' 
        ' cbx_p5_age
        ' 
        cbx_p5_age.FormattingEnabled = True
        cbx_p5_age.Location = New Point(104, 208)
        cbx_p5_age.Name = "cbx_p5_age"
        cbx_p5_age.Size = New Size(100, 23)
        cbx_p5_age.TabIndex = 219
        cbx_p5_age.Text = "Starting Age"
        ' 
        ' cbx_p4_age
        ' 
        cbx_p4_age.FormattingEnabled = True
        cbx_p4_age.Location = New Point(104, 176)
        cbx_p4_age.Name = "cbx_p4_age"
        cbx_p4_age.Size = New Size(100, 23)
        cbx_p4_age.TabIndex = 218
        cbx_p4_age.Text = "Starting Age"
        ' 
        ' cbx_p3_age
        ' 
        cbx_p3_age.FormattingEnabled = True
        cbx_p3_age.Location = New Point(104, 144)
        cbx_p3_age.Name = "cbx_p3_age"
        cbx_p3_age.Size = New Size(100, 23)
        cbx_p3_age.TabIndex = 217
        cbx_p3_age.Text = "Starting Age"
        ' 
        ' cbx_p2_age
        ' 
        cbx_p2_age.FormattingEnabled = True
        cbx_p2_age.Location = New Point(104, 112)
        cbx_p2_age.Name = "cbx_p2_age"
        cbx_p2_age.Size = New Size(100, 23)
        cbx_p2_age.TabIndex = 216
        cbx_p2_age.Text = "Starting Age"
        ' 
        ' cbx_p1_age
        ' 
        cbx_p1_age.FormattingEnabled = True
        cbx_p1_age.Location = New Point(104, 80)
        cbx_p1_age.Name = "cbx_p1_age"
        cbx_p1_age.Size = New Size(100, 23)
        cbx_p1_age.TabIndex = 215
        cbx_p1_age.Text = "Starting Age"
        ' 
        ' lbl_player_type
        ' 
        lbl_player_type.AutoSize = True
        lbl_player_type.Location = New Point(856, 16)
        lbl_player_type.Name = "lbl_player_type"
        lbl_player_type.Size = New Size(34, 15)
        lbl_player_type.TabIndex = 214
        lbl_player_type.Text = "Is AI?"
        lbl_player_type.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbx_p8_ai
        ' 
        cbx_p8_ai.AutoSize = True
        cbx_p8_ai.Location = New Point(856, 304)
        cbx_p8_ai.Name = "cbx_p8_ai"
        cbx_p8_ai.Size = New Size(37, 19)
        cbx_p8_ai.TabIndex = 213
        cbx_p8_ai.Text = "AI"
        cbx_p8_ai.UseVisualStyleBackColor = True
        ' 
        ' cbx_p7_ai
        ' 
        cbx_p7_ai.AutoSize = True
        cbx_p7_ai.Location = New Point(856, 272)
        cbx_p7_ai.Name = "cbx_p7_ai"
        cbx_p7_ai.Size = New Size(37, 19)
        cbx_p7_ai.TabIndex = 212
        cbx_p7_ai.Text = "AI"
        cbx_p7_ai.UseVisualStyleBackColor = True
        ' 
        ' cbx_p6_ai
        ' 
        cbx_p6_ai.AutoSize = True
        cbx_p6_ai.Location = New Point(856, 240)
        cbx_p6_ai.Name = "cbx_p6_ai"
        cbx_p6_ai.Size = New Size(37, 19)
        cbx_p6_ai.TabIndex = 211
        cbx_p6_ai.Text = "AI"
        cbx_p6_ai.UseVisualStyleBackColor = True
        ' 
        ' cbx_p5_ai
        ' 
        cbx_p5_ai.AutoSize = True
        cbx_p5_ai.Location = New Point(856, 208)
        cbx_p5_ai.Name = "cbx_p5_ai"
        cbx_p5_ai.Size = New Size(37, 19)
        cbx_p5_ai.TabIndex = 210
        cbx_p5_ai.Text = "AI"
        cbx_p5_ai.UseVisualStyleBackColor = True
        ' 
        ' cbx_p4_ai
        ' 
        cbx_p4_ai.AutoSize = True
        cbx_p4_ai.Location = New Point(856, 176)
        cbx_p4_ai.Name = "cbx_p4_ai"
        cbx_p4_ai.Size = New Size(37, 19)
        cbx_p4_ai.TabIndex = 209
        cbx_p4_ai.Text = "AI"
        cbx_p4_ai.UseVisualStyleBackColor = True
        ' 
        ' cbx_p3_ai
        ' 
        cbx_p3_ai.AutoSize = True
        cbx_p3_ai.Location = New Point(856, 144)
        cbx_p3_ai.Name = "cbx_p3_ai"
        cbx_p3_ai.Size = New Size(37, 19)
        cbx_p3_ai.TabIndex = 208
        cbx_p3_ai.Text = "AI"
        cbx_p3_ai.UseVisualStyleBackColor = True
        ' 
        ' cbx_p2_ai
        ' 
        cbx_p2_ai.AutoSize = True
        cbx_p2_ai.Location = New Point(856, 112)
        cbx_p2_ai.Name = "cbx_p2_ai"
        cbx_p2_ai.Size = New Size(37, 19)
        cbx_p2_ai.TabIndex = 207
        cbx_p2_ai.Text = "AI"
        cbx_p2_ai.UseVisualStyleBackColor = True
        ' 
        ' cbx_p1_ai
        ' 
        cbx_p1_ai.AutoSize = True
        cbx_p1_ai.Location = New Point(856, 80)
        cbx_p1_ai.Name = "cbx_p1_ai"
        cbx_p1_ai.Size = New Size(37, 19)
        cbx_p1_ai.TabIndex = 206
        cbx_p1_ai.Text = "AI"
        cbx_p1_ai.UseVisualStyleBackColor = True
        ' 
        ' cbx_gaia_ai
        ' 
        cbx_gaia_ai.AutoSize = True
        cbx_gaia_ai.Location = New Point(856, 48)
        cbx_gaia_ai.Name = "cbx_gaia_ai"
        cbx_gaia_ai.Size = New Size(37, 19)
        cbx_gaia_ai.TabIndex = 205
        cbx_gaia_ai.Text = "AI"
        cbx_gaia_ai.UseVisualStyleBackColor = True
        ' 
        ' lb_name_string_id
        ' 
        lb_name_string_id.AutoSize = True
        lb_name_string_id.Location = New Point(752, 16)
        lb_name_string_id.Name = "lb_name_string_id"
        lb_name_string_id.Size = New Size(52, 15)
        lb_name_string_id.TabIndex = 204
        lb_name_string_id.Text = "String ID"
        lb_name_string_id.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbx_p8_name_string_id
        ' 
        tbx_p8_name_string_id.Location = New Point(752, 304)
        tbx_p8_name_string_id.MaxLength = 10
        tbx_p8_name_string_id.Name = "tbx_p8_name_string_id"
        tbx_p8_name_string_id.Size = New Size(100, 23)
        tbx_p8_name_string_id.TabIndex = 199
        ' 
        ' tbx_p7_name_string_id
        ' 
        tbx_p7_name_string_id.Location = New Point(752, 272)
        tbx_p7_name_string_id.MaxLength = 10
        tbx_p7_name_string_id.Name = "tbx_p7_name_string_id"
        tbx_p7_name_string_id.Size = New Size(100, 23)
        tbx_p7_name_string_id.TabIndex = 200
        ' 
        ' tbx_p6_name_string_id
        ' 
        tbx_p6_name_string_id.Location = New Point(752, 240)
        tbx_p6_name_string_id.MaxLength = 10
        tbx_p6_name_string_id.Name = "tbx_p6_name_string_id"
        tbx_p6_name_string_id.Size = New Size(100, 23)
        tbx_p6_name_string_id.TabIndex = 201
        ' 
        ' tbx_p5_name_string_id
        ' 
        tbx_p5_name_string_id.Location = New Point(752, 208)
        tbx_p5_name_string_id.MaxLength = 10
        tbx_p5_name_string_id.Name = "tbx_p5_name_string_id"
        tbx_p5_name_string_id.Size = New Size(100, 23)
        tbx_p5_name_string_id.TabIndex = 203
        ' 
        ' tbx_p4_name_string_id
        ' 
        tbx_p4_name_string_id.Location = New Point(752, 176)
        tbx_p4_name_string_id.MaxLength = 10
        tbx_p4_name_string_id.Name = "tbx_p4_name_string_id"
        tbx_p4_name_string_id.Size = New Size(100, 23)
        tbx_p4_name_string_id.TabIndex = 202
        ' 
        ' tbx_p3_name_string_id
        ' 
        tbx_p3_name_string_id.Location = New Point(752, 144)
        tbx_p3_name_string_id.MaxLength = 10
        tbx_p3_name_string_id.Name = "tbx_p3_name_string_id"
        tbx_p3_name_string_id.Size = New Size(100, 23)
        tbx_p3_name_string_id.TabIndex = 198
        ' 
        ' tbx_p2_name_string_id
        ' 
        tbx_p2_name_string_id.Location = New Point(752, 112)
        tbx_p2_name_string_id.MaxLength = 10
        tbx_p2_name_string_id.Name = "tbx_p2_name_string_id"
        tbx_p2_name_string_id.Size = New Size(100, 23)
        tbx_p2_name_string_id.TabIndex = 197
        ' 
        ' tbx_p1_name_string_id
        ' 
        tbx_p1_name_string_id.Location = New Point(752, 80)
        tbx_p1_name_string_id.MaxLength = 10
        tbx_p1_name_string_id.Name = "tbx_p1_name_string_id"
        tbx_p1_name_string_id.Size = New Size(100, 23)
        tbx_p1_name_string_id.TabIndex = 196
        ' 
        ' tbx_gaia_name_string_id
        ' 
        tbx_gaia_name_string_id.Location = New Point(752, 48)
        tbx_gaia_name_string_id.MaxLength = 10
        tbx_gaia_name_string_id.Name = "tbx_gaia_name_string_id"
        tbx_gaia_name_string_id.Size = New Size(100, 23)
        tbx_gaia_name_string_id.TabIndex = 195
        ' 
        ' lb_tribe_name
        ' 
        lb_tribe_name.AutoSize = True
        lb_tribe_name.Location = New Point(648, 16)
        lb_tribe_name.Name = "lb_tribe_name"
        lb_tribe_name.Size = New Size(67, 15)
        lb_tribe_name.TabIndex = 194
        lb_tribe_name.Text = "Tribe Name"
        lb_tribe_name.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbx_p8_tribe_name
        ' 
        tbx_p8_tribe_name.Location = New Point(648, 304)
        tbx_p8_tribe_name.MaxLength = 28
        tbx_p8_tribe_name.Name = "tbx_p8_tribe_name"
        tbx_p8_tribe_name.Size = New Size(100, 23)
        tbx_p8_tribe_name.TabIndex = 192
        ' 
        ' tbx_p7_tribe_name
        ' 
        tbx_p7_tribe_name.Location = New Point(648, 272)
        tbx_p7_tribe_name.MaxLength = 28
        tbx_p7_tribe_name.Name = "tbx_p7_tribe_name"
        tbx_p7_tribe_name.Size = New Size(100, 23)
        tbx_p7_tribe_name.TabIndex = 191
        ' 
        ' tbx_p6_tribe_name
        ' 
        tbx_p6_tribe_name.Location = New Point(648, 240)
        tbx_p6_tribe_name.MaxLength = 28
        tbx_p6_tribe_name.Name = "tbx_p6_tribe_name"
        tbx_p6_tribe_name.Size = New Size(100, 23)
        tbx_p6_tribe_name.TabIndex = 190
        ' 
        ' tbx_p5_tribe_name
        ' 
        tbx_p5_tribe_name.Location = New Point(648, 208)
        tbx_p5_tribe_name.MaxLength = 28
        tbx_p5_tribe_name.Name = "tbx_p5_tribe_name"
        tbx_p5_tribe_name.Size = New Size(100, 23)
        tbx_p5_tribe_name.TabIndex = 193
        ' 
        ' tbx_p4_tribe_name
        ' 
        tbx_p4_tribe_name.Location = New Point(648, 176)
        tbx_p4_tribe_name.MaxLength = 28
        tbx_p4_tribe_name.Name = "tbx_p4_tribe_name"
        tbx_p4_tribe_name.Size = New Size(100, 23)
        tbx_p4_tribe_name.TabIndex = 189
        ' 
        ' tbx_p3_tribe_name
        ' 
        tbx_p3_tribe_name.Location = New Point(648, 144)
        tbx_p3_tribe_name.MaxLength = 28
        tbx_p3_tribe_name.Name = "tbx_p3_tribe_name"
        tbx_p3_tribe_name.Size = New Size(100, 23)
        tbx_p3_tribe_name.TabIndex = 188
        ' 
        ' tbx_p2_tribe_name
        ' 
        tbx_p2_tribe_name.Location = New Point(648, 112)
        tbx_p2_tribe_name.MaxLength = 28
        tbx_p2_tribe_name.Name = "tbx_p2_tribe_name"
        tbx_p2_tribe_name.Size = New Size(100, 23)
        tbx_p2_tribe_name.TabIndex = 187
        ' 
        ' tbx_p1_tribe_name
        ' 
        tbx_p1_tribe_name.Location = New Point(648, 80)
        tbx_p1_tribe_name.MaxLength = 28
        tbx_p1_tribe_name.Name = "tbx_p1_tribe_name"
        tbx_p1_tribe_name.Size = New Size(100, 23)
        tbx_p1_tribe_name.TabIndex = 186
        ' 
        ' tbx_gaia_tribe_name
        ' 
        tbx_gaia_tribe_name.Location = New Point(648, 48)
        tbx_gaia_tribe_name.MaxLength = 28
        tbx_gaia_tribe_name.Name = "tbx_gaia_tribe_name"
        tbx_gaia_tribe_name.Size = New Size(100, 23)
        tbx_gaia_tribe_name.TabIndex = 185
        ' 
        ' cbx_p8_color
        ' 
        cbx_p8_color.FormattingEnabled = True
        cbx_p8_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p8_color.Location = New Point(568, 304)
        cbx_p8_color.Name = "cbx_p8_color"
        cbx_p8_color.Size = New Size(75, 23)
        cbx_p8_color.TabIndex = 184
        cbx_p8_color.Text = "Color"
        ' 
        ' cbx_p7_color
        ' 
        cbx_p7_color.FormattingEnabled = True
        cbx_p7_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p7_color.Location = New Point(568, 272)
        cbx_p7_color.Name = "cbx_p7_color"
        cbx_p7_color.Size = New Size(75, 23)
        cbx_p7_color.TabIndex = 183
        cbx_p7_color.Text = "Color"
        ' 
        ' cbx_p6_color
        ' 
        cbx_p6_color.FormattingEnabled = True
        cbx_p6_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p6_color.Location = New Point(568, 240)
        cbx_p6_color.Name = "cbx_p6_color"
        cbx_p6_color.Size = New Size(75, 23)
        cbx_p6_color.TabIndex = 182
        cbx_p6_color.Text = "Color"
        ' 
        ' cbx_p5_color
        ' 
        cbx_p5_color.FormattingEnabled = True
        cbx_p5_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p5_color.Location = New Point(568, 208)
        cbx_p5_color.Name = "cbx_p5_color"
        cbx_p5_color.Size = New Size(75, 23)
        cbx_p5_color.TabIndex = 181
        cbx_p5_color.Text = "Color"
        ' 
        ' cbx_p4_color
        ' 
        cbx_p4_color.FormattingEnabled = True
        cbx_p4_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p4_color.Location = New Point(568, 176)
        cbx_p4_color.Name = "cbx_p4_color"
        cbx_p4_color.Size = New Size(75, 23)
        cbx_p4_color.TabIndex = 180
        cbx_p4_color.Text = "Color"
        ' 
        ' cbx_p3_color
        ' 
        cbx_p3_color.FormattingEnabled = True
        cbx_p3_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p3_color.Location = New Point(568, 144)
        cbx_p3_color.Name = "cbx_p3_color"
        cbx_p3_color.Size = New Size(75, 23)
        cbx_p3_color.TabIndex = 179
        cbx_p3_color.Text = "Color"
        ' 
        ' cbx_p2_color
        ' 
        cbx_p2_color.FormattingEnabled = True
        cbx_p2_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p2_color.Location = New Point(568, 112)
        cbx_p2_color.Name = "cbx_p2_color"
        cbx_p2_color.Size = New Size(75, 23)
        cbx_p2_color.TabIndex = 178
        cbx_p2_color.Text = "Color"
        ' 
        ' cbx_p1_color
        ' 
        cbx_p1_color.FormattingEnabled = True
        cbx_p1_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p1_color.Location = New Point(568, 80)
        cbx_p1_color.Name = "cbx_p1_color"
        cbx_p1_color.Size = New Size(75, 23)
        cbx_p1_color.TabIndex = 177
        cbx_p1_color.Text = "Color"
        ' 
        ' lb_color
        ' 
        lb_color.AutoSize = True
        lb_color.Location = New Point(568, 16)
        lb_color.Name = "lb_color"
        lb_color.Size = New Size(36, 15)
        lb_color.TabIndex = 176
        lb_color.Text = "Color"
        lb_color.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbx_gaia_color
        ' 
        cbx_gaia_color.FormattingEnabled = True
        cbx_gaia_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_gaia_color.Location = New Point(568, 48)
        cbx_gaia_color.Name = "cbx_gaia_color"
        cbx_gaia_color.Size = New Size(75, 23)
        cbx_gaia_color.TabIndex = 175
        cbx_gaia_color.Text = "Color"
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
        ' nud_p8_priority
        ' 
        nud_p8_priority.Location = New Point(528, 304)
        nud_p8_priority.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_p8_priority.Name = "nud_p8_priority"
        nud_p8_priority.Size = New Size(32, 23)
        nud_p8_priority.TabIndex = 165
        nud_p8_priority.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_p7_priority
        ' 
        nud_p7_priority.Location = New Point(528, 272)
        nud_p7_priority.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_p7_priority.Name = "nud_p7_priority"
        nud_p7_priority.Size = New Size(32, 23)
        nud_p7_priority.TabIndex = 164
        nud_p7_priority.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_p6_priority
        ' 
        nud_p6_priority.Location = New Point(528, 240)
        nud_p6_priority.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_p6_priority.Name = "nud_p6_priority"
        nud_p6_priority.Size = New Size(32, 23)
        nud_p6_priority.TabIndex = 163
        nud_p6_priority.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_p5_priority
        ' 
        nud_p5_priority.Location = New Point(528, 208)
        nud_p5_priority.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_p5_priority.Name = "nud_p5_priority"
        nud_p5_priority.Size = New Size(32, 23)
        nud_p5_priority.TabIndex = 162
        nud_p5_priority.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_p4_priority
        ' 
        nud_p4_priority.Location = New Point(528, 176)
        nud_p4_priority.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_p4_priority.Name = "nud_p4_priority"
        nud_p4_priority.Size = New Size(32, 23)
        nud_p4_priority.TabIndex = 161
        nud_p4_priority.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_p3_priority
        ' 
        nud_p3_priority.Location = New Point(528, 144)
        nud_p3_priority.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_p3_priority.Name = "nud_p3_priority"
        nud_p3_priority.Size = New Size(32, 23)
        nud_p3_priority.TabIndex = 160
        nud_p3_priority.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_p2_priority
        ' 
        nud_p2_priority.Location = New Point(528, 112)
        nud_p2_priority.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_p2_priority.Name = "nud_p2_priority"
        nud_p2_priority.Size = New Size(32, 23)
        nud_p2_priority.TabIndex = 159
        nud_p2_priority.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_p1_priority
        ' 
        nud_p1_priority.Location = New Point(528, 80)
        nud_p1_priority.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_p1_priority.Name = "nud_p1_priority"
        nud_p1_priority.Size = New Size(32, 23)
        nud_p1_priority.TabIndex = 158
        nud_p1_priority.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' nud_gaia_priority
        ' 
        nud_gaia_priority.Enabled = False
        nud_gaia_priority.Location = New Point(528, 48)
        nud_gaia_priority.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        nud_gaia_priority.Name = "nud_gaia_priority"
        nud_gaia_priority.Size = New Size(32, 23)
        nud_gaia_priority.TabIndex = 157
        nud_gaia_priority.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' lb_priority_gaia
        ' 
        lb_priority_gaia.AutoSize = True
        lb_priority_gaia.Location = New Point(520, 16)
        lb_priority_gaia.Name = "lb_priority_gaia"
        lb_priority_gaia.Size = New Size(45, 15)
        lb_priority_gaia.TabIndex = 156
        lb_priority_gaia.Text = "Priority"
        lb_priority_gaia.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_gaia_population
        ' 
        nud_gaia_population.Location = New Point(464, 48)
        nud_gaia_population.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gaia_population.Name = "nud_gaia_population"
        nud_gaia_population.Size = New Size(55, 23)
        nud_gaia_population.TabIndex = 155
        nud_gaia_population.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p8_population
        ' 
        nud_p8_population.Location = New Point(464, 304)
        nud_p8_population.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p8_population.Name = "nud_p8_population"
        nud_p8_population.Size = New Size(55, 23)
        nud_p8_population.TabIndex = 154
        nud_p8_population.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p7_population
        ' 
        nud_p7_population.Location = New Point(464, 272)
        nud_p7_population.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p7_population.Name = "nud_p7_population"
        nud_p7_population.Size = New Size(55, 23)
        nud_p7_population.TabIndex = 153
        nud_p7_population.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p6_population
        ' 
        nud_p6_population.Location = New Point(464, 240)
        nud_p6_population.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p6_population.Name = "nud_p6_population"
        nud_p6_population.Size = New Size(55, 23)
        nud_p6_population.TabIndex = 152
        nud_p6_population.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p5_population
        ' 
        nud_p5_population.Location = New Point(464, 208)
        nud_p5_population.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p5_population.Name = "nud_p5_population"
        nud_p5_population.Size = New Size(55, 23)
        nud_p5_population.TabIndex = 151
        nud_p5_population.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p4_population
        ' 
        nud_p4_population.Location = New Point(464, 176)
        nud_p4_population.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p4_population.Name = "nud_p4_population"
        nud_p4_population.Size = New Size(55, 23)
        nud_p4_population.TabIndex = 150
        nud_p4_population.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p3_population
        ' 
        nud_p3_population.Location = New Point(464, 144)
        nud_p3_population.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p3_population.Name = "nud_p3_population"
        nud_p3_population.Size = New Size(55, 23)
        nud_p3_population.TabIndex = 149
        nud_p3_population.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p2_population
        ' 
        nud_p2_population.Location = New Point(464, 112)
        nud_p2_population.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p2_population.Name = "nud_p2_population"
        nud_p2_population.Size = New Size(55, 23)
        nud_p2_population.TabIndex = 148
        nud_p2_population.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_pop
        ' 
        lb_pop.AutoSize = True
        lb_pop.Location = New Point(464, 16)
        lb_pop.Name = "lb_pop"
        lb_pop.Size = New Size(28, 15)
        lb_pop.TabIndex = 147
        lb_pop.Text = "Pop"
        lb_pop.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_p1_population
        ' 
        nud_p1_population.Location = New Point(464, 80)
        nud_p1_population.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p1_population.Name = "nud_p1_population"
        nud_p1_population.Size = New Size(55, 23)
        nud_p1_population.TabIndex = 146
        nud_p1_population.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gaia_gold
        ' 
        nud_gaia_gold.Location = New Point(400, 48)
        nud_gaia_gold.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gaia_gold.Name = "nud_gaia_gold"
        nud_gaia_gold.Size = New Size(55, 23)
        nud_gaia_gold.TabIndex = 145
        nud_gaia_gold.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p8_gold
        ' 
        nud_p8_gold.Location = New Point(400, 304)
        nud_p8_gold.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p8_gold.Name = "nud_p8_gold"
        nud_p8_gold.Size = New Size(55, 23)
        nud_p8_gold.TabIndex = 144
        nud_p8_gold.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p7_gold
        ' 
        nud_p7_gold.Location = New Point(400, 272)
        nud_p7_gold.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p7_gold.Name = "nud_p7_gold"
        nud_p7_gold.Size = New Size(55, 23)
        nud_p7_gold.TabIndex = 143
        nud_p7_gold.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p6_gold
        ' 
        nud_p6_gold.Location = New Point(400, 240)
        nud_p6_gold.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p6_gold.Name = "nud_p6_gold"
        nud_p6_gold.Size = New Size(55, 23)
        nud_p6_gold.TabIndex = 142
        nud_p6_gold.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p5_gold
        ' 
        nud_p5_gold.Location = New Point(400, 208)
        nud_p5_gold.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p5_gold.Name = "nud_p5_gold"
        nud_p5_gold.Size = New Size(55, 23)
        nud_p5_gold.TabIndex = 141
        nud_p5_gold.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p4_gold
        ' 
        nud_p4_gold.Location = New Point(400, 176)
        nud_p4_gold.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p4_gold.Name = "nud_p4_gold"
        nud_p4_gold.Size = New Size(55, 23)
        nud_p4_gold.TabIndex = 140
        nud_p4_gold.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p3_gold
        ' 
        nud_p3_gold.Location = New Point(400, 144)
        nud_p3_gold.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p3_gold.Name = "nud_p3_gold"
        nud_p3_gold.Size = New Size(55, 23)
        nud_p3_gold.TabIndex = 139
        nud_p3_gold.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p2_gold
        ' 
        nud_p2_gold.Location = New Point(400, 112)
        nud_p2_gold.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p2_gold.Name = "nud_p2_gold"
        nud_p2_gold.Size = New Size(55, 23)
        nud_p2_gold.TabIndex = 138
        nud_p2_gold.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_gold
        ' 
        lb_gold.AutoSize = True
        lb_gold.Location = New Point(400, 16)
        lb_gold.Name = "lb_gold"
        lb_gold.Size = New Size(32, 15)
        lb_gold.TabIndex = 137
        lb_gold.Text = "Gold"
        lb_gold.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_p1_gold
        ' 
        nud_p1_gold.Location = New Point(400, 80)
        nud_p1_gold.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p1_gold.Name = "nud_p1_gold"
        nud_p1_gold.Size = New Size(55, 23)
        nud_p1_gold.TabIndex = 136
        nud_p1_gold.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gaia_stone
        ' 
        nud_gaia_stone.Location = New Point(336, 48)
        nud_gaia_stone.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gaia_stone.Name = "nud_gaia_stone"
        nud_gaia_stone.Size = New Size(55, 23)
        nud_gaia_stone.TabIndex = 135
        nud_gaia_stone.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p8_stone
        ' 
        nud_p8_stone.Location = New Point(336, 304)
        nud_p8_stone.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p8_stone.Name = "nud_p8_stone"
        nud_p8_stone.Size = New Size(55, 23)
        nud_p8_stone.TabIndex = 134
        nud_p8_stone.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p7_stone
        ' 
        nud_p7_stone.Location = New Point(336, 272)
        nud_p7_stone.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p7_stone.Name = "nud_p7_stone"
        nud_p7_stone.Size = New Size(55, 23)
        nud_p7_stone.TabIndex = 133
        nud_p7_stone.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p6_stone
        ' 
        nud_p6_stone.Location = New Point(336, 240)
        nud_p6_stone.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p6_stone.Name = "nud_p6_stone"
        nud_p6_stone.Size = New Size(55, 23)
        nud_p6_stone.TabIndex = 132
        nud_p6_stone.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p5_stone
        ' 
        nud_p5_stone.Location = New Point(336, 208)
        nud_p5_stone.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p5_stone.Name = "nud_p5_stone"
        nud_p5_stone.Size = New Size(55, 23)
        nud_p5_stone.TabIndex = 131
        nud_p5_stone.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p4_stone
        ' 
        nud_p4_stone.Location = New Point(336, 176)
        nud_p4_stone.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p4_stone.Name = "nud_p4_stone"
        nud_p4_stone.Size = New Size(55, 23)
        nud_p4_stone.TabIndex = 130
        nud_p4_stone.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p3_stone
        ' 
        nud_p3_stone.Location = New Point(336, 144)
        nud_p3_stone.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p3_stone.Name = "nud_p3_stone"
        nud_p3_stone.Size = New Size(55, 23)
        nud_p3_stone.TabIndex = 129
        nud_p3_stone.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p2_stone
        ' 
        nud_p2_stone.Location = New Point(336, 112)
        nud_p2_stone.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p2_stone.Name = "nud_p2_stone"
        nud_p2_stone.Size = New Size(55, 23)
        nud_p2_stone.TabIndex = 128
        nud_p2_stone.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_stone
        ' 
        lb_stone.AutoSize = True
        lb_stone.Location = New Point(336, 16)
        lb_stone.Name = "lb_stone"
        lb_stone.Size = New Size(37, 15)
        lb_stone.TabIndex = 127
        lb_stone.Text = "Stone"
        lb_stone.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_p1_stone
        ' 
        nud_p1_stone.Location = New Point(336, 80)
        nud_p1_stone.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p1_stone.Name = "nud_p1_stone"
        nud_p1_stone.Size = New Size(55, 23)
        nud_p1_stone.TabIndex = 126
        nud_p1_stone.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gaia_wood
        ' 
        nud_gaia_wood.Location = New Point(272, 48)
        nud_gaia_wood.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gaia_wood.Name = "nud_gaia_wood"
        nud_gaia_wood.Size = New Size(55, 23)
        nud_gaia_wood.TabIndex = 125
        nud_gaia_wood.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p8_wood
        ' 
        nud_p8_wood.Location = New Point(272, 304)
        nud_p8_wood.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p8_wood.Name = "nud_p8_wood"
        nud_p8_wood.Size = New Size(55, 23)
        nud_p8_wood.TabIndex = 124
        nud_p8_wood.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p7_wood
        ' 
        nud_p7_wood.Location = New Point(272, 272)
        nud_p7_wood.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p7_wood.Name = "nud_p7_wood"
        nud_p7_wood.Size = New Size(55, 23)
        nud_p7_wood.TabIndex = 123
        nud_p7_wood.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p6_wood
        ' 
        nud_p6_wood.Location = New Point(272, 240)
        nud_p6_wood.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p6_wood.Name = "nud_p6_wood"
        nud_p6_wood.Size = New Size(55, 23)
        nud_p6_wood.TabIndex = 122
        nud_p6_wood.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p5_wood
        ' 
        nud_p5_wood.Location = New Point(272, 208)
        nud_p5_wood.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p5_wood.Name = "nud_p5_wood"
        nud_p5_wood.Size = New Size(55, 23)
        nud_p5_wood.TabIndex = 121
        nud_p5_wood.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p4_wood
        ' 
        nud_p4_wood.Location = New Point(272, 176)
        nud_p4_wood.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p4_wood.Name = "nud_p4_wood"
        nud_p4_wood.Size = New Size(55, 23)
        nud_p4_wood.TabIndex = 120
        nud_p4_wood.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p3_wood
        ' 
        nud_p3_wood.Location = New Point(272, 144)
        nud_p3_wood.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p3_wood.Name = "nud_p3_wood"
        nud_p3_wood.Size = New Size(55, 23)
        nud_p3_wood.TabIndex = 119
        nud_p3_wood.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p2_wood
        ' 
        nud_p2_wood.Location = New Point(272, 112)
        nud_p2_wood.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p2_wood.Name = "nud_p2_wood"
        nud_p2_wood.Size = New Size(55, 23)
        nud_p2_wood.TabIndex = 118
        nud_p2_wood.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_wood
        ' 
        lb_wood.AutoSize = True
        lb_wood.Location = New Point(272, 16)
        lb_wood.Name = "lb_wood"
        lb_wood.Size = New Size(39, 15)
        lb_wood.TabIndex = 117
        lb_wood.Text = "Wood"
        lb_wood.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_p1_wood
        ' 
        nud_p1_wood.Location = New Point(272, 80)
        nud_p1_wood.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p1_wood.Name = "nud_p1_wood"
        nud_p1_wood.Size = New Size(55, 23)
        nud_p1_wood.TabIndex = 116
        nud_p1_wood.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_gaia_food
        ' 
        nud_gaia_food.Location = New Point(208, 48)
        nud_gaia_food.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_gaia_food.Name = "nud_gaia_food"
        nud_gaia_food.Size = New Size(55, 23)
        nud_gaia_food.TabIndex = 115
        nud_gaia_food.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p8_food
        ' 
        nud_p8_food.Location = New Point(208, 304)
        nud_p8_food.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p8_food.Name = "nud_p8_food"
        nud_p8_food.Size = New Size(55, 23)
        nud_p8_food.TabIndex = 114
        nud_p8_food.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p7_food
        ' 
        nud_p7_food.Location = New Point(208, 272)
        nud_p7_food.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p7_food.Name = "nud_p7_food"
        nud_p7_food.Size = New Size(55, 23)
        nud_p7_food.TabIndex = 113
        nud_p7_food.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p6_food
        ' 
        nud_p6_food.Location = New Point(208, 240)
        nud_p6_food.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p6_food.Name = "nud_p6_food"
        nud_p6_food.Size = New Size(55, 23)
        nud_p6_food.TabIndex = 112
        nud_p6_food.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p5_food
        ' 
        nud_p5_food.Location = New Point(208, 208)
        nud_p5_food.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p5_food.Name = "nud_p5_food"
        nud_p5_food.Size = New Size(55, 23)
        nud_p5_food.TabIndex = 111
        nud_p5_food.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p4_food
        ' 
        nud_p4_food.Location = New Point(208, 176)
        nud_p4_food.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p4_food.Name = "nud_p4_food"
        nud_p4_food.Size = New Size(55, 23)
        nud_p4_food.TabIndex = 110
        nud_p4_food.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p3_food
        ' 
        nud_p3_food.Location = New Point(208, 144)
        nud_p3_food.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p3_food.Name = "nud_p3_food"
        nud_p3_food.Size = New Size(55, 23)
        nud_p3_food.TabIndex = 109
        nud_p3_food.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' nud_p2_food
        ' 
        nud_p2_food.Location = New Point(208, 112)
        nud_p2_food.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p2_food.Name = "nud_p2_food"
        nud_p2_food.Size = New Size(55, 23)
        nud_p2_food.TabIndex = 108
        nud_p2_food.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        ' 
        ' lb_food
        ' 
        lb_food.AutoSize = True
        lb_food.Location = New Point(208, 16)
        lb_food.Name = "lb_food"
        lb_food.Size = New Size(34, 15)
        lb_food.TabIndex = 107
        lb_food.Text = "Food"
        lb_food.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nud_p1_food
        ' 
        nud_p1_food.Location = New Point(208, 80)
        nud_p1_food.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nud_p1_food.Name = "nud_p1_food"
        nud_p1_food.Size = New Size(55, 23)
        nud_p1_food.TabIndex = 106
        nud_p1_food.Value = New Decimal(New Integer() {99999, 0, 0, 0})
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
        tp_units.Controls.Add(lbx_placed_objects)
        tp_units.Controls.Add(lbx_map_y)
        tp_units.Controls.Add(lbx_map_x)
        tp_units.Controls.Add(cbx_unit_player)
        tp_units.Controls.Add(btn_remove_unit)
        tp_units.Controls.Add(btn_create_unit)
        tp_units.Controls.Add(lbx_objects)
        tp_units.Location = New Point(4, 24)
        tp_units.Name = "tp_units"
        tp_units.Padding = New Padding(3)
        tp_units.Size = New Size(1428, 509)
        tp_units.TabIndex = 3
        tp_units.Text = "Units"
        tp_units.UseVisualStyleBackColor = True
        ' 
        ' cbx_unit_player
        ' 
        cbx_unit_player.FormattingEnabled = True
        cbx_unit_player.Items.AddRange(New Object() {"Gaia", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6", "Player 7", "Player 8"})
        cbx_unit_player.Location = New Point(360, 96)
        cbx_unit_player.Name = "cbx_unit_player"
        cbx_unit_player.Size = New Size(121, 23)
        cbx_unit_player.TabIndex = 4
        cbx_unit_player.Text = "Player"
        ' 
        ' btn_remove_unit
        ' 
        btn_remove_unit.Location = New Point(360, 64)
        btn_remove_unit.Name = "btn_remove_unit"
        btn_remove_unit.Size = New Size(75, 25)
        btn_remove_unit.TabIndex = 3
        btn_remove_unit.Text = "Remove Unit"
        btn_remove_unit.UseVisualStyleBackColor = True
        ' 
        ' btn_create_unit
        ' 
        btn_create_unit.Location = New Point(360, 32)
        btn_create_unit.Name = "btn_create_unit"
        btn_create_unit.Size = New Size(75, 25)
        btn_create_unit.TabIndex = 2
        btn_create_unit.Text = "Create"
        btn_create_unit.UseVisualStyleBackColor = True
        ' 
        ' lbx_objects
        ' 
        lbx_objects.FormattingEnabled = True
        lbx_objects.ItemHeight = 15
        lbx_objects.Items.AddRange(New Object() {"-1: None", "0: "})
        lbx_objects.Location = New Point(8, 32)
        lbx_objects.Name = "lbx_objects"
        lbx_objects.Size = New Size(235, 469)
        lbx_objects.TabIndex = 0
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
        tp_diplomacy.Size = New Size(1428, 509)
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
        tp_victory.Size = New Size(1428, 509)
        tp_victory.TabIndex = 5
        tp_victory.Text = "Victory"
        tp_victory.UseVisualStyleBackColor = True
        ' 
        ' tp_options
        ' 
        tp_options.Location = New Point(4, 24)
        tp_options.Name = "tp_options"
        tp_options.Padding = New Padding(3)
        tp_options.Size = New Size(1428, 509)
        tp_options.TabIndex = 6
        tp_options.Text = "Options"
        tp_options.UseVisualStyleBackColor = True
        ' 
        ' tp_messages
        ' 
        tp_messages.Location = New Point(4, 24)
        tp_messages.Name = "tp_messages"
        tp_messages.Padding = New Padding(3)
        tp_messages.Size = New Size(1428, 509)
        tp_messages.TabIndex = 7
        tp_messages.Text = "Messages"
        tp_messages.UseVisualStyleBackColor = True
        ' 
        ' tp_cinematics
        ' 
        tp_cinematics.Location = New Point(4, 24)
        tp_cinematics.Name = "tp_cinematics"
        tp_cinematics.Padding = New Padding(3)
        tp_cinematics.Size = New Size(1428, 509)
        tp_cinematics.TabIndex = 8
        tp_cinematics.Text = "Cinematics"
        tp_cinematics.UseVisualStyleBackColor = True
        ' 
        ' tp_triggers
        ' 
        tp_triggers.Location = New Point(4, 24)
        tp_triggers.Name = "tp_triggers"
        tp_triggers.Padding = New Padding(3)
        tp_triggers.Size = New Size(1428, 509)
        tp_triggers.TabIndex = 9
        tp_triggers.Text = "Triggers"
        tp_triggers.UseVisualStyleBackColor = True
        ' 
        ' tp_about
        ' 
        tp_about.Controls.Add(lbl_aoe2de_sm)
        tp_about.Location = New Point(4, 24)
        tp_about.Name = "tp_about"
        tp_about.Padding = New Padding(3)
        tp_about.Size = New Size(1428, 509)
        tp_about.TabIndex = 10
        tp_about.Text = "About"
        tp_about.UseVisualStyleBackColor = True
        ' 
        ' lbl_aoe2de_sm
        ' 
        lbl_aoe2de_sm.AutoSize = True
        lbl_aoe2de_sm.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lbl_aoe2de_sm.Location = New Point(8, 16)
        lbl_aoe2de_sm.Name = "lbl_aoe2de_sm"
        lbl_aoe2de_sm.Size = New Size(523, 90)
        lbl_aoe2de_sm.TabIndex = 0
        lbl_aoe2de_sm.Text = "Age of Empires 2 DE Scenario Maker" & vbCrLf & "Version: 0.0.2" & vbCrLf & "Created By: Jeremy ""SpoOkyMagician"" Levegood"
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
        ' lbx_map_y
        ' 
        lbx_map_y.FormattingEnabled = True
        lbx_map_y.ItemHeight = 15
        lbx_map_y.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365", "366", "367", "368", "369", "370", "371", "372", "373", "374", "375", "376", "377", "378", "379", "380", "381", "382", "383", "384", "385", "386", "387", "388", "389", "390", "391", "392", "393", "394", "395", "396", "397", "398", "399", "400", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "418", "419", "420", "421", "422", "423", "424", "425", "426", "427", "428", "429", "430", "431", "432", "433", "434", "435", "436", "437", "438", "439", "440", "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454", "455", "456", "457", "458", "459", "460", "461", "462", "463", "464", "465", "466", "467", "468", "469", "470", "471", "472", "473", "474", "475", "476", "477", "478", "479"})
        lbx_map_y.Location = New Point(304, 32)
        lbx_map_y.Name = "lbx_map_y"
        lbx_map_y.Size = New Size(48, 469)
        lbx_map_y.TabIndex = 14
        ' 
        ' lbx_map_x
        ' 
        lbx_map_x.FormattingEnabled = True
        lbx_map_x.ItemHeight = 15
        lbx_map_x.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365", "366", "367", "368", "369", "370", "371", "372", "373", "374", "375", "376", "377", "378", "379", "380", "381", "382", "383", "384", "385", "386", "387", "388", "389", "390", "391", "392", "393", "394", "395", "396", "397", "398", "399", "400", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "418", "419", "420", "421", "422", "423", "424", "425", "426", "427", "428", "429", "430", "431", "432", "433", "434", "435", "436", "437", "438", "439", "440", "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454", "455", "456", "457", "458", "459", "460", "461", "462", "463", "464", "465", "466", "467", "468", "469", "470", "471", "472", "473", "474", "475", "476", "477", "478", "479"})
        lbx_map_x.Location = New Point(248, 32)
        lbx_map_x.Name = "lbx_map_x"
        lbx_map_x.Size = New Size(48, 469)
        lbx_map_x.TabIndex = 13
        ' 
        ' lbx_placed_objects
        ' 
        lbx_placed_objects.FormattingEnabled = True
        lbx_placed_objects.ItemHeight = 15
        lbx_placed_objects.Location = New Point(488, 32)
        lbx_placed_objects.Name = "lbx_placed_objects"
        lbx_placed_objects.Size = New Size(152, 469)
        lbx_placed_objects.TabIndex = 15
        ' 
        ' frm_scenario_maker
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1457, 561)
        Controls.Add(tc_main)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frm_scenario_maker"
        Text = "AoE2DE Scenario Maker"
        tc_main.ResumeLayout(False)
        tp_file.ResumeLayout(False)
        tp_file.PerformLayout()
        tp_map.ResumeLayout(False)
        tp_map.PerformLayout()
        CType(nud_mwh_size, ComponentModel.ISupportInitialize).EndInit()
        tp_terrain.ResumeLayout(False)
        tp_terrain.PerformLayout()
        tp_players.ResumeLayout(False)
        tp_players.PerformLayout()
        CType(nud_p8_priority, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p7_priority, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p6_priority, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p5_priority, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p4_priority, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p3_priority, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p2_priority, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p1_priority, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gaia_priority, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gaia_population, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p8_population, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p7_population, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p6_population, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p5_population, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p4_population, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p3_population, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p2_population, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p1_population, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gaia_gold, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p8_gold, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p7_gold, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p6_gold, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p5_gold, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p4_gold, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p3_gold, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p2_gold, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p1_gold, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gaia_stone, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p8_stone, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p7_stone, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p6_stone, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p5_stone, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p4_stone, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p3_stone, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p2_stone, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p1_stone, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gaia_wood, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p8_wood, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p7_wood, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p6_wood, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p5_wood, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p4_wood, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p3_wood, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p2_wood, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p1_wood, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_gaia_food, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p8_food, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p7_food, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p6_food, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p5_food, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p4_food, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p3_food, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p2_food, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_p1_food, ComponentModel.ISupportInitialize).EndInit()
        tp_units.ResumeLayout(False)
        tp_diplomacy.ResumeLayout(False)
        tp_diplomacy.PerformLayout()
        tp_about.ResumeLayout(False)
        tp_about.PerformLayout()
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
    Public WithEvents tbx_p8_name_string_id As TextBox
    Public WithEvents tbx_p7_name_string_id As TextBox
    Public WithEvents tbx_p6_name_string_id As TextBox
    Public WithEvents tbx_p5_name_string_id As TextBox
    Public WithEvents tbx_p4_name_string_id As TextBox
    Public WithEvents tbx_p3_name_string_id As TextBox
    Public WithEvents tbx_p2_name_string_id As TextBox
    Public WithEvents tbx_p1_name_string_id As TextBox
    Public WithEvents tbx_gaia_name_string_id As TextBox
    Public WithEvents lb_tribe_name As Label
    Public WithEvents tbx_p8_tribe_name As TextBox
    Public WithEvents tbx_p7_tribe_name As TextBox
    Public WithEvents tbx_p6_tribe_name As TextBox
    Public WithEvents tbx_p5_tribe_name As TextBox
    Public WithEvents tbx_p4_tribe_name As TextBox
    Public WithEvents tbx_p3_tribe_name As TextBox
    Public WithEvents tbx_p2_tribe_name As TextBox
    Public WithEvents tbx_p1_tribe_name As TextBox
    Public WithEvents tbx_gaia_tribe_name As TextBox
    Public WithEvents cbx_p8_color As ComboBox
    Public WithEvents cbx_p7_color As ComboBox
    Public WithEvents cbx_p6_color As ComboBox
    Public WithEvents cbx_p5_color As ComboBox
    Public WithEvents cbx_p4_color As ComboBox
    Public WithEvents cbx_p3_color As ComboBox
    Public WithEvents cbx_p2_color As ComboBox
    Public WithEvents cbx_p1_color As ComboBox
    Public WithEvents lb_color As Label
    Public WithEvents cbx_gaia_color As ComboBox
    Public WithEvents lb_player_8 As Label
    Public WithEvents lb_player_7 As Label
    Public WithEvents lb_player_6 As Label
    Public WithEvents lb_player_5 As Label
    Public WithEvents lb_player_4 As Label
    Public WithEvents lb_player_3 As Label
    Public WithEvents lb_player_2 As Label
    Public WithEvents lb_player_1 As Label
    Public WithEvents lb_gaia As Label
    Public WithEvents nud_p8_priority As NumericUpDown
    Public WithEvents nud_p7_priority As NumericUpDown
    Public WithEvents nud_p6_priority As NumericUpDown
    Public WithEvents nud_p5_priority As NumericUpDown
    Public WithEvents nud_p4_priority As NumericUpDown
    Public WithEvents nud_p3_priority As NumericUpDown
    Public WithEvents nud_p2_priority As NumericUpDown
    Public WithEvents nud_p1_priority As NumericUpDown
    Public WithEvents nud_gaia_priority As NumericUpDown
    Public WithEvents lb_priority_gaia As Label
    Public WithEvents nud_gaia_population As NumericUpDown
    Public WithEvents nud_p8_population As NumericUpDown
    Public WithEvents nud_p7_population As NumericUpDown
    Public WithEvents nud_p6_population As NumericUpDown
    Public WithEvents nud_p5_population As NumericUpDown
    Public WithEvents nud_p4_population As NumericUpDown
    Public WithEvents nud_p3_population As NumericUpDown
    Public WithEvents nud_p2_population As NumericUpDown
    Public WithEvents lb_pop As Label
    Public WithEvents nud_p1_population As NumericUpDown
    Public WithEvents nud_gaia_gold As NumericUpDown
    Public WithEvents nud_p8_gold As NumericUpDown
    Public WithEvents nud_p7_gold As NumericUpDown
    Public WithEvents nud_p6_gold As NumericUpDown
    Public WithEvents nud_p5_gold As NumericUpDown
    Public WithEvents nud_p4_gold As NumericUpDown
    Public WithEvents nud_p3_gold As NumericUpDown
    Public WithEvents nud_p2_gold As NumericUpDown
    Public WithEvents lb_gold As Label
    Public WithEvents nud_p1_gold As NumericUpDown
    Public WithEvents nud_gaia_stone As NumericUpDown
    Public WithEvents nud_p8_stone As NumericUpDown
    Public WithEvents nud_p7_stone As NumericUpDown
    Public WithEvents nud_p6_stone As NumericUpDown
    Public WithEvents nud_p5_stone As NumericUpDown
    Public WithEvents nud_p4_stone As NumericUpDown
    Public WithEvents nud_p3_stone As NumericUpDown
    Public WithEvents nud_p2_stone As NumericUpDown
    Public WithEvents lb_stone As Label
    Public WithEvents nud_p1_stone As NumericUpDown
    Public WithEvents nud_gaia_wood As NumericUpDown
    Public WithEvents nud_p8_wood As NumericUpDown
    Public WithEvents nud_p7_wood As NumericUpDown
    Public WithEvents nud_p6_wood As NumericUpDown
    Public WithEvents nud_p5_wood As NumericUpDown
    Public WithEvents nud_p4_wood As NumericUpDown
    Public WithEvents nud_p3_wood As NumericUpDown
    Public WithEvents nud_p2_wood As NumericUpDown
    Public WithEvents lb_wood As Label
    Public WithEvents nud_p1_wood As NumericUpDown
    Public WithEvents nud_gaia_food As NumericUpDown
    Public WithEvents nud_p8_food As NumericUpDown
    Public WithEvents nud_p7_food As NumericUpDown
    Public WithEvents nud_p6_food As NumericUpDown
    Public WithEvents nud_p5_food As NumericUpDown
    Public WithEvents nud_p4_food As NumericUpDown
    Public WithEvents nud_p3_food As NumericUpDown
    Public WithEvents nud_p2_food As NumericUpDown
    Public WithEvents lb_food As Label
    Public WithEvents nud_p1_food As NumericUpDown
    Public WithEvents cbx_total_players As ComboBox
    Public WithEvents tp_file As TabPage
    Public WithEvents ofd_scenario As OpenFileDialog
    Public WithEvents sfd_scenario As SaveFileDialog
    Public WithEvents btn_save As Button
    Public WithEvents btn_load As Button
    Public WithEvents lbl_load_path As Label
    Public WithEvents lbl_save_path As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Public WithEvents cbx_p8_ai As CheckBox
    Public WithEvents cbx_p7_ai As CheckBox
    Public WithEvents cbx_p6_ai As CheckBox
    Public WithEvents cbx_p5_ai As CheckBox
    Public WithEvents cbx_p4_ai As CheckBox
    Public WithEvents cbx_p3_ai As CheckBox
    Public WithEvents cbx_p2_ai As CheckBox
    Public WithEvents cbx_p1_ai As CheckBox
    Public WithEvents cbx_gaia_ai As CheckBox
    Public WithEvents lbl_player_type As Label
    Public WithEvents btn_new_scenario As Button
    Public WithEvents tp_units As TabPage
    Public WithEvents lbx_objects As ListBox
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
    Public WithEvents cbx_p3_age As ComboBox
    Public WithEvents cbx_p2_age As ComboBox
    Public WithEvents cbx_p1_age As ComboBox
    Public WithEvents cbx_p5_age As ComboBox
    Public WithEvents cbx_p4_age As ComboBox
    Public WithEvents cbx_p8_age As ComboBox
    Public WithEvents cbx_p7_age As ComboBox
    Public WithEvents cbx_p6_age As ComboBox
    Public WithEvents lbl_age As Label
    Public WithEvents cbx_gaia_age As ComboBox
    Friend WithEvents tp_terrain As TabPage
    Public WithEvents btn_test As Button
    Public WithEvents ofd_aoe2de_path As OpenFileDialog
    Public WithEvents tbx_script_filename As TextBox
    Friend WithEvents lbl_aoe2de_sm As Label
    Public WithEvents Button1 As Button
    Public WithEvents lbx_x_terrain As ListBox
    Public WithEvents lbx_base_terrain As ListBox
    Public WithEvents lbx_elevation As ListBox
    Public WithEvents lbx_layer_terrain As ListBox
    Public WithEvents lbl_base_terrain As Label
    Public WithEvents lbl_elevation As Label
    Public WithEvents lbl_layer_terrain As Label
    Public WithEvents lbx_y_terrain As ListBox
    Public WithEvents lbl_x_terrain As Label
    Public WithEvents lbl_y_terrain As Label
    Public WithEvents cbx_gaia_ai_personality As ComboBox
    Public WithEvents cbx_p1_ai_personality As ComboBox
    Public WithEvents cbx_p8_ai_personality As ComboBox
    Public WithEvents cbx_p7_ai_personality As ComboBox
    Public WithEvents cbx_p6_ai_personality As ComboBox
    Public WithEvents cbx_p5_ai_personality As ComboBox
    Public WithEvents cbx_p4_ai_personality As ComboBox
    Public WithEvents cbx_p3_ai_personality As ComboBox
    Public WithEvents cbx_p2_ai_personality As ComboBox
    Public WithEvents cbx_use_layers As CheckBox
    Public WithEvents lbl_ai_personality As Label
    Public WithEvents cbx_gaia_civilization As ComboBox
    Public WithEvents cbx_p3_civilization As ComboBox
    Public WithEvents cbx_p2_civilization As ComboBox
    Public WithEvents cbx_p1_civilization As ComboBox
    Public WithEvents cbx_p8_civilization As ComboBox
    Public WithEvents cbx_p7_civilization As ComboBox
    Public WithEvents cbx_p6_civilization As ComboBox
    Public WithEvents cbx_p5_civilization As ComboBox
    Public WithEvents cbx_p4_civilization As ComboBox
    Public WithEvents lbl_civilization As Label
    Public WithEvents cbx_p8_architecture As ComboBox
    Public WithEvents cbx_p7_architecture As ComboBox
    Public WithEvents cbx_p6_architecture As ComboBox
    Public WithEvents cbx_p5_architecture As ComboBox
    Public WithEvents cbx_p4_architecture As ComboBox
    Public WithEvents cbx_p3_architecture As ComboBox
    Public WithEvents cbx_p2_architecture As ComboBox
    Public WithEvents cbx_p1_architecture As ComboBox
    Public WithEvents cbx_gaia_architecture As ComboBox
    Public WithEvents lbl_architecture As Label
    Public WithEvents cbx_gaia_lock_civ As CheckBox
    Public WithEvents cbx_p8_lock_civ As CheckBox
    Public WithEvents cbx_p7_lock_civ As CheckBox
    Public WithEvents cbx_p6_lock_civ As CheckBox
    Public WithEvents cbx_p5_lock_civ As CheckBox
    Public WithEvents cbx_p4_lock_civ As CheckBox
    Public WithEvents cbx_p3_lock_civ As CheckBox
    Public WithEvents cbx_p2_lock_civ As CheckBox
    Public WithEvents cbx_p1_lock_civ As CheckBox
    Friend WithEvents cbx_gaia_lock_personality As CheckBox
    Friend WithEvents cbx_p2_lock_personality As CheckBox
    Friend WithEvents cbx_p1_lock_personality As CheckBox
    Friend WithEvents cbx_p8_lock_personality As CheckBox
    Friend WithEvents cbx_p7_lock_personality As CheckBox
    Friend WithEvents cbx_p6_lock_personality As CheckBox
    Friend WithEvents cbx_p5_lock_personality As CheckBox
    Friend WithEvents cbx_p4_lock_personality As CheckBox
    Friend WithEvents cbx_p3_lock_personality As CheckBox
    Public WithEvents lbx_map_y As ListBox
    Public WithEvents lbx_map_x As ListBox
    Public WithEvents lbx_placed_objects As ListBox
End Class
