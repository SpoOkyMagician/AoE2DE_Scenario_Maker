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
        lbl_script_filename = New Label()
        lbl_color_mood = New Label()
        lbl_ai_map_type = New Label()
        lbl_default_terrain = New Label()
        lbl_custom_map_size = New Label()
        lbl_map_size = New Label()
        tbx_script_filename = New TextBox()
        cbx_map_size = New ComboBox()
        nud_mwh_size = New NumericUpDown()
        cbx_team_positions = New CheckBox()
        cbx_default_terrain = New ComboBox()
        cbx_color_mood = New ComboBox()
        cbx_ai_map_type = New ComboBox()
        tp_terrain = New TabPage()
        lbl_placed_terrains = New Label()
        lbl_important_note_terrain = New Label()
        lbx_placed_terrains = New ListBox()
        cbx_use_layers = New CheckBox()
        lbl_y_terrain = New Label()
        lbx_y_terrain = New ListBox()
        lbl_x_terrain = New Label()
        lbl_elevation = New Label()
        lbl_layer_terrain = New Label()
        lbl_base_terrain = New Label()
        lbx_layer_terrain = New ListBox()
        lbx_elevation = New ListBox()
        btn_set_terrain = New Button()
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
        tp_objects = New TabPage()
        lbl_object_player = New Label()
        lbl_placed_objects = New Label()
        lbl_object_y = New Label()
        lbl_object_x = New Label()
        lbl_object_list_b = New Label()
        lbl_object_list_a = New Label()
        lbl_important_note_units = New Label()
        lbx_objects_2 = New ListBox()
        lbx_placed_objects = New ListBox()
        lbx_map_y = New ListBox()
        lbx_map_x = New ListBox()
        cbx_object_player = New ComboBox()
        btn_remove_unit = New Button()
        btn_create_unit = New Button()
        lbx_objects_1 = New ListBox()
        tp_diplomacy = New TabPage()
        lbl_max_teams = New Label()
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
        lbl_percentage = New Label()
        lbl_time_limit = New Label()
        lbl_score = New Label()
        lbl_victory_condition = New Label()
        cbx_king_of_the_hill = New CheckBox()
        cbx_regicide = New CheckBox()
        cbx_sudden_death = New CheckBox()
        cbx_empire_wars = New CheckBox()
        rbn_secondary_game_mode = New RadioButton()
        tbx_relics_total = New TextBox()
        tbx_exploration_total = New TextBox()
        cbx_all = New CheckBox()
        cbx_relics = New CheckBox()
        cbx_exploration = New CheckBox()
        cbx_conquest = New CheckBox()
        rbn_custom = New RadioButton()
        cbx_time_limit = New ComboBox()
        rbn_time_limit = New RadioButton()
        cbx_score = New ComboBox()
        rbn_score = New RadioButton()
        rbn_conquest = New RadioButton()
        rbn_standard = New RadioButton()
        tp_options = New TabPage()
        lbl_testing_difficulty = New Label()
        lbl_options_player = New Label()
        lbl_disabled_techs = New Label()
        lbl_disabled_buildings = New Label()
        lbl_disabled_units = New Label()
        btn_camera_view = New Button()
        lbx_view_y = New ListBox()
        lbx_view_x = New ListBox()
        cbx_testing_difficulty = New ComboBox()
        cbx_lock_co_op_alliances = New CheckBox()
        cbx_villager_force_drop = New CheckBox()
        cbx_collide_and_correcting = New CheckBox()
        cbx_full_tech_tree = New CheckBox()
        cbx_disabled_player = New ComboBox()
        clb_disabled_techs = New CheckedListBox()
        clb_disabled_buildings = New CheckedListBox()
        clb_disabled_units = New CheckedListBox()
        tp_messages = New TabPage()
        lbl_scout_string_id = New Label()
        lbl_history_string_id = New Label()
        lbl_loss_string_id = New Label()
        lbl_victory_string_id = New Label()
        lbl_hints_string_id = New Label()
        lbl_instructions_string_id = New Label()
        tbx_scout_string_id = New TextBox()
        tbx_history_string_id = New TextBox()
        tbx_loss_string_id = New TextBox()
        tbx_victory_string_id = New TextBox()
        tbx_hints_string_id = New TextBox()
        tbx_instructions_string_id = New TextBox()
        tbx_scout = New TextBox()
        tbx_history = New TextBox()
        tbx_loss = New TextBox()
        tbx_victory = New TextBox()
        tbx_hints = New TextBox()
        tbx_instructions = New TextBox()
        tp_cinematics = New TabPage()
        lbl_scenario_instructions_map = New Label()
        lbl_loss_cinematics = New Label()
        lbl_victory_cinematics = New Label()
        lbl_pregame_cinematics = New Label()
        cbx_instructions_cinematic = New ComboBox()
        cbx_loss_cinematic = New ComboBox()
        cbx_victory_cinematic = New ComboBox()
        cbx_pregame_cinematic = New ComboBox()
        tp_trigger = New TabPage()
        lbl_created_trigger = New Label()
        lbl_trigger_effects = New Label()
        lbl_trigger_conditions = New Label()
        btn_trigger_add_effect = New Button()
        btn_trigger_add_condition = New Button()
        lbx_created_trigger = New ListBox()
        cbx_trigger_display_on_screen = New CheckBox()
        cbx_trigger_display_as_objective = New CheckBox()
        tbx_trigger_short_description_string_id = New TextBox()
        tbx_trigger_description_string_id = New TextBox()
        tbx_trigger_short_description = New TextBox()
        tbx_trigger_description = New TextBox()
        cbx_trigger_looping = New CheckBox()
        cbx_trigger_starting_state = New CheckBox()
        tbx_trigger_name = New TextBox()
        lbx_trigger_effects = New ListBox()
        lbx_trigger_conditions = New ListBox()
        tp_about = New TabPage()
        lbl_aoe2de_sm = New Label()
        ofd_scenario = New OpenFileDialog()
        sfd_scenario = New SaveFileDialog()
        ofd_aoe2de_path = New OpenFileDialog()
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
        tp_objects.SuspendLayout()
        tp_diplomacy.SuspendLayout()
        tp_victory.SuspendLayout()
        tp_options.SuspendLayout()
        tp_messages.SuspendLayout()
        tp_cinematics.SuspendLayout()
        tp_trigger.SuspendLayout()
        tp_about.SuspendLayout()
        SuspendLayout()
        ' 
        ' tc_main
        ' 
        tc_main.Controls.Add(tp_file)
        tc_main.Controls.Add(tp_map)
        tc_main.Controls.Add(tp_terrain)
        tc_main.Controls.Add(tp_players)
        tc_main.Controls.Add(tp_objects)
        tc_main.Controls.Add(tp_diplomacy)
        tc_main.Controls.Add(tp_victory)
        tc_main.Controls.Add(tp_options)
        tc_main.Controls.Add(tp_messages)
        tc_main.Controls.Add(tp_cinematics)
        tc_main.Controls.Add(tp_trigger)
        tc_main.Controls.Add(tp_about)
        tc_main.ImeMode = ImeMode.NoControl
        tc_main.Location = New Point(0, 8)
        tc_main.Name = "tc_main"
        tc_main.SelectedIndex = 0
        tc_main.Size = New Size(1456, 552)
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
        tp_file.Size = New Size(1448, 524)
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
        tp_map.Controls.Add(lbl_script_filename)
        tp_map.Controls.Add(lbl_color_mood)
        tp_map.Controls.Add(lbl_ai_map_type)
        tp_map.Controls.Add(lbl_default_terrain)
        tp_map.Controls.Add(lbl_custom_map_size)
        tp_map.Controls.Add(lbl_map_size)
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
        tp_map.Size = New Size(1448, 524)
        tp_map.TabIndex = 0
        tp_map.Text = "Map"
        tp_map.UseVisualStyleBackColor = True
        ' 
        ' lbl_script_filename
        ' 
        lbl_script_filename.AutoSize = True
        lbl_script_filename.Location = New Point(960, 8)
        lbl_script_filename.Name = "lbl_script_filename"
        lbl_script_filename.RightToLeft = RightToLeft.No
        lbl_script_filename.Size = New Size(88, 15)
        lbl_script_filename.TabIndex = 18
        lbl_script_filename.Text = "Script Filename"
        ' 
        ' lbl_color_mood
        ' 
        lbl_color_mood.AutoSize = True
        lbl_color_mood.Location = New Point(712, 8)
        lbl_color_mood.Name = "lbl_color_mood"
        lbl_color_mood.RightToLeft = RightToLeft.No
        lbl_color_mood.Size = New Size(71, 15)
        lbl_color_mood.TabIndex = 17
        lbl_color_mood.Text = "Color Mood"
        ' 
        ' lbl_ai_map_type
        ' 
        lbl_ai_map_type.AutoSize = True
        lbl_ai_map_type.Location = New Point(464, 8)
        lbl_ai_map_type.Name = "lbl_ai_map_type"
        lbl_ai_map_type.RightToLeft = RightToLeft.No
        lbl_ai_map_type.Size = New Size(72, 15)
        lbl_ai_map_type.TabIndex = 16
        lbl_ai_map_type.Text = "AI Map Type"
        ' 
        ' lbl_default_terrain
        ' 
        lbl_default_terrain.AutoSize = True
        lbl_default_terrain.Location = New Point(216, 8)
        lbl_default_terrain.Name = "lbl_default_terrain"
        lbl_default_terrain.RightToLeft = RightToLeft.No
        lbl_default_terrain.Size = New Size(83, 15)
        lbl_default_terrain.TabIndex = 15
        lbl_default_terrain.Text = "Default Terrain"
        ' 
        ' lbl_custom_map_size
        ' 
        lbl_custom_map_size.AutoSize = True
        lbl_custom_map_size.Location = New Point(160, 8)
        lbl_custom_map_size.Name = "lbl_custom_map_size"
        lbl_custom_map_size.RightToLeft = RightToLeft.No
        lbl_custom_map_size.Size = New Size(49, 15)
        lbl_custom_map_size.TabIndex = 14
        lbl_custom_map_size.Text = "Custom"
        ' 
        ' lbl_map_size
        ' 
        lbl_map_size.AutoSize = True
        lbl_map_size.Location = New Point(8, 8)
        lbl_map_size.Name = "lbl_map_size"
        lbl_map_size.Size = New Size(54, 15)
        lbl_map_size.TabIndex = 13
        lbl_map_size.Text = "Map Size"
        ' 
        ' tbx_script_filename
        ' 
        tbx_script_filename.Location = New Point(960, 32)
        tbx_script_filename.Name = "tbx_script_filename"
        tbx_script_filename.Size = New Size(240, 23)
        tbx_script_filename.TabIndex = 12
        tbx_script_filename.Text = "Script Filename"
        ' 
        ' cbx_map_size
        ' 
        cbx_map_size.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_map_size.FormattingEnabled = True
        cbx_map_size.ImeMode = ImeMode.NoControl
        cbx_map_size.Items.AddRange(New Object() {"Miniature (1 Player)", "Tiny (2 Players)", "Small (3 Players)", "Medium (4 Players)", "Normal (6 Players)", "Large (8 Players)", "Huge", "Giant", "Massive", "Enormous", "Colossal", "Incredible", "Monstrous", "Ludicrous", "Custom"})
        cbx_map_size.Location = New Point(8, 32)
        cbx_map_size.Name = "cbx_map_size"
        cbx_map_size.Size = New Size(152, 23)
        cbx_map_size.TabIndex = 6
        ' 
        ' nud_mwh_size
        ' 
        nud_mwh_size.Enabled = False
        nud_mwh_size.Location = New Point(168, 32)
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
        cbx_team_positions.Location = New Point(1208, 32)
        cbx_team_positions.Name = "cbx_team_positions"
        cbx_team_positions.Size = New Size(105, 19)
        cbx_team_positions.TabIndex = 11
        cbx_team_positions.Text = "Team Positions"
        cbx_team_positions.UseVisualStyleBackColor = True
        ' 
        ' cbx_default_terrain
        ' 
        cbx_default_terrain.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_default_terrain.FormattingEnabled = True
        cbx_default_terrain.Items.AddRange(New Object() {"Beach", "Beach (Non-Navigable)", "Beach (Non-Navigable), Wet Gravel", "Beach (Non-Navigable), Wet Rock", "Beach (Non-Navigable), Wet Sand", "Beach, Ice", "Beach, Vegetation", "Beach, Wet", "Beach, Wet Gravel", "Beach, Wet Rock", "Beach, White", "Beach, White, Vegetation", "Black", "Desert, Cracked", "Desert, Quicksand", "Desert, Sand", "Dirt 1", "Dirt 2", "Dirt 3", "Dirt 4", "Dirt, Mud", "Dirt, Savannah", "Farm", "Farm, 0%", "Farm, 33%", "Farm, 67%", "Farm, Dead", "Forest, Acacia", "Forest, Autumn", "Forest, Autumn Snow", "Forest, Bamboo", "Forest, Baobab", "Forest, Birch", "Forest, Bush", "Forest, Dead", "Forest, Dragon Tree", "Forest, Jungle", "Forest, Mangrove", "Forest, Mediterranean", "Forest, Oak", "Forest, Oak Bush", "Forest, Palm Desert", "Forest, Palm Grass", "Forest, Pine", "Forest, Pine Snow", "Forest, Rainforest", "Forest, Reeds", "Forest, Reeds (Beach)", "Forest, Reeds (Shallows)", "Grass 1", "Grass 2", "Grass 3", "Grass, Dry", "Grass, Foundation", "Grass, Jungle", "Grass, Jungle (Rainforest)", "Grass, Other", "Gravel, Default", "Gravel, Desert", "Ice", "Ice, Navigable", "Rice Farm", "Rice Farm, 0%", "Rice Farm, 33%", "Rice Farm, 66%", "Rice Farm, Dead", "Road", "Road, Broken", "Road, Fungus", "Road, Gravel", "Rock 1", "Shallows", "Shallows, Azure", "Shallows, Mangrove", "Snow", "Snow, Foundation", "Snow, Light", "Snow, Strong", "Swamp, Bogland", "Swamp, Shallows", "Underbrush", "Underbrush, Jungle", "Underbrush, Leaves", "Underbrush, Snow", "Water 2D, Bridge", "Water 2D, Shoreless", "Water, Azure", "Water, Brown", "Water, Deep", "Water, Deep Ocean", "Water, Green", "Water, Medium", "Water, Shallow"})
        cbx_default_terrain.Location = New Point(216, 32)
        cbx_default_terrain.Name = "cbx_default_terrain"
        cbx_default_terrain.Size = New Size(243, 23)
        cbx_default_terrain.TabIndex = 8
        ' 
        ' cbx_color_mood
        ' 
        cbx_color_mood.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_color_mood.FormattingEnabled = True
        cbx_color_mood.Items.AddRange(New Object() {"Default", "Autumn", "Desert", "Jungle", "Winter", "Night"})
        cbx_color_mood.Location = New Point(712, 32)
        cbx_color_mood.Name = "cbx_color_mood"
        cbx_color_mood.Size = New Size(243, 23)
        cbx_color_mood.TabIndex = 10
        ' 
        ' cbx_ai_map_type
        ' 
        cbx_ai_map_type.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_ai_map_type.FormattingEnabled = True
        cbx_ai_map_type.Items.AddRange(New Object() {"Acclivity", "Acropolis", "African Clearing", "Aftermath", "Alpine Lakes", "Amazon Tunnel", "Arabia", "Archipelago", "Arena", "Atacama", "BR Battle On Ice", "BR El Dorado", "BR Fall of Axum", "BR Fall of Rome", "BR Majapahit Empire", "Baltic", "Black Forest", "Bog Islands", "Bogland", "Budapest", "Cenotes", "City of Lakes", "Coastal", "Coastal Forest", "Continental", "Crater", "Crater Lake", "Crossroads", "CtR Monsoon", "CtR Pyramid Descent", "CtR Random", "CtR Spiral", "Enclosed", "Eruption", "Fortress", "Four Lakes", "Frigid Lake", "Ghost Lake", "Gold Rush", "Golden Pit", "Golden Swamp", "Greenland", "Haboob", "Hamburger", "Hideout", "Highland", "Hill Fort", "Islands", "Kawasan", "Kilimanjaro", "Land Madness", "Land Nomad", "Lombardia", "Lowland", "Mangrove Jungle", "Marketplace", "Meadow", "Mediterranean", "MegaRandom", "Michi", "Migration", "Mongolia", "Morass", "Mountain Pass", "Mountain Range", "Mountain Ridge", "Nile Delta", "Nomad", "Northern Isles", "Oasis", "Pacific Islands", "Ravines", "Ring Fortress", "Rivers", "Runestones", "Sacred Springs", "Salt Marsh", "Sandbank", "Scandanavia", "Seize The Mountain", "Serengeti", "Shoals", "Socotra", "Steppe", "Team Islands", "Team Moats", "Valley", "Volcano Island", "Wade", "Water Nomad", "Wolf Hill", "Yucatan"})
        cbx_ai_map_type.Location = New Point(464, 32)
        cbx_ai_map_type.Name = "cbx_ai_map_type"
        cbx_ai_map_type.Size = New Size(243, 23)
        cbx_ai_map_type.TabIndex = 9
        ' 
        ' tp_terrain
        ' 
        tp_terrain.Controls.Add(lbl_placed_terrains)
        tp_terrain.Controls.Add(lbl_important_note_terrain)
        tp_terrain.Controls.Add(lbx_placed_terrains)
        tp_terrain.Controls.Add(cbx_use_layers)
        tp_terrain.Controls.Add(lbl_y_terrain)
        tp_terrain.Controls.Add(lbx_y_terrain)
        tp_terrain.Controls.Add(lbl_x_terrain)
        tp_terrain.Controls.Add(lbl_elevation)
        tp_terrain.Controls.Add(lbl_layer_terrain)
        tp_terrain.Controls.Add(lbl_base_terrain)
        tp_terrain.Controls.Add(lbx_layer_terrain)
        tp_terrain.Controls.Add(lbx_elevation)
        tp_terrain.Controls.Add(btn_set_terrain)
        tp_terrain.Controls.Add(lbx_x_terrain)
        tp_terrain.Controls.Add(lbx_base_terrain)
        tp_terrain.Location = New Point(4, 24)
        tp_terrain.Name = "tp_terrain"
        tp_terrain.Size = New Size(1448, 524)
        tp_terrain.TabIndex = 11
        tp_terrain.Text = "Terrain"
        tp_terrain.UseVisualStyleBackColor = True
        ' 
        ' lbl_placed_terrains
        ' 
        lbl_placed_terrains.AutoSize = True
        lbl_placed_terrains.Location = New Point(664, 8)
        lbl_placed_terrains.Name = "lbl_placed_terrains"
        lbl_placed_terrains.Size = New Size(85, 15)
        lbl_placed_terrains.TabIndex = 19
        lbl_placed_terrains.Text = "Placed Terrains"
        ' 
        ' lbl_important_note_terrain
        ' 
        lbl_important_note_terrain.AutoSize = True
        lbl_important_note_terrain.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_important_note_terrain.Location = New Point(824, 88)
        lbl_important_note_terrain.Name = "lbl_important_note_terrain"
        lbl_important_note_terrain.Size = New Size(562, 63)
        lbl_important_note_terrain.TabIndex = 18
        lbl_important_note_terrain.Text = resources.GetString("lbl_important_note_terrain.Text")
        ' 
        ' lbx_placed_terrains
        ' 
        lbx_placed_terrains.FormattingEnabled = True
        lbx_placed_terrains.ItemHeight = 15
        lbx_placed_terrains.Location = New Point(664, 32)
        lbx_placed_terrains.Name = "lbx_placed_terrains"
        lbx_placed_terrains.ScrollAlwaysVisible = True
        lbx_placed_terrains.Size = New Size(152, 469)
        lbx_placed_terrains.TabIndex = 16
        ' 
        ' cbx_use_layers
        ' 
        cbx_use_layers.AutoSize = True
        cbx_use_layers.Location = New Point(824, 64)
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
        ' btn_set_terrain
        ' 
        btn_set_terrain.Location = New Point(824, 32)
        btn_set_terrain.Name = "btn_set_terrain"
        btn_set_terrain.Size = New Size(75, 25)
        btn_set_terrain.TabIndex = 5
        btn_set_terrain.Text = "Set"
        btn_set_terrain.UseVisualStyleBackColor = True
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
        tp_players.Size = New Size(1448, 524)
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
        cbx_p8_architecture.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p8_architecture.FormattingEnabled = True
        cbx_p8_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p8_architecture.Location = New Point(1128, 304)
        cbx_p8_architecture.Name = "cbx_p8_architecture"
        cbx_p8_architecture.Size = New Size(104, 23)
        cbx_p8_architecture.TabIndex = 254
        ' 
        ' cbx_p7_architecture
        ' 
        cbx_p7_architecture.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p7_architecture.FormattingEnabled = True
        cbx_p7_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p7_architecture.Location = New Point(1128, 272)
        cbx_p7_architecture.Name = "cbx_p7_architecture"
        cbx_p7_architecture.Size = New Size(104, 23)
        cbx_p7_architecture.TabIndex = 253
        ' 
        ' cbx_p6_architecture
        ' 
        cbx_p6_architecture.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p6_architecture.FormattingEnabled = True
        cbx_p6_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p6_architecture.Location = New Point(1128, 240)
        cbx_p6_architecture.Name = "cbx_p6_architecture"
        cbx_p6_architecture.Size = New Size(104, 23)
        cbx_p6_architecture.TabIndex = 252
        ' 
        ' cbx_p5_architecture
        ' 
        cbx_p5_architecture.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p5_architecture.FormattingEnabled = True
        cbx_p5_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p5_architecture.Location = New Point(1128, 208)
        cbx_p5_architecture.Name = "cbx_p5_architecture"
        cbx_p5_architecture.Size = New Size(104, 23)
        cbx_p5_architecture.TabIndex = 251
        ' 
        ' cbx_p4_architecture
        ' 
        cbx_p4_architecture.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p4_architecture.FormattingEnabled = True
        cbx_p4_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p4_architecture.Location = New Point(1128, 176)
        cbx_p4_architecture.Name = "cbx_p4_architecture"
        cbx_p4_architecture.Size = New Size(104, 23)
        cbx_p4_architecture.TabIndex = 250
        ' 
        ' cbx_p3_architecture
        ' 
        cbx_p3_architecture.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p3_architecture.FormattingEnabled = True
        cbx_p3_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p3_architecture.Location = New Point(1128, 144)
        cbx_p3_architecture.Name = "cbx_p3_architecture"
        cbx_p3_architecture.Size = New Size(104, 23)
        cbx_p3_architecture.TabIndex = 249
        ' 
        ' cbx_p2_architecture
        ' 
        cbx_p2_architecture.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p2_architecture.FormattingEnabled = True
        cbx_p2_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p2_architecture.Location = New Point(1128, 112)
        cbx_p2_architecture.Name = "cbx_p2_architecture"
        cbx_p2_architecture.Size = New Size(104, 23)
        cbx_p2_architecture.TabIndex = 248
        ' 
        ' cbx_p1_architecture
        ' 
        cbx_p1_architecture.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p1_architecture.FormattingEnabled = True
        cbx_p1_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p1_architecture.Location = New Point(1128, 80)
        cbx_p1_architecture.Name = "cbx_p1_architecture"
        cbx_p1_architecture.Size = New Size(104, 23)
        cbx_p1_architecture.TabIndex = 247
        ' 
        ' cbx_gaia_architecture
        ' 
        cbx_gaia_architecture.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_gaia_architecture.FormattingEnabled = True
        cbx_gaia_architecture.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_gaia_architecture.Location = New Point(1128, 48)
        cbx_gaia_architecture.Name = "cbx_gaia_architecture"
        cbx_gaia_architecture.Size = New Size(104, 23)
        cbx_gaia_architecture.TabIndex = 246
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
        cbx_p8_civilization.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p8_civilization.FormattingEnabled = True
        cbx_p8_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p8_civilization.Location = New Point(1016, 304)
        cbx_p8_civilization.Name = "cbx_p8_civilization"
        cbx_p8_civilization.Size = New Size(104, 23)
        cbx_p8_civilization.TabIndex = 243
        ' 
        ' cbx_p7_civilization
        ' 
        cbx_p7_civilization.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p7_civilization.FormattingEnabled = True
        cbx_p7_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p7_civilization.Location = New Point(1016, 272)
        cbx_p7_civilization.Name = "cbx_p7_civilization"
        cbx_p7_civilization.Size = New Size(104, 23)
        cbx_p7_civilization.TabIndex = 242
        ' 
        ' cbx_p6_civilization
        ' 
        cbx_p6_civilization.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p6_civilization.FormattingEnabled = True
        cbx_p6_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p6_civilization.Location = New Point(1016, 240)
        cbx_p6_civilization.Name = "cbx_p6_civilization"
        cbx_p6_civilization.Size = New Size(104, 23)
        cbx_p6_civilization.TabIndex = 241
        ' 
        ' cbx_p5_civilization
        ' 
        cbx_p5_civilization.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p5_civilization.FormattingEnabled = True
        cbx_p5_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p5_civilization.Location = New Point(1016, 208)
        cbx_p5_civilization.Name = "cbx_p5_civilization"
        cbx_p5_civilization.Size = New Size(104, 23)
        cbx_p5_civilization.TabIndex = 240
        ' 
        ' cbx_p4_civilization
        ' 
        cbx_p4_civilization.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p4_civilization.FormattingEnabled = True
        cbx_p4_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p4_civilization.Location = New Point(1016, 176)
        cbx_p4_civilization.Name = "cbx_p4_civilization"
        cbx_p4_civilization.Size = New Size(104, 23)
        cbx_p4_civilization.TabIndex = 239
        ' 
        ' cbx_p3_civilization
        ' 
        cbx_p3_civilization.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p3_civilization.FormattingEnabled = True
        cbx_p3_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p3_civilization.Location = New Point(1016, 144)
        cbx_p3_civilization.Name = "cbx_p3_civilization"
        cbx_p3_civilization.Size = New Size(104, 23)
        cbx_p3_civilization.TabIndex = 238
        ' 
        ' cbx_p2_civilization
        ' 
        cbx_p2_civilization.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p2_civilization.FormattingEnabled = True
        cbx_p2_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p2_civilization.Location = New Point(1016, 112)
        cbx_p2_civilization.Name = "cbx_p2_civilization"
        cbx_p2_civilization.Size = New Size(104, 23)
        cbx_p2_civilization.TabIndex = 237
        ' 
        ' cbx_p1_civilization
        ' 
        cbx_p1_civilization.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p1_civilization.FormattingEnabled = True
        cbx_p1_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_p1_civilization.Location = New Point(1016, 80)
        cbx_p1_civilization.Name = "cbx_p1_civilization"
        cbx_p1_civilization.Size = New Size(104, 23)
        cbx_p1_civilization.TabIndex = 236
        ' 
        ' cbx_gaia_civilization
        ' 
        cbx_gaia_civilization.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_gaia_civilization.FormattingEnabled = True
        cbx_gaia_civilization.Items.AddRange(New Object() {"Achaemenids", "Armenians", "Athenians", "Aztecs", "Bengalis", "Berbers", "Bohemians", "Britons", "Bulgarians", "Burgundians", "Burmese", "Byzantines", "Celts", "Chinese", "Cumans", "Dravidians", "Ethiopians", "Franks", "Georgians", "Goths", "Gurjaras", "Hindustanis", "Huns", "Incas", "Italians", "Japanese", "Khmer", "Koreans", "Lithuanians", "Magyars", "Malay", "Malians", "Mayans", "Mongols", "Persians", "Poles", "Portuguese", "Romans", "Saracens", "Sicilians", "Slavs", "Spanish", "Spartans", "Tatars", "Teutons", "Turks", "Vietnamese", "Vikings", "Full Random", "Random"})
        cbx_gaia_civilization.Location = New Point(1016, 48)
        cbx_gaia_civilization.Name = "cbx_gaia_civilization"
        cbx_gaia_civilization.Size = New Size(104, 23)
        cbx_gaia_civilization.TabIndex = 235
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
        cbx_p8_ai_personality.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p8_ai_personality.FormattingEnabled = True
        cbx_p8_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p8_ai_personality.Location = New Point(896, 304)
        cbx_p8_ai_personality.Name = "cbx_p8_ai_personality"
        cbx_p8_ai_personality.Size = New Size(112, 23)
        cbx_p8_ai_personality.TabIndex = 233
        ' 
        ' cbx_p7_ai_personality
        ' 
        cbx_p7_ai_personality.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p7_ai_personality.FormattingEnabled = True
        cbx_p7_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p7_ai_personality.Location = New Point(896, 272)
        cbx_p7_ai_personality.Name = "cbx_p7_ai_personality"
        cbx_p7_ai_personality.Size = New Size(112, 23)
        cbx_p7_ai_personality.TabIndex = 232
        ' 
        ' cbx_p6_ai_personality
        ' 
        cbx_p6_ai_personality.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p6_ai_personality.FormattingEnabled = True
        cbx_p6_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p6_ai_personality.Location = New Point(896, 240)
        cbx_p6_ai_personality.Name = "cbx_p6_ai_personality"
        cbx_p6_ai_personality.Size = New Size(112, 23)
        cbx_p6_ai_personality.TabIndex = 231
        ' 
        ' cbx_p5_ai_personality
        ' 
        cbx_p5_ai_personality.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p5_ai_personality.FormattingEnabled = True
        cbx_p5_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p5_ai_personality.Location = New Point(896, 208)
        cbx_p5_ai_personality.Name = "cbx_p5_ai_personality"
        cbx_p5_ai_personality.Size = New Size(112, 23)
        cbx_p5_ai_personality.TabIndex = 230
        ' 
        ' cbx_p4_ai_personality
        ' 
        cbx_p4_ai_personality.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p4_ai_personality.FormattingEnabled = True
        cbx_p4_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p4_ai_personality.Location = New Point(896, 176)
        cbx_p4_ai_personality.Name = "cbx_p4_ai_personality"
        cbx_p4_ai_personality.Size = New Size(112, 23)
        cbx_p4_ai_personality.TabIndex = 229
        ' 
        ' cbx_p3_ai_personality
        ' 
        cbx_p3_ai_personality.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p3_ai_personality.FormattingEnabled = True
        cbx_p3_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p3_ai_personality.Location = New Point(896, 144)
        cbx_p3_ai_personality.Name = "cbx_p3_ai_personality"
        cbx_p3_ai_personality.Size = New Size(112, 23)
        cbx_p3_ai_personality.TabIndex = 228
        ' 
        ' cbx_p2_ai_personality
        ' 
        cbx_p2_ai_personality.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p2_ai_personality.FormattingEnabled = True
        cbx_p2_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p2_ai_personality.Location = New Point(896, 112)
        cbx_p2_ai_personality.Name = "cbx_p2_ai_personality"
        cbx_p2_ai_personality.Size = New Size(112, 23)
        cbx_p2_ai_personality.TabIndex = 227
        ' 
        ' cbx_gaia_ai_personality
        ' 
        cbx_gaia_ai_personality.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_gaia_ai_personality.FormattingEnabled = True
        cbx_gaia_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_gaia_ai_personality.Location = New Point(896, 48)
        cbx_gaia_ai_personality.Name = "cbx_gaia_ai_personality"
        cbx_gaia_ai_personality.Size = New Size(112, 23)
        cbx_gaia_ai_personality.TabIndex = 226
        ' 
        ' cbx_p1_ai_personality
        ' 
        cbx_p1_ai_personality.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p1_ai_personality.FormattingEnabled = True
        cbx_p1_ai_personality.Items.AddRange(New Object() {"None", "Standard (Promi)", "Standard (HD)", "Standard (CD)"})
        cbx_p1_ai_personality.Location = New Point(896, 80)
        cbx_p1_ai_personality.Name = "cbx_p1_ai_personality"
        cbx_p1_ai_personality.Size = New Size(112, 23)
        cbx_p1_ai_personality.TabIndex = 225
        ' 
        ' cbx_gaia_age
        ' 
        cbx_gaia_age.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_gaia_age.FormattingEnabled = True
        cbx_gaia_age.Location = New Point(104, 48)
        cbx_gaia_age.Name = "cbx_gaia_age"
        cbx_gaia_age.Size = New Size(100, 23)
        cbx_gaia_age.TabIndex = 224
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
        cbx_p8_age.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p8_age.FormattingEnabled = True
        cbx_p8_age.Location = New Point(104, 304)
        cbx_p8_age.Name = "cbx_p8_age"
        cbx_p8_age.Size = New Size(100, 23)
        cbx_p8_age.TabIndex = 222
        ' 
        ' cbx_p7_age
        ' 
        cbx_p7_age.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p7_age.FormattingEnabled = True
        cbx_p7_age.Location = New Point(104, 272)
        cbx_p7_age.Name = "cbx_p7_age"
        cbx_p7_age.Size = New Size(100, 23)
        cbx_p7_age.TabIndex = 221
        ' 
        ' cbx_p6_age
        ' 
        cbx_p6_age.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p6_age.FormattingEnabled = True
        cbx_p6_age.Location = New Point(104, 240)
        cbx_p6_age.Name = "cbx_p6_age"
        cbx_p6_age.Size = New Size(100, 23)
        cbx_p6_age.TabIndex = 220
        ' 
        ' cbx_p5_age
        ' 
        cbx_p5_age.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p5_age.FormattingEnabled = True
        cbx_p5_age.Location = New Point(104, 208)
        cbx_p5_age.Name = "cbx_p5_age"
        cbx_p5_age.Size = New Size(100, 23)
        cbx_p5_age.TabIndex = 219
        ' 
        ' cbx_p4_age
        ' 
        cbx_p4_age.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p4_age.FormattingEnabled = True
        cbx_p4_age.Location = New Point(104, 176)
        cbx_p4_age.Name = "cbx_p4_age"
        cbx_p4_age.Size = New Size(100, 23)
        cbx_p4_age.TabIndex = 218
        ' 
        ' cbx_p3_age
        ' 
        cbx_p3_age.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p3_age.FormattingEnabled = True
        cbx_p3_age.Location = New Point(104, 144)
        cbx_p3_age.Name = "cbx_p3_age"
        cbx_p3_age.Size = New Size(100, 23)
        cbx_p3_age.TabIndex = 217
        ' 
        ' cbx_p2_age
        ' 
        cbx_p2_age.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p2_age.FormattingEnabled = True
        cbx_p2_age.Location = New Point(104, 112)
        cbx_p2_age.Name = "cbx_p2_age"
        cbx_p2_age.Size = New Size(100, 23)
        cbx_p2_age.TabIndex = 216
        ' 
        ' cbx_p1_age
        ' 
        cbx_p1_age.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p1_age.FormattingEnabled = True
        cbx_p1_age.Location = New Point(104, 80)
        cbx_p1_age.Name = "cbx_p1_age"
        cbx_p1_age.Size = New Size(100, 23)
        cbx_p1_age.TabIndex = 215
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
        cbx_p8_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p8_color.FormattingEnabled = True
        cbx_p8_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p8_color.Location = New Point(568, 304)
        cbx_p8_color.Name = "cbx_p8_color"
        cbx_p8_color.Size = New Size(75, 23)
        cbx_p8_color.TabIndex = 184
        ' 
        ' cbx_p7_color
        ' 
        cbx_p7_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p7_color.FormattingEnabled = True
        cbx_p7_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p7_color.Location = New Point(568, 272)
        cbx_p7_color.Name = "cbx_p7_color"
        cbx_p7_color.Size = New Size(75, 23)
        cbx_p7_color.TabIndex = 183
        ' 
        ' cbx_p6_color
        ' 
        cbx_p6_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p6_color.FormattingEnabled = True
        cbx_p6_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p6_color.Location = New Point(568, 240)
        cbx_p6_color.Name = "cbx_p6_color"
        cbx_p6_color.Size = New Size(75, 23)
        cbx_p6_color.TabIndex = 182
        ' 
        ' cbx_p5_color
        ' 
        cbx_p5_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p5_color.FormattingEnabled = True
        cbx_p5_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p5_color.Location = New Point(568, 208)
        cbx_p5_color.Name = "cbx_p5_color"
        cbx_p5_color.Size = New Size(75, 23)
        cbx_p5_color.TabIndex = 181
        ' 
        ' cbx_p4_color
        ' 
        cbx_p4_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p4_color.FormattingEnabled = True
        cbx_p4_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p4_color.Location = New Point(568, 176)
        cbx_p4_color.Name = "cbx_p4_color"
        cbx_p4_color.Size = New Size(75, 23)
        cbx_p4_color.TabIndex = 180
        ' 
        ' cbx_p3_color
        ' 
        cbx_p3_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p3_color.FormattingEnabled = True
        cbx_p3_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p3_color.Location = New Point(568, 144)
        cbx_p3_color.Name = "cbx_p3_color"
        cbx_p3_color.Size = New Size(75, 23)
        cbx_p3_color.TabIndex = 179
        ' 
        ' cbx_p2_color
        ' 
        cbx_p2_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p2_color.FormattingEnabled = True
        cbx_p2_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p2_color.Location = New Point(568, 112)
        cbx_p2_color.Name = "cbx_p2_color"
        cbx_p2_color.Size = New Size(75, 23)
        cbx_p2_color.TabIndex = 178
        ' 
        ' cbx_p1_color
        ' 
        cbx_p1_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_p1_color.FormattingEnabled = True
        cbx_p1_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_p1_color.Location = New Point(568, 80)
        cbx_p1_color.Name = "cbx_p1_color"
        cbx_p1_color.Size = New Size(75, 23)
        cbx_p1_color.TabIndex = 177
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
        cbx_gaia_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_gaia_color.FormattingEnabled = True
        cbx_gaia_color.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow", "Cyan", "Purple", "Gray", "Orange"})
        cbx_gaia_color.Location = New Point(568, 48)
        cbx_gaia_color.Name = "cbx_gaia_color"
        cbx_gaia_color.Size = New Size(75, 23)
        cbx_gaia_color.TabIndex = 175
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
        cbx_total_players.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_total_players.FormattingEnabled = True
        cbx_total_players.Items.AddRange(New Object() {"1 Player", "2 Players", "3 Players", "4 Players", "5 Players", "6 Players", "7 Players", "8 Players"})
        cbx_total_players.Location = New Point(8, 16)
        cbx_total_players.Name = "cbx_total_players"
        cbx_total_players.Size = New Size(88, 23)
        cbx_total_players.TabIndex = 105
        ' 
        ' tp_objects
        ' 
        tp_objects.Controls.Add(lbl_object_player)
        tp_objects.Controls.Add(lbl_placed_objects)
        tp_objects.Controls.Add(lbl_object_y)
        tp_objects.Controls.Add(lbl_object_x)
        tp_objects.Controls.Add(lbl_object_list_b)
        tp_objects.Controls.Add(lbl_object_list_a)
        tp_objects.Controls.Add(lbl_important_note_units)
        tp_objects.Controls.Add(lbx_objects_2)
        tp_objects.Controls.Add(lbx_placed_objects)
        tp_objects.Controls.Add(lbx_map_y)
        tp_objects.Controls.Add(lbx_map_x)
        tp_objects.Controls.Add(cbx_object_player)
        tp_objects.Controls.Add(btn_remove_unit)
        tp_objects.Controls.Add(btn_create_unit)
        tp_objects.Controls.Add(lbx_objects_1)
        tp_objects.Location = New Point(4, 24)
        tp_objects.Name = "tp_objects"
        tp_objects.Padding = New Padding(3)
        tp_objects.Size = New Size(1448, 524)
        tp_objects.TabIndex = 3
        tp_objects.Text = "Objects"
        tp_objects.UseVisualStyleBackColor = True
        ' 
        ' lbl_object_player
        ' 
        lbl_object_player.AutoSize = True
        lbl_object_player.Location = New Point(760, 8)
        lbl_object_player.Name = "lbl_object_player"
        lbl_object_player.Size = New Size(39, 15)
        lbl_object_player.TabIndex = 229
        lbl_object_player.Text = "Player"
        lbl_object_player.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_placed_objects
        ' 
        lbl_placed_objects.AutoSize = True
        lbl_placed_objects.Location = New Point(600, 8)
        lbl_placed_objects.Name = "lbl_placed_objects"
        lbl_placed_objects.Size = New Size(85, 15)
        lbl_placed_objects.TabIndex = 228
        lbl_placed_objects.Text = "Placed Objects"
        lbl_placed_objects.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_object_y
        ' 
        lbl_object_y.AutoSize = True
        lbl_object_y.Location = New Point(544, 8)
        lbl_object_y.Name = "lbl_object_y"
        lbl_object_y.Size = New Size(14, 15)
        lbl_object_y.TabIndex = 227
        lbl_object_y.Text = "Y"
        lbl_object_y.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_object_x
        ' 
        lbl_object_x.AutoSize = True
        lbl_object_x.Location = New Point(488, 8)
        lbl_object_x.Name = "lbl_object_x"
        lbl_object_x.Size = New Size(14, 15)
        lbl_object_x.TabIndex = 226
        lbl_object_x.Text = "X"
        lbl_object_x.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_object_list_b
        ' 
        lbl_object_list_b.AutoSize = True
        lbl_object_list_b.Location = New Point(248, 8)
        lbl_object_list_b.Name = "lbl_object_list_b"
        lbl_object_list_b.Size = New Size(81, 15)
        lbl_object_list_b.TabIndex = 225
        lbl_object_list_b.Text = "Object List (B)"
        lbl_object_list_b.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_object_list_a
        ' 
        lbl_object_list_a.AutoSize = True
        lbl_object_list_a.Location = New Point(8, 8)
        lbl_object_list_a.Name = "lbl_object_list_a"
        lbl_object_list_a.Size = New Size(82, 15)
        lbl_object_list_a.TabIndex = 224
        lbl_object_list_a.Text = "Object List (A)"
        lbl_object_list_a.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_important_note_units
        ' 
        lbl_important_note_units.AutoSize = True
        lbl_important_note_units.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_important_note_units.Location = New Point(760, 96)
        lbl_important_note_units.Name = "lbl_important_note_units"
        lbl_important_note_units.Size = New Size(562, 63)
        lbl_important_note_units.TabIndex = 17
        lbl_important_note_units.Text = resources.GetString("lbl_important_note_units.Text")
        ' 
        ' lbx_objects_2
        ' 
        lbx_objects_2.FormattingEnabled = True
        lbx_objects_2.ItemHeight = 15
        lbx_objects_2.Items.AddRange(New Object() {"-1: None", "1588: City Gate", "1589: City Gate", "1590: City Gate", "1591: City Gate", "1592: City Gate", "1593: City Gate", "1594: City Gate", "1595: Projectile Laser", "1596: Cow B", "1597: Cow B (Dead)", "1598: Cow C", "1599: Cow C (Dead)", "1600: Cow D", "1601: Cow D (Dead)", "1602: Horse C", "1603: Horse C (Dead)", "1604: Horse D", "1605: Horse D (Dead)", "1606: Horse E", "1607: Horse E (Dead)", "1608: Butterflies1", "1609: Butterflies2", "1610: Butterflies3", "1611: Animal Blood Small", "1612: Animal Blood Large", "1613: Terrain blocker", "1614: Bolt explosion", "1615: Sforza (Dead)", "1616: Tariq Ibn Ziyad (Dead)", "1617: Vlad Dracula (Dead)", "1618: Subotai (Dead)", "1619: Attila (Dead)", "1620: Alaric (Dead)", "1621: Sumanguru (Dead)", "1622: Aachen Cathedral", "1623: Le Loi (Dead)", "1624: Ataulf (Dead)", "1625: Yodit (Dead)", "1626: Cusi Yupanqui (Dead)", "1627: Prithviraj (Dead)", "1628: Jarl (Dead)", "1629: Ivaylo (Dead)", "1630: Ivaylo Infantry (Dead)", "1631: The Middlebrook", "1632: Osman (Dead)", "1633: Pachacuti (Dead)", "1634: Baobab Stump", "1635: Waterfall (Background)", "1636: Envoy (Dead)", "1637: Bayinnaung (Dead)", "1638: Kushluk (Dead)", "1639: Monument resources enabler", "1640: Villager building (Male)", "1641: Villager building (Female)", "1642: Villager annex (Chinese)", "1643: Villager building2 (Male)", "1644: Villager annex (Mayan)", "1645: Villager building2 (Female)", "1646: Market", "1647: Trade Workshop", "1648: Trail Smoke (Gunpowder)", "1649: Trophy None", "1650: Trophy Bronze", "1651: Trophy Silver", "1652: Trophy Gold", "1653: Trophy Platinum", "1654: resources", "1655: Coustillier", "1656: Coustillier (Dead)", "1657: Elite Coustillier", "1658: Serjeant", "1659: Elite Serjeant", "1660: Serjeant", "1661: Elite Serjeant", "1662: Serjeant (Dead)", "1663: Flemish Militia Male ", "1664: Flemish Militia Male (Dead)", "1665: Donjon", "1666: HPIKL_D", "1667: Elite Elephant Archer (Dead)", "1668: Camel Scout (Dead)", "1669: Edward Longshanks", "1670: Edward Longshanks (Dead)", "1671: Gilbert de Clare", "1672: Gilbert de Clare (Dead)", "1673: John the Fearless", "1674: John the Fearless (Dead)", "1675: Philip the Good", "1676: Philip the Good (Dead)", "1677: Robert Guiscard", "1678: Robert Guiscard (Dead)", "1679: Roger Bosso", "1680: Roger Bosso (Dead)", "1681: Bohemond", "1682: Bohemond (Dead)", "1683: Llywelyn ap Gruffydd", "1684: Llywelyn ap Gruffydd (Dead)", "1685: Dafydd ap Gruffydd", "1686: Dafydd ap Gruffydd (Dead)", "1687: Bernard d'Armagnac", "1688: Bernard d'Armagnac (Dead)", "1689: Flare (Permanent)", "1690: Warwolf Trebuchet", "1691: Warwolf Trebuchet (Packed)", "1692: Jacqueline of Hainaut", "1693: Sheep building1", "1694: Sheep annex1", "1695: Sheep building2", "1696: Sheep annex2", "1697: Flemish Militia Female", "1698: Flemish Militia Female (Dead)", "1699: Flemish Militia", "1700: Sheep building3", "1701: Obuch", "1702: Obuch (Dead)", "1703: Elite Obuch", "1704: Hussite Wagon", "1705: Hussite Wagon (Dead)", "1706: Elite Hussite Wagon", "1707: Winged Hussar", "1708: Winged Hussar (Dead)", "1709: Houfnice", "1710: Houfnice (Dead)", "1711: Folwark", "1712: Pagan Shrine", "1713: Jan Zizka", "1714: Jan Zizka (Dead)", "1715: Jadwiga", "1716: Jadwiga (Dead)", "1717: Tree (Birch)", "1718: Jogaila", "1719: Jogaila (Dead)", "1720: Folwark", "1721: Kestutis", "1722: Kestutis (Dead)", "1723: Crusader Knight", "1724: Crusader Knight (Dead)", "1725: Algirdas", "1726: Algirdas (Dead)", "1727: Ulrich von Jungingen", "1728: Ulrich von Jungingen (Dead)", "1729: Emperor Sigismund", "1730: Dmitry of Moscow", "1731: Mikhail of Tver", "1732: Young Jadwiga", "1733: Projectile Hussite Wagon", "1734: Folwark", "1735: Urumi Swordsman", "1736: Urumi Swordsman (Dead)", "1737: Elite Urumi Swordsman", "1738: Ratha (Melee)", "1739: Ratha (Melee) (Dead)", "1740: Elite Ratha (Melee)", "1741: Chakram Thrower", "1742: Chakram Thrower (Dead)", "1743: Elite Chakram Thrower", "1744: Armored Elephant", "1745: Armored Elephant (Dead)", "1746: Siege Elephant", "1747: Ghulam", "1748: Ghulam (Dead)", "1749: Elite Ghulam", "1750: Thirisadai", "1751: Shrivamsha Rider", "1752: Shrivamsha Rider (Dead)", "1753: Elite Shrivamsha Rider", "1754: Caravanserai", "1755: Camel Scout", "1756: Projectile Chakram", "1757: Siege Elephant (Dead)", "1758: Gaia transition building", "1759: Ratha (Ranged)", "1760: Ratha (Ranged) (Dead)", "1761: Elite Ratha (Ranged)", "1762: Mihira Bhoja", "1763: Amoghavarsha", "1764: Rajendra Chola", "1765: Rajendra Chola (Dead)", "1766: General Araiyan", "1767: General Araiyan (Dead)", "1768: Young Babur", "1769: Qutlugh", "1770: Qutlugh (Dead)", "1771: Ibrahim Lodi", "1772: Shaybani Khan", "1773: Minaret of Jam", "1774: Map Revealer Medium", "1775: Map Revealer Giant", "1776: Blocker", "1777: Indian Statues", "1778: Rekha-Deul Temple", "1779: Projectile Thirisadai", "1780: Projectile Thirisadai (Fire)", "1781: Projectile Elephant Archer", "1782: Projectile Elephant Archer (Fire)", "1783: -", "1784: Indian Ruins", "1785: Flare B (Permanent)", "1786: Spearman", "1787: Pikeman", "1788: Halberdier", "1789: Projectile Organ Gun (Secondary)", "1790: Centurion", "1791: Centurion (Dead)", "1792: Elite Centurion", "1793: Legionary", "1794: Legionary (Dead)", "1795: Dromon", "1796: Gazelle", "1797: Gazelle (Dead)", "1798: Projectile Dromon (Greek Fire)", "1799: Trail Smoke (Fire)", "1800: Composite Bowman", "1801: Composite Bowman (Dead)", "1802: Elite Composite Bowman", "1803: Monaspa", "1804: Monaspa (Dead)", "1805: Elite Monaspa", "1806: Fortified Church", "1807: Svan Tower", "1808: Mule Cart", "1809: Mule Cart (Dead)", "1810: Villager", "1811: Warrior Priest", "1812: Warrior Priest (Dead)", "1813: Savar", "1814: Savar (Dead)", "1815: Shah Ismail", "1816: Shah Ismail (Dead)", "1817: Qizilbash Warrior", "1818: Qizilbash Warrior (Dead)", "1819: Ismail", "1820: Selim the Grim", "1821: Thoros", "1822: Tamar", "1823: Tamar (Dead)", "1824: Yury", "1825: Ivane", "1826: Zakare", "1827: Stephan", "1828: Mleh", "1829: Elite Qizilbash Warrior", "1830: Projectile Citadels", "1831: Warrior Priest with Relic", "1832: Yurt I", "1833: Yurt J", "1834: Yurt K", "1835: Yurt L", "1836: Chapel", "1837: Castle Ruins", "1838: Church Ruins", "1839: Bridge Piece--End A", "1840: Bridge Piece--End B", "1841: Bridge Piece--End C", "1842: Bridge Piece--Middle", "1843: Bridge Piece--Broken A", "1844: Bridge Piece--Broken B", "1845: Bridge Piece--Broken C", "1846: Bridge Piece--Cracked", "1847: Bridge Piece--Rails", "1848: Thoros (Dead)", "1849: Cliff (Desert) 01", "1850: Cliff (Desert) 02", "1851: Cliff (Desert) 03", "1852: Cliff (Desert) 04", "1853: Cliff (Desert) 05", "1854: Cliff (Desert) 06", "1855: Cliff (Desert) 07", "1856: Cliff (Desert) 08", "1857: Cliff (Desert) 09", "1858: Cliff (Snow) 01", "1859: Cliff (Snow) 02", "1860: Cliff (Snow) 03", "1861: Cliff (Snow) 04", "1862: Cliff (Snow) 05", "1863: Cliff (Snow) 06", "1864: Cliff (Snow) 07", "1865: Cliff (Snow) 08", "1866: Cliff (Snow) 09", "1867: Projectile SVT", "1868: Projectile SVT (Fire)", "1869: Hunnic Horse", "1870: -", "1871: -", "1872: -", "1873: -", "1874: -", "1875: -", "1876: -", "1877: -", "1878: -", "1879: -", "1880: -", "1881: -", "1882: -", "1883: -", "1884: -", "1885: -", "1886: -", "1887: -", "1888: -", "1889: -", "1890: -", "1891: -", "1892: -", "1893: -", "1894: -", "1895: -", "1896: -", "1897: -", "1898: -", "1899: -", "1900: -", "1901: -", "1902: -", "1903: -", "1904: -", "1905: -", "1906: -", "1907: -", "1908: -", "1909: -", "1910: -", "1911: -", "1912: -", "1913: -", "1914: -", "1915: -", "1916: -", "1917: -", "1918: -", "1919: -", "1920: -", "1921: -", "1922: -", "1923: -", "1924: -", "1925: -", "1926: -", "1927: -", "1928: -", "1929: -", "1930: -", "1931: -", "1932: -", "1933: -", "1934: -", "1935: -", "1936: -", "1937: -", "1938: -", "1939: -", "1940: -", "1941: -", "1942: -", "1943: -", "1944: -", "1945: -", "1946: -", "1947: -", "1948: -", "1949: -", "1950: -", "1951: -", "1952: -", "1953: -", "1954: -", "1955: -", "1956: -", "1957: -", "1958: -", "1959: -", "1960: -", "1961: -", "1962: -", "1963: -", "1964: -", "1965: -", "1966: -", "1967: -", "1968: -", "1969: -", "1970: -", "1971: -", "1972: -", "1973: -", "1974: -", "1975: -", "1976: -", "1977: -", "1978: -", "1979: -", "1980: -", "1981: -", "1982: -", "1983: -", "1984: -", "1985: -", "1986: -", "1987: -", "1988: -", "1989: -", "1990: -", "1991: -", "1992: -", "1993: -", "1994: -", "1995: -", "1996: -", "1997: -", "1998: -", "1999: -", "2000: -", "2001: -", "2002: -", "2003: -", "2004: -", "2005: -", "2006: -", "2007: -", "2008: -", "2009: -", "2010: -", "2011: -", "2012: -", "2013: -", "2014: -", "2015: -", "2016: -", "2017: -", "2018: -", "2019: -", "2020: -", "2021: -", "2022: -", "2023: -", "2024: -", "2025: -", "2026: -", "2027: -", "2028: -", "2029: -", "2030: -", "2031: -", "2032: -", "2033: -", "2034: -", "2035: -", "2036: -", "2037: -", "2038: -", "2039: -", "2040: -", "2041: -", "2042: -", "2043: -", "2044: -", "2045: -", "2046: -", "2047: -", "2048: -", "2049: -", "2050: -", "2051: -", "2052: -", "2053: -", "2054: -", "2055: -", "2056: -", "2057: -", "2058: -", "2059: -", "2060: -", "2061: -", "2062: -", "2063: -", "2064: -", "2065: -", "2066: -", "2067: -", "2068: -", "2069: -", "2070: -", "2071: -", "2072: -", "2073: -", "2074: -", "2075: -", "2076: -", "2077: -", "2078: -", "2079: -", "2080: -", "2081: -", "2082: -", "2083: -", "2084: -", "2085: -", "2086: -", "2087: -", "2088: -", "2089: -", "2090: -", "2091: -", "2092: -", "2093: -", "2094: -", "2095: -", "2096: -", "2097: -", "2098: -", "2099: -", "2100: -", "2101: Immortal", "2102: Elite Immortal", "2103: Immortal (Dead)", "2104: Strategos", "2105: Elite Strategos", "2106: Strategos (Dead)", "2107: Hippeus", "2108: Elite Hippeus", "2109: Hippeus (Dead)", "2110: Hoplite", "2111: Elite Hoplite", "2112: Hoplite (Dead)", "2113: -", "2114: -", "2115: -", "2116: -", "2117: Shipyard3", "2118: Shipyard4", "2119: Shipyard2", "2120: Dock", "2121: Dock", "2122: Dock", "2123: Lembos", "2124: War Lembos", "2125: Heavy Lembos", "2126: Elite Lembos", "2127: Monoreme", "2128: Bireme", "2129: Trireme", "2130: Galley - Antiquity", "2131: War Galley - Antiquity", "2132: Elite Galley", "2133: Incendiary Raft", "2134: Incendiary Ship", "2135: Heavy Incendiary Ship", "2136: -", "2137: -", "2138: Catapult Ship", "2139: Onager Ship", "2140: Leviathan", "2141: Port 4", "2142: Port 3", "2143: Port 2", "2144: Dock", "2145: Dock", "2146: Dock", "2147: FSHSP", "2148: XPORT", "2149: Merchant Ship", "2150: War Chariot", "2151: Elite War Chariot", "2152: -", "2153: -", "2154: -", "2155: -", "2156: -", "2157: -", "2158: -", "2159: -", "2160: -", "2161: -", "2162: Polemarch 1", "2163: Basileus (Dead)", "2164: Polemarch 2", "2165: Polemarch 3", "2166: Polemarch 4", "2167: Polemarch 3 with Ephorate", "2168: Hippeus", "2169: Elite Hippeus", "2170: Oysters", "2171: Oystering Ship", "2172: Port 1", "2173: Dock", "2174: Immortal Ranged", "2175: Elite Immortal Ranged", "2176: Greek Army Tent A", "2177: Greek Army Tent A (Rubble)", "2178: Marble Cliff 1", "2179: Marble Cliff 2", "2180: Marble Cliff 3", "2181: Marble Cliff 4", "2182: Marble Cliff 5", "2183: Marble Cliff 6", "2184: Marble Cliff 7", "2185: Marble Cliff 8", "2186: Marble Cliff 9", "2187: Hoplite with Xyphos", "2188: Elite Hoplite with Xyphos", "2189: -", "2190: Short Marble Cliff 1", "2191: Short Marble Cliff 2", "2192: Short Marble Cliff 3", "2193: Short Marble Cliff 4", "2194: Short Marble Cliff 5", "2195: Short Marble Cliff 6", "2196: Short Marble Cliff 7", "2197: Short Marble Cliff 8", "2198: Short Marble Cliff 9", "2199: Short Cliff 1", "2200: Short Cliff 2", "2201: Short Cliff 3", "2202: Short Cliff 4", "2203: Short Cliff 5", "2204: Short Cliff 6", "2205: Short Cliff 7", "2206: Short Cliff 8", "2207: Short Cliff 9", "2208: Short Sand Cliff 1", "2209: Short Sand Cliff 2", "2210: Short Sand Cliff 3", "2211: Short Sand Cliff 4", "2212: Short Sand Cliff 5", "2213: Short Sand Cliff 6", "2214: Short Sand Cliff 7", "2215: Short Sand Cliff 8", "2216: Short Sand Cliff 9", "2217: Short Snow Cliff 1", "2218: Short Snow Cliff 2", "2219: Short Snow Cliff 3", "2220: Short Snow Cliff 4", "2221: Short Snow Cliff 5", "2222: Short Snow Cliff 6", "2223: Short Snow Cliff 7", "2224: Short Snow Cliff 8", "2225: Short Snow Cliff 9", "2226: Projectile Leviathan", "2227: Strategos with Taxiarchs", "2228: Elite Strategos with Taxiarchs", "2229: Government cost change", "2230: First Government cost change", "2231: Second Government cost change", "2232: Third Government cost change", "2233: Fourth Government cost change", "2234: Mediterranean Ruins", "2235: Mediterranean Courtyard Walls", "2236: Lembos spawner", "2237: Lembos spawner part 2", "2238: AI Hint Object", "2239: -", "2240: -", "2241: -", "2242: -", "2243: -", "2244: -", "2245: -", "2246: -", "2247: -", "2248: -", "2249: -", "2250: -", "2251: Mesopotamian Pillar", "2252: Mesopotamian Garden", "2253: Achaemenid Flag 1", "2254: Achaemenid Flag 2", "2255: Achaemenid Flag 3", "2256: Athenian Flag 1", "2257: Athenian Flag 2", "2258: Athenian Flag 3", "2259: Spartan Flag 1", "2260: Spartan Flag 2", "2261: Spartan Flag 3", "2262: Greek Commander Tent A", "2263: Greek Commander Tent A (Rubble)", "2264: Statue Athena Marble", "2265: Statue Athena Painted", "2266: -", "2267: -", "2268: -", "2269: -", "2270: Polemarch 4 with Ephorate", "2271: Polemarch 3 with Morai", "2272: Polemarch 4 with Morai", "2273: Spawn Basileus", "2274: Archaic Fence", "2275: Economic Satrapy", "2276: Defensive Satrapy", "2277: Military Satrapy", "2278: Garden Hedge", "2279: Statue Ares Marble", "2280: Statue Ares Painted", "2281: Sapper Tunnel", "2282: Siege Camp Equipment", "2283: Siege Camp Weapons", "2284: Market Stall", "2285: Stake Barricade", "2286: Tropaion", "2287: Mesopotamian Tomb", "2288: Fire Shrine", "2289: Treasure Chest", "2290: Grapevine", "2291: Leatherworking Equipment", "2292: Antiquity Broken Cart", "2293: Weapon Rack", "2294: Sacred Tree", "2295: -", "2296: -", "2297: -", "2298: -", "2299: -", "2300: -", "2301: Elite Hoplite (Dead)", "2302: War Chariot (Dead)", "2303: Elite War Chariot (Dead)", "2304: Ranged Immortal (Dead)", "2305: -", "2306: Hero Shrine", "2307: Projectile Gastraphetes", "2308: Artaphernes", "2309: Datis", "2310: Aristagoras", "2311: Dionysus", "2312: Artemisia", "2313: Aristides", "2314: Miltiades", "2315: Themistocles", "2316: Leonidas", "2317: Brasidas", "2318: Lysander", "2319: The Aeginetan", "2320: Rhodian Slinger", "2321: Mercenary Hoplite", "2322: Elite Greek Cavalry", "2323: Elite Persian Cavalry", "2324: Elite Persian Archer", "2325: Ekdromos", "2326: Cretan Archer", "2327: Camel Raider", "2328: Tarantine Cavalry", "2329: Sparabara", "2330: Takabara", "2331: Sickle Warrior", "2332: Thracian Peltast", "2333: Villager Male Oyster Gatherer", "2334: Villager Female Oyster Gatherer", "2335: -", "2336: -", "2337: -", "2338: -", "2339: Themistocles Warship", "2340: Mouflon", "2341: Mouflon (Dead)", "2342: Projectile Polycritus", "2343: Military Satrapy Flag", "2344: Defensive Satrapy Flag", "2345: Economic Satrapy Flag", "2346: Cleon", "2347: Darius", "2348: Oracle Temple", "2349: Elite Hoplite", "2350: Mesopotamian Ruins", "2351: Tholos Shrine", "2352: Antiquity Transport Shipwreck", "2353: Leviathan Shipwreck", "2354: Galley Shipwreck", "2355: Catapult Shipwreck", "2356: Antiquity Mode Fishing Ship", "2357: Ekdromos (Dead)", "2358: Sakan Axeman (Dead)", "2359: Brasidas (Dead)", "2360: Themistocles (Dead)", "2361: Mercenary Hoplite (Dead)", "2362: Sickle Warrior (Dead)", "2363: Artaphernes (Dead)", "2364: Datis (Dead)", "2365: Cretan Archer (Dead)", "2366: Bactrian Archer (Dead)", "2367: Rhodian Slinger (Dead)", "2368: Camel Raider (Dead)", "2369: Greek Noble Cavalry (Dead)", "2370: Aristagoras (Dead)", "2371: Lysander (Dead)", "2372: Sparabara (Dead)", "2373: Aura Quest Indicator (Lavender)", "2374: Scythian Axe Cavalry (Dead)", "2375: Tarantine Cavalry (Dead)", "2376: Aristides (Dead)", "2377: Thracian Peltast (Dead)", "2378: Aura Quest Indicator (Shells)", "2379: Aura Quest Indicator (Coins)", "2380: Aura Quest Indicator (Gold and Shells)", "2381: GOAT"})
        lbx_objects_2.Location = New Point(248, 32)
        lbx_objects_2.Name = "lbx_objects_2"
        lbx_objects_2.Size = New Size(235, 469)
        lbx_objects_2.TabIndex = 16
        ' 
        ' lbx_placed_objects
        ' 
        lbx_placed_objects.FormattingEnabled = True
        lbx_placed_objects.ItemHeight = 15
        lbx_placed_objects.Location = New Point(600, 32)
        lbx_placed_objects.Name = "lbx_placed_objects"
        lbx_placed_objects.ScrollAlwaysVisible = True
        lbx_placed_objects.Size = New Size(152, 469)
        lbx_placed_objects.TabIndex = 15
        ' 
        ' lbx_map_y
        ' 
        lbx_map_y.FormattingEnabled = True
        lbx_map_y.ItemHeight = 15
        lbx_map_y.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365", "366", "367", "368", "369", "370", "371", "372", "373", "374", "375", "376", "377", "378", "379", "380", "381", "382", "383", "384", "385", "386", "387", "388", "389", "390", "391", "392", "393", "394", "395", "396", "397", "398", "399", "400", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "418", "419", "420", "421", "422", "423", "424", "425", "426", "427", "428", "429", "430", "431", "432", "433", "434", "435", "436", "437", "438", "439", "440", "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454", "455", "456", "457", "458", "459", "460", "461", "462", "463", "464", "465", "466", "467", "468", "469", "470", "471", "472", "473", "474", "475", "476", "477", "478", "479"})
        lbx_map_y.Location = New Point(544, 32)
        lbx_map_y.Name = "lbx_map_y"
        lbx_map_y.Size = New Size(48, 469)
        lbx_map_y.TabIndex = 14
        ' 
        ' lbx_map_x
        ' 
        lbx_map_x.FormattingEnabled = True
        lbx_map_x.ItemHeight = 15
        lbx_map_x.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365", "366", "367", "368", "369", "370", "371", "372", "373", "374", "375", "376", "377", "378", "379", "380", "381", "382", "383", "384", "385", "386", "387", "388", "389", "390", "391", "392", "393", "394", "395", "396", "397", "398", "399", "400", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "418", "419", "420", "421", "422", "423", "424", "425", "426", "427", "428", "429", "430", "431", "432", "433", "434", "435", "436", "437", "438", "439", "440", "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454", "455", "456", "457", "458", "459", "460", "461", "462", "463", "464", "465", "466", "467", "468", "469", "470", "471", "472", "473", "474", "475", "476", "477", "478", "479"})
        lbx_map_x.Location = New Point(488, 32)
        lbx_map_x.Name = "lbx_map_x"
        lbx_map_x.Size = New Size(48, 469)
        lbx_map_x.TabIndex = 13
        ' 
        ' cbx_object_player
        ' 
        cbx_object_player.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_object_player.FormattingEnabled = True
        cbx_object_player.Items.AddRange(New Object() {"Gaia", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6", "Player 7", "Player 8"})
        cbx_object_player.Location = New Point(760, 32)
        cbx_object_player.Name = "cbx_object_player"
        cbx_object_player.Size = New Size(121, 23)
        cbx_object_player.TabIndex = 4
        ' 
        ' btn_remove_unit
        ' 
        btn_remove_unit.Location = New Point(888, 64)
        btn_remove_unit.Name = "btn_remove_unit"
        btn_remove_unit.Size = New Size(75, 25)
        btn_remove_unit.TabIndex = 3
        btn_remove_unit.Text = "Remove Unit"
        btn_remove_unit.UseVisualStyleBackColor = True
        ' 
        ' btn_create_unit
        ' 
        btn_create_unit.Location = New Point(888, 32)
        btn_create_unit.Name = "btn_create_unit"
        btn_create_unit.Size = New Size(75, 25)
        btn_create_unit.TabIndex = 2
        btn_create_unit.Text = "Create"
        btn_create_unit.UseVisualStyleBackColor = True
        ' 
        ' lbx_objects_1
        ' 
        lbx_objects_1.FormattingEnabled = True
        lbx_objects_1.ItemHeight = 15
        lbx_objects_1.Items.AddRange(New Object() {"-1: None", "0: Moveable Map Revealer", "1: Imperial Legionary", "2: Imperial Legionary (Dead)", "3: Archer (Dead)", "4: Archer", "5: Hand Cannoneer", "6: Elite Skirmisher", "7: Skirmisher", "8: Longbowman", "9: Arrow", "10: Archery Range", "11: Mangudai", "12: Barracks", "13: Fishing Ship", "14: Archery Range", "15: Junk", "16: Bombard Cannon (Dead)", "17: Trade Cog", "18: Blacksmith", "19: Blacksmith", "20: Barracks", "21: War Galley", "22: Beta Berserk (Dead)", "23: Battering Ram (Dead)", "24: Crossbowman", "25: Teutonic Knight", "26: Crossbowman (Dead)", "27: Cataphract (Dead)", "28: Chu Ko Nu (Dead)", "29: Trading Cog (Dead)", "30: Monastery", "31: Monastery", "32: Monastery", "33: Fortress", "34: Cavalry Archer (Dead)", "35: Battering Ram", "36: Bombard Cannon", "37: Camel Rider", "38: Knight", "39: Cavalry Archer", "40: Cataphract", "41: Huskarl", "42: Trebuchet", "43: Deer (Dead)", "44: Mameluke (Dead)", "45: Dock", "46: Janissary", "47: Dock", "48: Wild Boar", "49: Siege Workshop", "50: Farm", "51: Dock", "52: Royal Janissary", "53: Fish (Perch)", "54: Projectile VOL", "55: Fishing Ship (Dead)", "56: Villager Male Fisherman", "57: Villager Female Fisherman", "58: Villager Male Fisherman (Dead)", "59: Forage Bush", "60: Villager Female Fisherman (Dead)", "61: Dolphin", "62: Huskarl (Dead)", "63: Fortified Gate (up.)", "64: Gate (up.)", "65: Deer", "66: Gold Mine", "67: Fortified Gate", "68: Mill", "69: Shore Fish", "70: House", "71: Town Center", "72: Palisade Wall", "73: Chu Ko Nu", "74: Militia", "75: Man-at-Arms", "76: Heavy Swordsman", "77: Long Swordsman", "78: Gate", "79: Watch Tower", "80: Fortified Gate", "81: Gate", "82: Castle", "83: Villager (Male)", "84: Market", "85: Fortified Gate (down.)", "86: Stable", "87: Archery Range", "88: Gate (down.)", "89: Dire Wolf", "90: Fortified Gate", "91: Gate", "92: Fortified Gate", "93: Spearman", "94: Beta Berserk", "95: Gate", "96: Hawk", "97: Arrow", "98: Hand Cannoneer (Dead)", "99: Heavy Swordsman (Dead)", "100: Elite Skirmisher (Dead)", "101: Stable", "102: Stone Mine", "103: Blacksmith", "104: Monastery", "105: Blacksmith", "106: Leif Erikson", "107: Janissary (Dead)", "108: Junk (Dead)", "109: Town Center", "110: Trade Workshop", "111: Knight (Dead)", "112: Flare", "113: Camel Rider (Dead)", "114: Stoertebeker", "115: Longbowman (Dead)", "116: Market", "117: Stone Wall", "118: Villager Male Builder", "119: Fortified Palisade Wall", "120: Villager Male Forager", "121: Mangonel (Dead)", "122: Villager Male Hunter", "123: Villager Male Lumberjack", "124: Villager Male Stone Miner", "125: Monk", "126: Wolf", "127: OLD_EXPLORER", "128: Trade Cart (Empty)", "129: Mill", "130: Mill", "131: Mill", "132: Barracks", "133: Dock", "134: Monk (Dead)", "135: Mangudai (Dead)", "136: War Elephant (Dead)", "137: Market", "138: Spy", "139: Cavalier (Dead)", "140: Spearman (Dead)", "141: Town Center", "142: Town Center", "143: Rubble 1 x 1", "144: Rubble 2 x 2", "145: Rubble 3 x 3", "146: Rubble 4 x 4", "147: Rubble 6 x 6", "148: Rubble 8 x 8", "149: Scorpion (Dead)", "150: Siege Workshop", "151: Samurai (Dead)", "152: Militia (Dead)", "153: Stable", "154: Man-At-Arms (Dead)", "155: Fortified Wall", "156: Villager Repairer Male", "157: Throwing Axeman (Dead)", "158: Outlaw", "159: Relic Cart", "160: Richard the Lionheart", "161: The Black Prince", "162: FLAGX", "163: Friar Tuck", "164: Sheriff of Nottingham", "165: Charlemagne", "166: Roland", "167: Belisarius", "168: Theodoric the Goth", "169: Aethelfrith", "170: Siegfried", "171: Erik the Red", "172: Tamerlane", "173: King Arthur", "174: Lancelot", "175: Gawain", "176: Mordred", "177: Archbishop", "178: Trade Cart Empty (Dead)", "179: Trade Workshop", "180: Long Swordsman (Dead)", "181: Teutonic Knight (Dead)", "182: WNDR", "183: TMISB", "184: Condottiero", "185: Slinger", "186: Slinger (Dead)", "187: Projectile Slinger", "188: Flamethrower", "189: Flamethrower (Dead)", "190: Fire Tower", "191: House", "192: House", "193: Vlad Dracula", "194: Trebuchet (Dead)", "195: Kitabatake", "196: Minamoto", "197: Alexander Nevski", "198: El Cid", "199: Fish Trap", "200: Robin Hood", "201: Tree", "202: Rabid Wolf", "203: Vasco da Gama", "204: Trade Cart (Full)", "205: Trade Cart (Full) (Dead)", "206: VMDL", "207: Imperial Camel Rider", "208: TWAL", "209: University", "210: University", "211: Villager Female (Dead)", "212: Villager Female Builder", "213: Villager Female Builder (Dead)", "214: Villager Female Farmer", "215: Villager Female Farmer (Dead)", "216: Villager Female Hunter", "217: Villager Female Hunter (Dead)", "218: Villager Female Lumberjack", "219: Villager Female Lumberjack (Dead)", "220: Villager Female Stone Miner", "221: Villager Female Stone Miner (Dead)", "222: Villager Female Repairer", "223: Alaric the Goth", "224: Villager Male (Dead)", "225: Villager Male Builder (Dead)", "226: Villager Male Farmer (Dead)", "227: Villager Male Hunter (Dead)", "228: Villager Male Lumberjack (Dead)", "229: Villager Male Stone Miner (Dead)", "230: King Bela IV", "231: Aqueduct", "232: Woad Raider", "233: Woad Raider (Dead)", "234: Guard Tower", "235: Keep", "236: Bombard Tower", "237: Wolf (Dead)", "238: Skirmisher (Dead)", "239: War Elephant", "240: TERRC", "241: Cracks", "242: Projectile Stone Catapult", "243: Doppelganger", "244: Projectile Stone Catapult (Fire)", "245: Projectile Bolt", "246: Projectile Bolt (Fire)", "247: Trail Smoke", "248: Pile of Stone", "249: POREX", "250: Longboat", "251: Amphitheatre", "252: Pile of Gold", "253: Pile of Wood", "254: PILE1", "255: PILE2", "256: PILE3", "257: PILE4", "258: PILE6", "259: Villager Male Farmer", "260: Disabled", "261: PILE8", "262: Pile of Food", "263: Colosseum", "264: Cliff 1", "265: Cliff 2", "266: Cliff 3", "267: Cliff 4", "268: Cliff 5", "269: Cliff 6", "270: Cliff 7", "271: Cliff 8", "272: Cliff 9", "273: -", "274: Flare", "275: Imperial Centurion", "276: Wonder", "277: Imperial Centurion (Dead)", "278: Fish Trap (Dead)", "279: Scorpion", "280: Mangonel", "281: Throwing Axeman", "282: Mameluke", "283: Cavalier", "284: Tree TD", "285: Relic", "286: Monk with Relic", "287: British Relic", "288: Byzantine Relic", "289: Chinese Relic", "290: Frankish Relic", "291: Samurai", "292: Gothic Relic", "293: Villager (Female)", "294: Japanese Relic", "295: Persian Relic", "296: Saracen Relic", "297: Teutonic Relic", "298: Turkish Relic", "299: Bandit", "300: Imperial Camel Rider (Dead)", "301: Grass Patch, Green", "302: Bush A", "303: Seagulls", "304: Bonfire", "305: Llama", "306: Black Tile", "307: Cuauhtemoc", "308: Indestructible Outpost", "309: Monk with Turkish Relic", "310: Mountain 1", "311: Mountain 2", "312: Projectile Arrow 2", "313: Projectile Stone, Trebuchet", "314: Projectile Stone, Mangonel", "315: Projectile Arrow 3", "316: Projectile Arrow 4", "317: Projectile Arrow 5", "318: Projectile Arrow 6", "319: Projectile Arrow 7", "320: Projectile Arrow 8", "321: Projectile Arrow 9", "322: Projectile Arrow 10", "323: Projectile Stone, Catapult 1", "324: Projectile Stone, Catapult 2", "325: Projectile Stone, Catapult 3", "326: Projectile Stone, Catapult 4", "327: Projectile Stone, Catapult 5", "328: Projectile VOL (Fire)", "329: Camel Rider", "330: Heavy Camel Rider", "331: Trebuchet (Packed)", "332: Flare", "333: Deer", "334: Flowers 1", "335: Flowers 2", "336: Flowers 3", "337: Flowers 4", "338: Path 4", "339: Path 1", "340: Path 2", "341: Path 3", "342: Cuman Chief", "343: TERRV", "344: TERRW", "345: Ruins", "346: TERRY", "347: TERRZ", "348: Tree (Bamboo Forest)", "349: Tree (Oak)", "350: Tree (Pine Forest)", "351: Tree (Palm Forest)", "352: OREMN", "353: Villager Male Forager (Dead)", "354: Villager Female Forager", "355: Villager Female Forager (Dead)", "356: Boar (Dead)", "357: Farm (Dead)", "358: Pikeman", "359: Halberdier", "360: Projectile Arrow (Fire)", "361: Norse Warrior", "362: Norse Warrior (Dead)", "363: Projectile Archer", "364: Projectile Crossbowman", "365: Projectile Skirmisher", "366: Projectile Elite Skirmisher", "367: Projectile Scorpion", "368: Projectile Bombard Cannon", "369: Projectile Mangonel (Secondary)", "370: City Wall", "371: Projectile Trebuchet", "372: Projectile Galleon", "373: Projectile War Galley", "374: Projectile Cannon Galleon", "375: Projectile Crossbowman (Fire)", "376: Projectile Skirmisher (Fire)", "377: Projectile Elite Skirmisher (Fire)", "378: Projectile Scorpion (Fire)", "379: -", "380: Projectile Gunpowder (Primary)", "381: Projectile Bolt (Fire)", "382: -", "383: -", "384: -", "385: Projectile Bolt (Fire)", "386: -", "387: -", "388: -", "389: Sea Rocks 1", "390: TERRB", "391: TERRD", "392: TERRE", "393: TERRF", "394: TERRH", "395: TERRI", "396: Sea Rocks 2", "397: TERRK", "398: TERRL", "399: Tree A", "400: Tree B", "401: Tree C", "402: Tree D", "403: Tree E", "404: Tree F", "405: Tree G", "406: Tree H", "407: Tree I", "408: Tree J", "409: Tree K", "410: Tree L", "411: Tree (Oak Forest)", "412: Monk (Dead)", "413: Tree (Snow Pine)", "414: Tree (Jungle)", "415: Stump", "416: Debris", "417: Dust C", "418: Henry the Lion", "419: Debris B", "420: Cannon Galleon", "421: Cannon Galleon (Dead)", "422: Capped Ram", "423: Capped Ram (Dead)", "424: Charles Martel", "425: Francisco de Orellana", "426: Harald Hardraade", "427: Gonzalo Pizarro", "428: Hrolf the Ganger", "429: Frederick Barbarossa", "430: Joan the Maid", "431: Joan the Maid (Dead)", "432: William Wallace", "433: William Wallace (Dead)", "434: King", "435: King (Dead)", "436: OMTBO", "437: Prithviraj", "438: STRBO", "439: Francesco Sforza", "440: Petard", "441: Hussar", "442: Galleon", "443: Galleon (Dead)", "444: Town Center (Packed)", "445: Poenari Castle", "446: Port", "447: SHALW", "448: Scout Cavalry", "449: Scout Cavalry (Dead)", "450: Great Fish (Marlin1)", "451: Great Fish (Marlin2)", "452: Dolphin", "453: Ataulf", "454: DOLP5", "455: Fish (Dorado)", "456: Fish (Salmon)", "457: Fish (Tuna)", "458: Fish (Snapper)", "459: FISH5", "460: WHAL1", "461: WHAL2", "462: Projectile Mangonel (Fire)", "463: House", "464: House", "465: House", "466: Projectile Archer (Fire)", "467: -", "468: Projectile Mangonel (Secondary Fire)", "469: Projectile Trebuchet (Fire)", "470: Projectile Galley (Fire)", "471: Projectile War Galley (Fire)", "472: Loot", "473: Two-Handed Swordsman", "474: Heavy Cavalry Archer", "475: Projectile HAR (Fire)", "476: Projectile Harold Haraade (Fire)", "477: Projectile HAR", "478: Projectile Harold Haraade", "479: Packed Mangonel", "480: Hussar (Dead)", "481: Town Center", "482: Town Center", "483: Town Center", "484: Town Center", "485: Projectile Town Center", "486: Bear", "487: Gate", "488: Fortified Gate", "489: Bear (Dead)", "490: Gate", "491: Fortified Gate", "492: Arbalest", "493: Advanced Heavy Crossbowman", "494: Camel Rider (Dead)", "495: Heavy Camel Rider (Dead)", "496: Arbalest (Dead)", "497: King (Dead)", "498: Barracks", "499: Torch A", "500: Two Handed Swordsman (Dead)", "501: Pikeman (Dead)", "502: Halberdier (Dead)", "503: Projectile Watch Tower", "504: Projectile Guard Tower", "505: Projectile Keep", "506: Projectile Bombard Tower", "507: Projectile Arbalest", "508: Projectile Advanced Heavy Crossbowman", "509: Projectile Villager", "510: Projectile Chu Ko Nu", "511: Projectile Longbowman", "512: Projectile Longboat", "513: Projectile MSU", "514: Projectile MPC", "515: Projectile Axeman", "516: Projectile Watch Tower (Fire)", "517: Projectile Gaurd Tower (Fire)", "518: Projectile Keep (Fire)", "519: Projectile Arbalest (Fire)", "520: Projectile Heavy Crossbowman (Fire)", "521: Projectile Villager (Fire)", "522: Projectile Cho Ko Nu (Fire)", "523: Projectile Longbowman (Fire)", "524: Projectile Longboat (Fire)", "525: Projectile MPC (Fire)", "526: Projectile MSU (Fire)", "527: Demolition Ship", "528: Heavy Demolition Ship", "529: Fire Ship", "530: Elite Longbowman", "531: Elite Throwing Axeman", "532: Fast Fire Ship", "533: Elite Longboat", "534: Elite Woad Raider", "535: BDGAL", "536: ABGAL", "537: Projectile FRG", "538: Projectile HFG", "539: Galley", "540: Projectile Galley", "541: Projectile Galley (Fire)", "542: Heavy Scorpion", "543: Heavy Scorpion (Dead)", "544: FLDOG", "545: Transport Ship", "546: Light Cavalry", "547: Light Cavalry (Dead)", "548: Siege Ram", "549: Siege Ram (Dead)", "550: Onager", "551: Projectile Onager", "552: Projectile Onager (Fire)", "553: Elite Cataphract", "554: Elite Teutonic Knight", "555: Elite Huskarl", "556: Elite Mameluke", "557: Elite Janissary", "558: Elite War Elephant", "559: Elite Chu Ko Nu", "560: Elite Samurai", "561: Elite Mangudai", "562: Lumber Camp", "563: Lumber Camp", "564: Lumber Camp", "565: Lumber Camp", "566: Watch Tower", "567: Champion", "568: Champion (Dead)", "569: Paladin", "570: Paladin (Dead)", "571: Raider Archer", "572: Raider Archer (Dead)", "573: Raider Swordsman", "574: Raider Swordsman (Dead)", "575: Raider Cavalry", "576: Raider Cavalry (Dead)", "577: Raider Cavalry Archer", "578: Raider Cavalry Archer Dead", "579: Villager Male Gold Miner", "580: Villager Male Gold Miner (Dead)", "581: Villager Female Gold Miner", "582: Villager Female Gold Miner (Dead)", "583: Genitour", "584: Mining Camp", "585: Mining Camp", "586: Mining Camp", "587: Mining Camp", "588: Siege Onager", "589: Siege Onager (Dead)", "590: Villager Female Shepherd", "591: Villager Female Shepherd (Dead)", "592: Villager Male Shepherd", "593: Villager Male Shepherd (Dead)", "594: Sheep", "595: Sheep (Dead)", "596: Elite Genitour", "597: Town Center", "598: Outpost", "599: Cathedral", "600: Flag A", "601: Flag B", "602: Flag C", "603: Flag D", "604: Flag E", "605: Bridge A--Top", "606: Bridge A--Middle", "607: Bridge A--Bottom", "608: Bridge B--Top", "609: Bridge B--Middle", "610: Bridge B--Bottom", "611: Town Center", "612: Town Center", "613: Town Center", "614: Town Center", "615: Town Center", "616: Town Center", "617: Town Center", "618: Town Center", "619: Town Center", "620: Town Center", "621: Town Center", "622: Elite Genitour (Dead)", "623: Rock 1", "624: Pavilion A", "625: Pavilion C", "626: Pavilion B", "627: Projectile Heavy Scorpion", "628: Projectile Heavy Scorpion (Fire)", "629: Joan of Arc", "630: Joan of Arc (Dead)", "631: Subotai (Dead)", "632: Frankish Paladin", "633: Frankish Paladin (Dead)", "634: Sieur de Metz", "635: Burned Building", "636: Sieur Bertrand", "637: Temple of Heaven", "638: Duke D'Alencon", "639: Penguin", "640: La Hire", "641: Penguin (Dead)", "642: Lord de Graville", "643: Lord de Graville (Dead)", "644: Jean de Lorrain", "645: Jean de Lorrain (Dead)", "646: Constable Richemont", "647: Constable Richemont (Dead)", "648: Guy Josselyne", "649: Guy Josselyne (Dead)", "650: Jean Bureau", "651: Jean Bureau (Dead)", "652: Sir John Fastolf", "653: Sir John Fastolf (Dead)", "654: Trail Smoke (Fire)", "655: Mosque", "656: Projectile Mangonel (Primary)", "657: Projectile GP1", "658: Projectile Mangonel (Primary Fire)", "659: Gate (hori.)", "660: Fortified Gate (hori.)", "661: Gate", "662: Fortified Gate", "663: Gate", "664: Fortified Gate", "665: Gate", "666: Fortified Gate", "667: Gate (vert.)", "668: Fortified Gate (vert.)", "669: Gate", "670: Fortified Gate", "671: Gate", "672: Fortified Gate", "673: Gate", "674: Fortified Gate", "675: Onager (Dead)", "676: Projectile Fire Ship", "677: Projectile Fire Ship Small", "678: Reynald de Chatillon", "679: Reynald de Chatillon (Dead)", "680: Master of the Templar", "681: Master of the Templar (Dead)", "682: Bad Neighbor", "683: God's Own Sling", "684: The Accursed Tower", "685: The Tower of Flies", "686: Archer of the Eyes", "687: Archer of the Eyes (Dead)", "688: Piece of the True Cross", "689: Pyramid", "690: Dome of the Rock", "691: Elite Cannon Galleon", "692: Berserk", "693: Berserk (Dead)", "694: Elite Berserk", "695: Elite Berserk (Dead)", "696: Great Pyramid", "697: FLARE4", "698: Subotai", "699: Subotai (Dead)", "700: Hunting Wolf", "701: Hunting Wolf (Dead)", "702: Kushluk", "703: Topa Yupanqui", "704: Shah", "705: Cow A", "706: Saboteur", "707: Ornlu the Wolf", "708: Ornlu the Wolf (Dead)", "709: Cactus", "710: Skeleton", "711: Rugs", "712: Yurt A", "713: Yurt B", "714: Yurt C", "715: Yurt D", "716: Yurt E", "717: Yurt F", "718: Yurt G", "719: Yurt H", "720: Nine Bands", "721: Shipwreck A", "722: Shipwreck B", "723: Crater", "724: Genitour (Dead)", "725: Jaguar Warrior", "726: Elite Jaguar Warrior", "727: -", "728: Ice, Navigable", "729: God's Own Sling (Packed)", "730: Bad Neighbor (Packed)", "731: Genghis Khan", "732: King South-East Asia (Dead)", "733: Emperor in a Barrel", "734: Emperor in a Barrel (Dead)", "735: Packed Trebuchet (Dead)", "736: Projectile Mameluke", "737: Bamboo Stump", "738: Bridge A--Cracked", "739: Bridge A--Broken Top", "740: Bridge A--Broken Bottom", "741: Bridge B--Cracked", "742: Bridge B--Broken Top", "743: Bridge B--Broken Bottom", "744: Mountain 3", "745: Mountain 4", "746: Projectile Castle", "747: Projectile Castle (Fire)", "748: Cobra Car", "749: Cusi Yupanqui", "750: Jaguar Warrior (Dead)", "751: Eagle Scout", "752: Elite Eagle Warrior", "753: Eagle Warrior", "754: Eagle Warrior (Dead)", "755: Tarkan", "756: Tarkan (Dead)", "757: Elite Tarkan", "758: Burned building", "759: Huskarl", "760: Huskarl (Dead)", "761: Elite Huskarl", "762: Elite Huskarl (Dead)", "763: Plumed Archer", "764: Plumed Archer (Dead)", "765: Elite Plumed Archer", "766: Elite Plumed Archer (Dead)", "767: Projectile Elite Cannon Galleon", "768: Blue Tree", "769: -", "770: -", "771: Conquistador", "772: Conquistador (Dead)", "773: Elite Conquistador", "774: Elite Conquistador (Dead)", "775: Missionary", "776: Missionary (Dead)", "777: Attila the Hun", "778: Canoe", "779: Bleda the Hun", "780: Llama (Dead)", "781: Pope Leo I", "782: Pope Leo I (Dead)", "783: Scythian Wild Woman", "784: Scythian Wild Woman (Dead)", "785: Sea Tower", "786: Projectile Sea Tower", "787: Projectile Sea Tower (Fire)", "788: Sea Wall", "789: Palisade Gate (up.)", "790: Palisade Gate", "791: Palisade Gate", "792: Palisade Gate", "793: Palisade Gate (down.)", "794: Palisade Gate", "795: Palisade Gate", "796: Palisade Gate", "797: Palisade Gate (hori.)", "798: Palisade Gate", "799: Palisade Gate", "800: Palisade Gate", "801: Palisade Gate (vert.)", "802: Palisade Gate", "803: Palisade Gate", "804: Palisade Gate", "805: Dock", "806: Dock", "807: Dock", "808: Dock", "809: Stump", "810: Iron Boar", "811: Iron Boar (Dead)", "812: Jaguar", "813: Jaguar (Dead)", "814: Horse A", "815: Horse (Dead)", "816: Macaw", "817: Statue A", "818: Plant", "819: Sign", "820: Grave", "821: Head", "822: Javelina", "823: Javelina (Dead)", "824: El Cid Campeador", "825: Amazon Warrior", "826: Monument", "827: War Wagon", "828: War Wagon (Dead)", "829: Elite War Wagon", "830: Elite War Wagon (Dead)", "831: Turtle Ship", "832: Elite Turtle Ship", "833: Turkey", "834: Turkey (Dead)", "835: Wild Horse", "836: Wild Horse (Dead)", "837: Map Revealer", "838: King Sancho", "839: Rock (Stone)", "840: King Alfonso", "841: Rock (Gold)", "842: Imam", "843: Cow (Dead)", "844: Admiral Yi Sun-shin", "845: Nobunaga", "846: Donkey", "847: Henry V", "848: Donkey (Dead)", "849: William the Conqueror", "850: Amazon Archer", "851: ES Flag", "852: Scythian Scout", "853: Scythian Scout (Dead)", "854: Torch A (Convertable)", "855: Old Stone Head", "856: Roman Ruins", "857: Hay Stack", "858: Broken Cart", "859: Flower Bed", "860: Furious the Monkey Boy", "861: Furious the Monkey Boy (Dead)", "862: Stormy Dog", "863: Rubble 1 x 1", "864: Rubble 2 x 2", "865: Rubble 3 x 3", "866: Genoese Crossbowman", "867: Genoese Crossbowman (Dead)", "868: Elite Genoese Crossbowman", "869: Magyar Huszar", "870: Magyar Huszar (Dead)", "871: Elite Magyar Huszar", "872: Quimper Cathedral", "873: Elephant Archer", "874: Elephant Archer (Dead)", "875: Elite Elephant Archer", "876: Boyar", "877: Boyar (Dead)", "878: Elite Boyar", "879: Kamayuk", "880: Kamayuk (Dead)", "881: Elite Kamayuk", "882: Condottiero", "883: Condottiero (Dead)", "884: Wild Camel", "885: Siege Tower", "886: Tarkan", "887: Elite Tarkan", "888: Llama building", "889: Disable llama building", "890: Empty llama annex", "891: Siege Tower (Dead)", "892: Heavy Pikeman", "893: Heavy Pikeman (Dead)", "894: Eastern Swordsman", "895: Eastern Swordsman (Dead)", "896: Waterfall", "897: Camel", "898: Camel (Dead)", "899: Arch of Constantine", "900: Rain", "901: Flag F", "902: Smoke", "903: -", "904: Wooden Bridge A--Top", "905: Wooden Bridge A--Middle", "906: Wooden Bridge A--Bottom", "907: Wooden Bridge B--Top", "908: Wooden Bridge B--Middle", "909: Wooden Bridge B--Bottom", "910: Impaled Corpse", "911: BGAA", "912: BGAB", "913: BGAC", "914: Quarry", "915: Lumber", "916: Goods", "917: Vulture", "918: Rock 2", "919: Amazon Warrior (Dead)", "920: Amazon Archer (Dead)", "921: Imam (Dead)", "922: Monk with Relic", "923: Queen", "924: Queen (Dead)", "925: Sanyogita", "926: Prithvi", "927: Chand Bhai", "928: Chand Bhai (Dead)", "929: Saladin", "930: Khosrau", "931: Jarl", "932: Savar", "933: Barrels", "934: Alfred the Alpaca", "935: Alfred the Alpaca (Dead)", "936: Elephant", "937: Elephant (Dead)", "938: Dragon Ship", "939: Flame 1", "940: Flame 2", "941: Flame 3", "942: Flame 4", "943: Osman", "944: Relic Cart", "945: Shaw (Dead)", "946: -", "947: -", "948: -", "949: -", "950: -", "951: -", "952: -", "953: -", "954: -", "955: -", "956: -", "957: -", "958: -", "959: -", "960: -", "961: -", "962: -", "963: -", "964: -", "965: -", "966: -", "967: -", "968: -", "969: -", "970: -", "971: -", "972: -", "973: -", "974: -", "975: -", "976: -", "977: -", "978: -", "979: -", "980: -", "981: -", "982: -", "983: -", "984: -", "985: -", "986: -", "987: -", "988: -", "989: -", "990: -", "991: -", "992: -", "993: -", "994: -", "995: -", "996: -", "997: -", "998: -", "999: -", "1000: -", "1001: Organ Gun", "1002: Organ Gun (Dead)", "1003: Elite Organ Gun", "1004: Caravel", "1005: Organ Gun (Dead)", "1006: Elite Caravel", "1007: Camel Archer", "1008: Camel Archer (Dead)", "1009: Elite Camel Archer", "1010: Genitour", "1011: Genitour (Dead)", "1012: Elite Genitour", "1013: Gbeto", "1014: Gbeto (Dead)", "1015: Elite Gbeto", "1016: Shotel Warrior", "1017: Shotel Warrior (Dead)", "1018: Elite Shotel Warrior", "1019: Zebra", "1020: Zebra (Dead)", "1021: Feitoria", "1022: Monkboat", "1023: Priest", "1024: Priest (Dead)", "1025: Priest with relic", "1026: Ostrich", "1027: Ostrich (Dead)", "1028: Stork", "1029: Lion", "1030: Lion (Dead)", "1031: Crocodile", "1032: Crocodile (Dead)", "1033: Grass Patch, Dry", "1034: Musa ibn Nusayr", "1035: Sundjata", "1036: Tariq ibn Ziyad", "1037: Richard de Clare", "1038: Tristan", "1039: Princess Yodit", "1040: Henry II", "1041: Mountain 5", "1042: Mountain 6", "1043: Mountain 7", "1044: Mountain 8", "1045: Snow Mountain 1", "1046: Snow Mountain 2", "1047: Snow Mountain 3", "1048: Rock Formation 1", "1049: Rock Formation 2", "1050: Rock Formation 3", "1051: Tree (Dragon)", "1052: Tree (Baobab)", "1053: Bush B", "1054: Bush C", "1055: Projectile Knife", "1056: Falcon", "1057: Projectile CVB", "1058: Projectile CVB (Fire)", "1059: Fruit Bush", "1060: Goat", "1061: Goat (Dead)", "1062: Fence", "1063: Tree (Acacia)", "1064: Yekuno Amlak", "1065: Fence (Rubble)", "1066: Yodit", "1067: Itzcoatl", "1068: Mustafa Pasha", "1069: Pacal II", "1070: Babur", "1071: Abraha Elephant", "1072: Guglielmo Embriaco", "1073: Su Dingfang", "1074: Pachacuti", "1075: Huayna Capac", "1076: Miklos Toldi", "1077: Little John", "1078: Zawisza the Black", "1079: GENITOPLACEHOLDER", "1080: Sumanguru", "1081: Storage", "1082: Hut A", "1083: Hut B", "1084: Hut C", "1085: Hut D", "1086: Hut E", "1087: Hut F", "1088: Hut G", "1089: Granary", "1090: Barricade A", "1091: Animal Skeleton", "1092: Stelae A", "1093: Stelae B", "1094: Stelae C", "1095: Gallow", "1096: Palace", "1097: Tent A", "1098: Tent B", "1099: Tent C", "1100: Tent D", "1101: Tent E", "1102: Fortified Tower", "1103: Fire Galley", "1104: Demolition Raft", "1105: Siege Tower", "1106: Dagnajan", "1107: Siege Tower (Dead)", "1108: Dagnajan (Dead)", "1109: Gidajan", "1110: Gidajan (Dead)", "1111: Projectile Light Ballista", "1112: Projectile Light Ballista (Fire)", "1113: Projectile Heavy Scorpion", "1114: Projectile Heavy Scorpion (Fire)", "1115: FACAHOLE", "1116: Eagle Warrior (Dead)", "1117: Elite Eagle Warrior (Dead)", "1118: Inca llama annex", "1119: Projectile Gunpowder (Secondary)", "1120: Ballista Elephant", "1121: Ballista Elephant (Dead)", "1122: Elite Ballista Elephant", "1123: Karambit Warrior", "1124: Karambit Warrior (Dead)", "1125: Elite Karambit Warrior", "1126: Arambai", "1127: Arambai (Dead)", "1128: Elite Arambai", "1129: Rattan Archer", "1130: Rattan Archer (Dead)", "1131: Elite Rattan Archer", "1132: Battle Elephant", "1133: Battle Elephant (Dead)", "1134: Elite Battle Elephant", "1135: Komodo Dragon", "1136: Komodo Dragon (Dead)", "1137: Tiger", "1138: Tiger (Dead)", "1139: Rhinoceros", "1140: Rhinoceros (Dead)", "1141: Box Turtles", "1142: Water Buffalo", "1143: Water Buffalo (Dead)", "1144: Tree (Mangrove)", "1145: Ninja", "1146: Tree (Rainforest)", "1147: Ninja (Dead)", "1148: Rock (Beach)", "1149: Rock (Jungle)", "1150: Flag G", "1151: Flag H", "1152: Flag I", "1153: Flag J", "1154: Elite Battle Elephant (Dead)", "1155: Imperial Skirmisher", "1156: Imperial Skirmisher (Dead)", "1157: Gajah Mada", "1158: Jayanegara", "1159: Raden Wijaya", "1160: Sunda Royal Fighter", "1161: Sunda Royal Fighter (Dead)", "1162: Suryavarman I", "1163: Udayadityavarman I", "1164: Jayaviravarman", "1165: Bayinnaung", "1166: Tabinshwehti", "1167: Projectile Ballista Elephant", "1168: Projectile Ballista Elephant (Fire)", "1169: Projectile Arambai", "1170: Projectile Arambai (Fire)", "1171: Buddha Statue A", "1172: Buddha Statue B", "1173: Buddha Statue C", "1174: Buddha Statue D", "1175: Fern Patch", "1176: Trowulan Gate", "1177: Vases", "1178: Le Loi", "1179: Le Lai", "1180: Le Lai", "1181: Le Trien", "1182: Luu Nhan Chu", "1183: Bui Bi", "1184: Dinh Le", "1185: Wang Tong", "1186: Envoy", "1187: Rice Farm", "1188: Rice Farm (Dead)", "1189: Harbor", "1190: Gajah Mada (Dead)", "1191: Stupa", "1192: Gate", "1193: FARMDROP", "1194: FARMSTACK", "1195: RFARMDROP", "1196: Army Tent A", "1197: Army Tent B", "1198: Army Tent C", "1199: Army Tent D", "1200: Army Tent E", "1201: Pagoda A", "1202: Pagoda B", "1203: Pagoda C", "1204: Bridge C--Top", "1205: Bridge C--Middle", "1206: Bridge C--Bottom", "1207: Bridge D--Top", "1208: Bridge D--Middle", "1209: Bridge D--Bottom", "1210: Bridge C--Cracked", "1211: Bridge C--Broken Top", "1212: Bridge C--Broken Bottom", "1213: Bridge D--Cracked", "1214: Bridge D--Broken Top", "1215: Bridge D--Broken Bottom", "1216: Sanchi Stupa", "1217: Gol Gumbaz", "1218: Barricade B", "1219: Barricade C", "1220: Barricade D", "1221: Itzcoatl (Dead)", "1222: Sharkatzor", "1223: Projectile Cow", "1224: Dinh Le (Dead)", "1225: Konnik", "1226: Konnik (Dead)", "1227: Elite Konnik", "1228: Keshik", "1229: Keshik (Dead)", "1230: Elite Keshik", "1231: Kipchak", "1232: Kipchak (Dead)", "1233: Elite Kipchak", "1234: Leitis", "1235: Leitis (Dead)", "1236: Elite Leitis", "1237: Bactrian Camel", "1238: Bactrian Camel (Dead)", "1239: Ibex", "1240: Ibex (Dead)", "1241: Snow Leopard", "1242: Snow Leopard (Dead)", "1243: Goose", "1244: Goose (Dead)", "1245: Pig", "1246: Pig (Dead)", "1247: Wild Bactrian Camel", "1248: Tree (Oak Autumn)", "1249: Tree (Oak Autumn Snow)", "1250: Tree (Dead)", "1251: Krepost", "1252: Konnik (Dismounted)", "1253: Elite Konnik (Dismounted)", "1254: Konnik", "1255: Elite Konnik", "1256: Elite Konnik (Dead)", "1257: Konnik Infantry (Dead)", "1258: Battering Ram", "1259: CUMANPLACEHOLDER", "1260: Elite Kipchak", "1261: CUMANDISABLED", "1262: Tokhtamysh Khan", "1263: Flaming Camel", "1264: Shrine", "1265: Ivaylo", "1266: Tsar Konstantin", "1267: Kotyan Khan", "1268: Cuman Chief", "1269: Girgen Khan", "1270: Dismantled Cart", "1271: Ox Cart", "1272: Ox Cart (Dead)", "1273: Ox Wagon", "1274: Ox Wagon (Dead)", "1275: Khan", "1276: Urus Khan", "1277: Khan (Dead)", "1278: Vytautas the Great (Dead)", "1279: Statue (Civilization)", "1280: Statue B", "1281: Vytautas the Great", "1282: Flag K", "1283: Flag L", "1284: Flag M", "1285: FE Flag", "1286: Tsar Konstantin (Dead)", "1287: Kotyan Khan (Dead)", "1288: Cuman Chief (Dead)", "1289: Girgen Khan (Dead)", "1290: Ivaylo", "1291: Invisible Object", "1292: Queen", "1293: Sanyogita", "1294: Prithvi", "1295: Chand Bardai", "1296: Saladin", "1297: Khosrau", "1298: Jarl", "1299: Sogdian Cataphract", "1300: Alfred the Alpaca", "1301: Elephant", "1302: Dragon Ship", "1303: Osman", "1304: Relic Cart", "1305: Vulture", "1306: Rain", "1307: Flag F", "1308: Smoke", "1309: Wooden Bridge A--Top", "1310: Wooden Bridge A--Middle", "1311: Wooden Bridge A--Bottom", "1312: Wooden Bridge B--Top", "1313: Wooden Bridge B--Middle", "1314: Wooden Bridge B--Bottom", "1315: Impaled Corpse", "1316: BGAA", "1317: BGAB", "1318: BGAC", "1319: Quarry", "1320: Lumber", "1321: Goods", "1322: Statue (Column)", "1323: Rock 2", "1324: Amazon Warrior (Dead)", "1325: Amazon Archer (Dead)", "1326: Imam (Dead)", "1327: Monk with Relic", "1328: Queen (Dead)", "1329: Monk (Dead)", "1330: Barrels", "1331: Alfred the Alpaca (Dead)", "1332: Elephant (Dead)", "1333: Flame 1", "1334: Flame 2", "1335: Flame 3", "1336: Flame 4", "1337: Shaw (Dead)", "1338: Cart", "1339: CLF01", "1340: CLF02", "1341: CLF03", "1342: CLF04", "1343: Statue (Left)", "1344: CLF06", "1345: Statue (Right)", "1346: CLF08", "1347: Tree (Cypress)", "1348: Tree (Italian Pine)", "1349: Tree (Olive)", "1350: Tree (Reeds)", "1351: Plant (Jungle)", "1352: Plant (Underbrush Tropical)", "1353: Plant (Underbrush)", "1354: Plant (Rainforest)", "1355: Plant (Underbrush Rainforest)", "1356: Horse B", "1357: Horse Heavy (Dead)", "1358: Grass, Green", "1359: Grass, Dry", "1360: Plant (Bush, Green)", "1361: Plant (Bush, Dry)", "1362: Plant (Shrub, Green)", "1363: Plant (Shrub, Dry)", "1364: Plant (Weeds)", "1365: Plant (Dead)", "1366: Plant (Flowers)", "1367: Sankore Madrasah", "1368: Tower of London", "1369: Dormition Cathedral", "1370: Steppe Lancer", "1371: Steppe Lancer (Dead)", "1372: Elite Steppe Lancer", "1373: Elite Steppe Lancer (Dead)", "1374: Iroquois Warrior", "1375: Iroquois Warrior (Dead)", "1376: Torch B", "1377: Torch B (Convertable)", "1378: Rock Church", "1379: Sea Gate", "1380: Sea Gate", "1381: Sea Gate", "1382: Sea Gate", "1383: Sea Gate", "1384: Sea Gate", "1385: Sea Gate", "1386: Sea Gate", "1387: Sea Gate", "1388: Sea Gate", "1389: Sea Gate", "1390: Sea Gate", "1391: Sea Gate", "1392: Sea Gate", "1393: Sea Gate", "1394: Sea Gate", "1395: Sundjata (Dead)", "1396: Chain", "1397: Chain", "1398: Chain", "1399: Chain", "1400: Priest with Relic", "1401: Savar (Dead)", "1402: Barracks DARK (Rubble)", "1403: House DARK (Rubble)", "1404: Mill DARK (Rubble)", "1405: Outpost DARK (Rubble)", "1406: Gate Foundation (Rubble)", "1407: PalisadeWall DARK (Rubble)", "1408: TownCenter DARK (Rubble)", "1409: LumberCamp (Rubble)", "1410: MiningCamp (Rubble)", "1411: Mill Age2 (Rubble)", "1412: Mill Age3 (Rubble)", "1413: Barracks Age2 (Rubble)", "1414: Barracks Age3 (Rubble)", "1415: ArcheryRange Age2 (Rubble)", "1416: ArcheryRange Age3 (Rubble)", "1417: Stable Age2 (Rubble)", "1418: Stable Age3 (Rubble)", "1419: Blacksmith Age2 (Rubble)", "1420: Blacksmith Age3 (Rubble)", "1421: Monastery Age3 (Rubble)", "1422: Market Age2 (Rubble)", "1423: Market Age3 (Rubble)", "1424: Market Age4 (Rubble)", "1425: SiegeWorkshop Age2 (Rubble)", "1426: SiegeWorkshop Age3 (Rubble)", "1427: University Age3 (Rubble)", "1428: University Age4 (Rubble)", "1429: TradeWorkshop Age3 (Rubble)", "1430: Castle Age3 (Rubble)", "1431: TownCenter Age2 (Rubble)", "1432: TownCenter Age3 (Rubble)", "1433: TownCenter Age4 (Rubble)", "1434: House Age2 (Rubble)", "1435: House Age3 (Rubble)", "1436: Tower Age2 (Rubble)", "1437: Tower Age3 (Rubble)", "1438: Tower Age4 (Rubble)", "1439: Tower Bombard (Rubble)", "1440: PalisadeGate DARK NE (Rubble)", "1441: PalisadeGate DARK SE (Rubble)", "1442: PalisadeGate DARK E (Rubble)", "1443: PalisadeGate DARK N (Rubble)", "1444: FortifiedTower (Rubble)", "1445: Wonder (Rubble)", "1446: Feitoria (Rubble)", "1447: Yurt A (Rubble)", "1448: Yurt B (Rubble)", "1449: Yurt C (Rubble)", "1450: Yurt D (Rubble)", "1451: Yurt E (Rubble)", "1452: Yurt F (Rubble)", "1453: Yurt G (Rubble)", "1454: Yurt H (Rubble)", "1455: Hut A (Rubble)", "1456: Hut B (Rubble)", "1457: Hut C (Rubble)", "1458: Hut D (Rubble)", "1459: Hut E (Rubble)", "1460: Hut F (Rubble)", "1461: Hut G (Rubble)", "1462: Tent A (Rubble)", "1463: Tent B (Rubble)", "1464: Tent C (Rubble)", "1465: Tent D (Rubble)", "1466: Tent E (Rubble)", "1467: ArmyTent A (Rubble)", "1468: ArmyTent B (Rubble)", "1469: ArmyTent C (Rubble)", "1470: ArmyTent D (Rubble)", "1471: ArmyTent E (Rubble)", "1472: Barricade A (Rubble)", "1473: Barricade B (Rubble)", "1474: Barricade C (Rubble)", "1475: Barricade D (Rubble)", "1476: Pavilion A (Rubble)", "1477: Pavilion B (Rubble)", "1478: Pavilion C (Rubble)", "1479: Krepost (Rubble)", "1480: Cathedral (Rubble)", "1481: Temple of Heaven (Rubble)", "1482: DomeOfRock (Rubble)", "1483: Shrine (Rubble)", "1484: Storage (Rubble)", "1485: ArchOfConstantine (Rubble)", "1486: Fortress (Rubble)", "1487: GolGumbaz (Rubble)", "1488: PoenariCastle (Rubble)", "1489: QuimperCathedral (Rubble)", "1490: SanchiStupa (Rubble)", "1491: SankoreMadrasah (Rubble)", "1492: TowerOfLondon (Rubble)", "1493: DormitionCathedral (Rubble)", "1494: TheAccursedTower (Rubble)", "1495: TheTowerOfFlies (Rubble)", "1496: Mosque (Rubble)", "1497: Rubble 4 x 4", "1498: Rubble 8 x 8", "1499: Granary (Rubble)", "1500: StoneGate NE (Rubble)", "1501: StoneGate SE (Rubble)", "1502: StoneGate E (Rubble)", "1503: StoneGate N (Rubble)", "1504: FortifiedGate NE (Rubble)", "1505: FortifiedGate SE (Rubble)", "1506: FortifiedGate E (Rubble)", "1507: FortifiedGate N (Rubble)", "1508: StoneWall (Rubble)", "1509: FortifiedWall (Rubble)", "1510: CityGate NE (Rubble)", "1511: CityGate SE (Rubble)", "1512: CityGate E (Rubble)", "1513: CityGate N (Rubble)", "1514: Amphitheatre (Rubble)", "1515: Pyramid (Rubble)", "1516: GreatPyramid (Rubble)", "1517: AachenCathedral (Rubble)", "1518: StoneGate Corner (Rubble)", "1519: FortifiedGate Corner (Rubble)", "1520: Colosseum (Rubble)", "1521: PalisadeGate Corner (Rubble)", "1522: Aqueduct (Rubble)", "1523: CityGate Corner (Rubble)", "1524: Donjon Age2 (Rubble)", "1525: Folwark Age2 (Rubble)", "1526: PaganShrine (Rubble)", "1527: Folwark Age3 (Rubble)", "1528: Folwark Age1 (Rubble)", "1529: Caravanserai (Rubble)", "1530: MinaretOfJam(Rubble)", "1531: FortifiedChurch Age3 (Rubble)", "1532: Yurt I (Rubble)", "1533: Yurt J (Rubble)", "1534: Yurt K (Rubble)", "1535: Yurt L (Rubble)", "1536: -", "1537: -", "1538: -", "1539: -", "1540: -", "1541: -", "1542: -", "1543: -", "1544: -", "1545: -", "1546: -", "1547: -", "1548: -", "1549: -", "1550: Bridge E--Top", "1551: Bridge E--Middle", "1552: Bridge E--Bottom", "1553: Bridge F--Top", "1554: Bridge F--Middle", "1555: Bridge F--Bottom", "1556: Bridge E--Cracked", "1557: Bridge E--Broken Top", "1558: Bridge E--Broken Bottom", "1559: Bridge F--Cracked", "1560: Bridge F--Broken Top", "1561: Bridge F--Broken Bottom", "1562: Paifang Gate", "1563: Nubian Pyramid", "1564: Target A", "1565: Target B", "1566: Temple Ruin", "1567: Well", "1568: Mounted Samurai", "1569: Mounted Samurai (Dead)", "1570: Xolotl Warrior", "1571: XolotlWarrior (Dead)", "1572: Merchant", "1573: Merchant (Dead)", "1574: Sosso Guard", "1575: Sosso Gaurd (Dead)", "1576: Royal Janissary (Dead)", "1577: Photonman", "1578: Photonman (Dead)", "1579: City Gate", "1580: City Gate", "1581: City Gate", "1582: City Gate", "1583: City Gate", "1584: City Gate", "1585: City Gate", "1586: City Gate", "1587: City Gate"})
        lbx_objects_1.Location = New Point(8, 32)
        lbx_objects_1.Name = "lbx_objects_1"
        lbx_objects_1.Size = New Size(235, 469)
        lbx_objects_1.TabIndex = 0
        ' 
        ' tp_diplomacy
        ' 
        tp_diplomacy.Controls.Add(lbl_max_teams)
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
        tp_diplomacy.Size = New Size(1448, 524)
        tp_diplomacy.TabIndex = 4
        tp_diplomacy.Text = "Diplomacy"
        tp_diplomacy.UseVisualStyleBackColor = True
        ' 
        ' lbl_max_teams
        ' 
        lbl_max_teams.AutoSize = True
        lbl_max_teams.Location = New Point(648, 24)
        lbl_max_teams.Name = "lbl_max_teams"
        lbl_max_teams.Size = New Size(66, 15)
        lbl_max_teams.TabIndex = 100
        lbl_max_teams.Text = "Max Teams"
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
        cbx_max_teams.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_max_teams.FormattingEnabled = True
        cbx_max_teams.Items.AddRange(New Object() {"2 Teams", "3 Teams", "4 Teams"})
        cbx_max_teams.Location = New Point(649, 43)
        cbx_max_teams.Name = "cbx_max_teams"
        cbx_max_teams.Size = New Size(121, 23)
        cbx_max_teams.TabIndex = 96
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
        tp_victory.Controls.Add(lbl_percentage)
        tp_victory.Controls.Add(lbl_time_limit)
        tp_victory.Controls.Add(lbl_score)
        tp_victory.Controls.Add(lbl_victory_condition)
        tp_victory.Controls.Add(cbx_king_of_the_hill)
        tp_victory.Controls.Add(cbx_regicide)
        tp_victory.Controls.Add(cbx_sudden_death)
        tp_victory.Controls.Add(cbx_empire_wars)
        tp_victory.Controls.Add(rbn_secondary_game_mode)
        tp_victory.Controls.Add(tbx_relics_total)
        tp_victory.Controls.Add(tbx_exploration_total)
        tp_victory.Controls.Add(cbx_all)
        tp_victory.Controls.Add(cbx_relics)
        tp_victory.Controls.Add(cbx_exploration)
        tp_victory.Controls.Add(cbx_conquest)
        tp_victory.Controls.Add(rbn_custom)
        tp_victory.Controls.Add(cbx_time_limit)
        tp_victory.Controls.Add(rbn_time_limit)
        tp_victory.Controls.Add(cbx_score)
        tp_victory.Controls.Add(rbn_score)
        tp_victory.Controls.Add(rbn_conquest)
        tp_victory.Controls.Add(rbn_standard)
        tp_victory.Location = New Point(4, 24)
        tp_victory.Name = "tp_victory"
        tp_victory.Padding = New Padding(3)
        tp_victory.Size = New Size(1448, 524)
        tp_victory.TabIndex = 5
        tp_victory.Text = "Victory"
        tp_victory.UseVisualStyleBackColor = True
        ' 
        ' lbl_percentage
        ' 
        lbl_percentage.AutoSize = True
        lbl_percentage.Location = New Point(512, 8)
        lbl_percentage.Name = "lbl_percentage"
        lbl_percentage.Size = New Size(17, 15)
        lbl_percentage.TabIndex = 104
        lbl_percentage.Text = "%"
        ' 
        ' lbl_time_limit
        ' 
        lbl_time_limit.AutoSize = True
        lbl_time_limit.Location = New Point(224, 8)
        lbl_time_limit.Name = "lbl_time_limit"
        lbl_time_limit.Size = New Size(63, 15)
        lbl_time_limit.TabIndex = 103
        lbl_time_limit.Text = "Time Limit"
        ' 
        ' lbl_score
        ' 
        lbl_score.AutoSize = True
        lbl_score.Location = New Point(160, 8)
        lbl_score.Name = "lbl_score"
        lbl_score.Size = New Size(36, 15)
        lbl_score.TabIndex = 102
        lbl_score.Text = "Score"
        ' 
        ' lbl_victory_condition
        ' 
        lbl_victory_condition.AutoSize = True
        lbl_victory_condition.Location = New Point(8, 8)
        lbl_victory_condition.Name = "lbl_victory_condition"
        lbl_victory_condition.Size = New Size(100, 15)
        lbl_victory_condition.TabIndex = 101
        lbl_victory_condition.Text = "Victory Condition"
        ' 
        ' cbx_king_of_the_hill
        ' 
        cbx_king_of_the_hill.AutoSize = True
        cbx_king_of_the_hill.Location = New Point(560, 104)
        cbx_king_of_the_hill.Name = "cbx_king_of_the_hill"
        cbx_king_of_the_hill.Size = New Size(105, 19)
        cbx_king_of_the_hill.TabIndex = 17
        cbx_king_of_the_hill.Text = "King of the Hill"
        cbx_king_of_the_hill.UseVisualStyleBackColor = True
        ' 
        ' cbx_regicide
        ' 
        cbx_regicide.AutoSize = True
        cbx_regicide.Location = New Point(560, 80)
        cbx_regicide.Name = "cbx_regicide"
        cbx_regicide.Size = New Size(71, 19)
        cbx_regicide.TabIndex = 16
        cbx_regicide.Text = "Regicide"
        cbx_regicide.UseVisualStyleBackColor = True
        ' 
        ' cbx_sudden_death
        ' 
        cbx_sudden_death.AutoSize = True
        cbx_sudden_death.Location = New Point(560, 56)
        cbx_sudden_death.Name = "cbx_sudden_death"
        cbx_sudden_death.Size = New Size(100, 19)
        cbx_sudden_death.TabIndex = 15
        cbx_sudden_death.Text = "Sudden Death"
        cbx_sudden_death.UseVisualStyleBackColor = True
        ' 
        ' cbx_empire_wars
        ' 
        cbx_empire_wars.AutoSize = True
        cbx_empire_wars.Location = New Point(560, 32)
        cbx_empire_wars.Name = "cbx_empire_wars"
        cbx_empire_wars.Size = New Size(92, 19)
        cbx_empire_wars.TabIndex = 14
        cbx_empire_wars.Text = "Empire Wars"
        cbx_empire_wars.UseVisualStyleBackColor = True
        ' 
        ' rbn_secondary_game_mode
        ' 
        rbn_secondary_game_mode.AutoSize = True
        rbn_secondary_game_mode.Location = New Point(8, 152)
        rbn_secondary_game_mode.Name = "rbn_secondary_game_mode"
        rbn_secondary_game_mode.Size = New Size(148, 19)
        rbn_secondary_game_mode.TabIndex = 13
        rbn_secondary_game_mode.Text = "Secondary Game Mode"
        rbn_secondary_game_mode.UseVisualStyleBackColor = True
        ' 
        ' tbx_relics_total
        ' 
        tbx_relics_total.Location = New Point(512, 80)
        tbx_relics_total.MaxLength = 3
        tbx_relics_total.Name = "tbx_relics_total"
        tbx_relics_total.Size = New Size(40, 23)
        tbx_relics_total.TabIndex = 12
        tbx_relics_total.Text = "0"
        ' 
        ' tbx_exploration_total
        ' 
        tbx_exploration_total.Location = New Point(512, 56)
        tbx_exploration_total.MaxLength = 3
        tbx_exploration_total.Name = "tbx_exploration_total"
        tbx_exploration_total.Size = New Size(40, 23)
        tbx_exploration_total.TabIndex = 11
        tbx_exploration_total.Text = "0"
        ' 
        ' cbx_all
        ' 
        cbx_all.AutoSize = True
        cbx_all.Location = New Point(424, 104)
        cbx_all.Name = "cbx_all"
        cbx_all.Size = New Size(45, 19)
        cbx_all.TabIndex = 10
        cbx_all.Text = "All?"
        cbx_all.UseVisualStyleBackColor = True
        ' 
        ' cbx_relics
        ' 
        cbx_relics.AutoSize = True
        cbx_relics.Location = New Point(424, 80)
        cbx_relics.Name = "cbx_relics"
        cbx_relics.Size = New Size(56, 19)
        cbx_relics.TabIndex = 9
        cbx_relics.Text = "Relics"
        cbx_relics.UseVisualStyleBackColor = True
        ' 
        ' cbx_exploration
        ' 
        cbx_exploration.AutoSize = True
        cbx_exploration.Location = New Point(424, 56)
        cbx_exploration.Name = "cbx_exploration"
        cbx_exploration.Size = New Size(86, 19)
        cbx_exploration.TabIndex = 8
        cbx_exploration.Text = "Exploration"
        cbx_exploration.UseVisualStyleBackColor = True
        ' 
        ' cbx_conquest
        ' 
        cbx_conquest.AutoSize = True
        cbx_conquest.Location = New Point(424, 32)
        cbx_conquest.Name = "cbx_conquest"
        cbx_conquest.Size = New Size(77, 19)
        cbx_conquest.TabIndex = 7
        cbx_conquest.Text = "Conquest"
        cbx_conquest.UseVisualStyleBackColor = True
        ' 
        ' rbn_custom
        ' 
        rbn_custom.AutoSize = True
        rbn_custom.Location = New Point(8, 128)
        rbn_custom.Name = "rbn_custom"
        rbn_custom.Size = New Size(67, 19)
        rbn_custom.TabIndex = 6
        rbn_custom.Text = "Custom"
        rbn_custom.UseVisualStyleBackColor = True
        ' 
        ' cbx_time_limit
        ' 
        cbx_time_limit.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_time_limit.FormattingEnabled = True
        cbx_time_limit.Items.AddRange(New Object() {"300 Years (25 Minutes)", "500 Years (40 Minutes)", "700 Years (1 Hour)", "900 Years (1 Hour, 15 Minutes)", "1100 Years (1 Hour, 30 Minutes)", "1300 Years (1 Hour, 45 Minutes)", "1500 Years (2 Hours)"})
        cbx_time_limit.Location = New Point(224, 32)
        cbx_time_limit.Name = "cbx_time_limit"
        cbx_time_limit.Size = New Size(192, 23)
        cbx_time_limit.TabIndex = 5
        ' 
        ' rbn_time_limit
        ' 
        rbn_time_limit.AutoSize = True
        rbn_time_limit.Location = New Point(8, 104)
        rbn_time_limit.Name = "rbn_time_limit"
        rbn_time_limit.Size = New Size(81, 19)
        rbn_time_limit.TabIndex = 4
        rbn_time_limit.Text = "Time Limit"
        rbn_time_limit.UseVisualStyleBackColor = True
        ' 
        ' cbx_score
        ' 
        cbx_score.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_score.FormattingEnabled = True
        cbx_score.Items.AddRange(New Object() {"4000", "5000", "6000", "7000", "8000", "9000", "10000", "11000", "12000", "13000", "14000"})
        cbx_score.Location = New Point(160, 32)
        cbx_score.Name = "cbx_score"
        cbx_score.Size = New Size(56, 23)
        cbx_score.TabIndex = 3
        ' 
        ' rbn_score
        ' 
        rbn_score.AutoSize = True
        rbn_score.Location = New Point(8, 80)
        rbn_score.Name = "rbn_score"
        rbn_score.Size = New Size(54, 19)
        rbn_score.TabIndex = 2
        rbn_score.Text = "Score"
        rbn_score.UseVisualStyleBackColor = True
        ' 
        ' rbn_conquest
        ' 
        rbn_conquest.AutoSize = True
        rbn_conquest.Location = New Point(8, 56)
        rbn_conquest.Name = "rbn_conquest"
        rbn_conquest.Size = New Size(76, 19)
        rbn_conquest.TabIndex = 1
        rbn_conquest.Text = "Conquest"
        rbn_conquest.UseVisualStyleBackColor = True
        ' 
        ' rbn_standard
        ' 
        rbn_standard.AutoSize = True
        rbn_standard.Checked = True
        rbn_standard.Location = New Point(8, 32)
        rbn_standard.Name = "rbn_standard"
        rbn_standard.Size = New Size(72, 19)
        rbn_standard.TabIndex = 0
        rbn_standard.TabStop = True
        rbn_standard.Text = "Standard"
        rbn_standard.UseVisualStyleBackColor = True
        ' 
        ' tp_options
        ' 
        tp_options.Controls.Add(lbl_testing_difficulty)
        tp_options.Controls.Add(lbl_options_player)
        tp_options.Controls.Add(lbl_disabled_techs)
        tp_options.Controls.Add(lbl_disabled_buildings)
        tp_options.Controls.Add(lbl_disabled_units)
        tp_options.Controls.Add(btn_camera_view)
        tp_options.Controls.Add(lbx_view_y)
        tp_options.Controls.Add(lbx_view_x)
        tp_options.Controls.Add(cbx_testing_difficulty)
        tp_options.Controls.Add(cbx_lock_co_op_alliances)
        tp_options.Controls.Add(cbx_villager_force_drop)
        tp_options.Controls.Add(cbx_collide_and_correcting)
        tp_options.Controls.Add(cbx_full_tech_tree)
        tp_options.Controls.Add(cbx_disabled_player)
        tp_options.Controls.Add(clb_disabled_techs)
        tp_options.Controls.Add(clb_disabled_buildings)
        tp_options.Controls.Add(clb_disabled_units)
        tp_options.Location = New Point(4, 24)
        tp_options.Name = "tp_options"
        tp_options.Padding = New Padding(3)
        tp_options.Size = New Size(1448, 524)
        tp_options.TabIndex = 6
        tp_options.Text = "Options"
        tp_options.UseVisualStyleBackColor = True
        ' 
        ' lbl_testing_difficulty
        ' 
        lbl_testing_difficulty.AutoSize = True
        lbl_testing_difficulty.Location = New Point(904, 8)
        lbl_testing_difficulty.Name = "lbl_testing_difficulty"
        lbl_testing_difficulty.Size = New Size(95, 15)
        lbl_testing_difficulty.TabIndex = 106
        lbl_testing_difficulty.Text = "Testing Difficulty"
        ' 
        ' lbl_options_player
        ' 
        lbl_options_player.AutoSize = True
        lbl_options_player.Location = New Point(632, 8)
        lbl_options_player.Name = "lbl_options_player"
        lbl_options_player.Size = New Size(39, 15)
        lbl_options_player.TabIndex = 105
        lbl_options_player.Text = "Player"
        ' 
        ' lbl_disabled_techs
        ' 
        lbl_disabled_techs.AutoSize = True
        lbl_disabled_techs.Location = New Point(424, 8)
        lbl_disabled_techs.Name = "lbl_disabled_techs"
        lbl_disabled_techs.Size = New Size(84, 15)
        lbl_disabled_techs.TabIndex = 104
        lbl_disabled_techs.Text = "Disabled Techs"
        ' 
        ' lbl_disabled_buildings
        ' 
        lbl_disabled_buildings.AutoSize = True
        lbl_disabled_buildings.Location = New Point(216, 8)
        lbl_disabled_buildings.Name = "lbl_disabled_buildings"
        lbl_disabled_buildings.Size = New Size(104, 15)
        lbl_disabled_buildings.TabIndex = 103
        lbl_disabled_buildings.Text = "Disabled Buildings"
        ' 
        ' lbl_disabled_units
        ' 
        lbl_disabled_units.AutoSize = True
        lbl_disabled_units.Location = New Point(8, 8)
        lbl_disabled_units.Name = "lbl_disabled_units"
        lbl_disabled_units.Size = New Size(82, 15)
        lbl_disabled_units.TabIndex = 102
        lbl_disabled_units.Text = "Disabled Units"
        ' 
        ' btn_camera_view
        ' 
        btn_camera_view.Location = New Point(1144, 32)
        btn_camera_view.Name = "btn_camera_view"
        btn_camera_view.Size = New Size(75, 23)
        btn_camera_view.TabIndex = 15
        btn_camera_view.Text = "Set View"
        btn_camera_view.UseVisualStyleBackColor = True
        ' 
        ' lbx_view_y
        ' 
        lbx_view_y.FormattingEnabled = True
        lbx_view_y.ItemHeight = 15
        lbx_view_y.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365", "366", "367", "368", "369", "370", "371", "372", "373", "374", "375", "376", "377", "378", "379", "380", "381", "382", "383", "384", "385", "386", "387", "388", "389", "390", "391", "392", "393", "394", "395", "396", "397", "398", "399", "400", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "418", "419", "420", "421", "422", "423", "424", "425", "426", "427", "428", "429", "430", "431", "432", "433", "434", "435", "436", "437", "438", "439", "440", "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454", "455", "456", "457", "458", "459", "460", "461", "462", "463", "464", "465", "466", "467", "468", "469", "470", "471", "472", "473", "474", "475", "476", "477", "478", "479"})
        lbx_view_y.Location = New Point(1088, 32)
        lbx_view_y.Name = "lbx_view_y"
        lbx_view_y.Size = New Size(48, 484)
        lbx_view_y.TabIndex = 14
        ' 
        ' lbx_view_x
        ' 
        lbx_view_x.FormattingEnabled = True
        lbx_view_x.ItemHeight = 15
        lbx_view_x.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365", "366", "367", "368", "369", "370", "371", "372", "373", "374", "375", "376", "377", "378", "379", "380", "381", "382", "383", "384", "385", "386", "387", "388", "389", "390", "391", "392", "393", "394", "395", "396", "397", "398", "399", "400", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "418", "419", "420", "421", "422", "423", "424", "425", "426", "427", "428", "429", "430", "431", "432", "433", "434", "435", "436", "437", "438", "439", "440", "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454", "455", "456", "457", "458", "459", "460", "461", "462", "463", "464", "465", "466", "467", "468", "469", "470", "471", "472", "473", "474", "475", "476", "477", "478", "479"})
        lbx_view_x.Location = New Point(1032, 32)
        lbx_view_x.Name = "lbx_view_x"
        lbx_view_x.Size = New Size(48, 484)
        lbx_view_x.TabIndex = 13
        ' 
        ' cbx_testing_difficulty
        ' 
        cbx_testing_difficulty.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_testing_difficulty.FormattingEnabled = True
        cbx_testing_difficulty.Items.AddRange(New Object() {"Easiest", "Standard", "Moderate", "Hard", "Hardest", "Extreme"})
        cbx_testing_difficulty.Location = New Point(904, 32)
        cbx_testing_difficulty.Name = "cbx_testing_difficulty"
        cbx_testing_difficulty.Size = New Size(121, 23)
        cbx_testing_difficulty.TabIndex = 8
        ' 
        ' cbx_lock_co_op_alliances
        ' 
        cbx_lock_co_op_alliances.AutoSize = True
        cbx_lock_co_op_alliances.Location = New Point(760, 104)
        cbx_lock_co_op_alliances.Name = "cbx_lock_co_op_alliances"
        cbx_lock_co_op_alliances.Size = New Size(140, 19)
        cbx_lock_co_op_alliances.TabIndex = 7
        cbx_lock_co_op_alliances.Text = "Lock Co-Op Alliances"
        cbx_lock_co_op_alliances.UseVisualStyleBackColor = True
        ' 
        ' cbx_villager_force_drop
        ' 
        cbx_villager_force_drop.AutoSize = True
        cbx_villager_force_drop.Location = New Point(760, 80)
        cbx_villager_force_drop.Name = "cbx_villager_force_drop"
        cbx_villager_force_drop.Size = New Size(126, 19)
        cbx_villager_force_drop.TabIndex = 6
        cbx_villager_force_drop.Text = "Villager Force Drop"
        cbx_villager_force_drop.UseVisualStyleBackColor = True
        ' 
        ' cbx_collide_and_correcting
        ' 
        cbx_collide_and_correcting.AutoSize = True
        cbx_collide_and_correcting.Location = New Point(760, 56)
        cbx_collide_and_correcting.Name = "cbx_collide_and_correcting"
        cbx_collide_and_correcting.Size = New Size(145, 19)
        cbx_collide_and_correcting.TabIndex = 5
        cbx_collide_and_correcting.Text = "Collide and Correcting"
        cbx_collide_and_correcting.UseVisualStyleBackColor = True
        ' 
        ' cbx_full_tech_tree
        ' 
        cbx_full_tech_tree.AutoSize = True
        cbx_full_tech_tree.Location = New Point(760, 32)
        cbx_full_tech_tree.Name = "cbx_full_tech_tree"
        cbx_full_tech_tree.Size = New Size(96, 19)
        cbx_full_tech_tree.TabIndex = 4
        cbx_full_tech_tree.Text = "Full Tech Tree"
        cbx_full_tech_tree.UseVisualStyleBackColor = True
        ' 
        ' cbx_disabled_player
        ' 
        cbx_disabled_player.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_disabled_player.FormattingEnabled = True
        cbx_disabled_player.Items.AddRange(New Object() {"Gaia", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6", "Player 7", "Player 8"})
        cbx_disabled_player.Location = New Point(632, 32)
        cbx_disabled_player.Name = "cbx_disabled_player"
        cbx_disabled_player.Size = New Size(121, 23)
        cbx_disabled_player.TabIndex = 3
        ' 
        ' clb_disabled_techs
        ' 
        clb_disabled_techs.FormattingEnabled = True
        clb_disabled_techs.Location = New Point(424, 32)
        clb_disabled_techs.Name = "clb_disabled_techs"
        clb_disabled_techs.Size = New Size(200, 472)
        clb_disabled_techs.TabIndex = 2
        ' 
        ' clb_disabled_buildings
        ' 
        clb_disabled_buildings.FormattingEnabled = True
        clb_disabled_buildings.Location = New Point(216, 32)
        clb_disabled_buildings.Name = "clb_disabled_buildings"
        clb_disabled_buildings.Size = New Size(200, 472)
        clb_disabled_buildings.TabIndex = 1
        ' 
        ' clb_disabled_units
        ' 
        clb_disabled_units.FormattingEnabled = True
        clb_disabled_units.Location = New Point(8, 32)
        clb_disabled_units.Name = "clb_disabled_units"
        clb_disabled_units.Size = New Size(200, 472)
        clb_disabled_units.TabIndex = 0
        ' 
        ' tp_messages
        ' 
        tp_messages.Controls.Add(lbl_scout_string_id)
        tp_messages.Controls.Add(lbl_history_string_id)
        tp_messages.Controls.Add(lbl_loss_string_id)
        tp_messages.Controls.Add(lbl_victory_string_id)
        tp_messages.Controls.Add(lbl_hints_string_id)
        tp_messages.Controls.Add(lbl_instructions_string_id)
        tp_messages.Controls.Add(tbx_scout_string_id)
        tp_messages.Controls.Add(tbx_history_string_id)
        tp_messages.Controls.Add(tbx_loss_string_id)
        tp_messages.Controls.Add(tbx_victory_string_id)
        tp_messages.Controls.Add(tbx_hints_string_id)
        tp_messages.Controls.Add(tbx_instructions_string_id)
        tp_messages.Controls.Add(tbx_scout)
        tp_messages.Controls.Add(tbx_history)
        tp_messages.Controls.Add(tbx_loss)
        tp_messages.Controls.Add(tbx_victory)
        tp_messages.Controls.Add(tbx_hints)
        tp_messages.Controls.Add(tbx_instructions)
        tp_messages.Location = New Point(4, 24)
        tp_messages.Name = "tp_messages"
        tp_messages.Padding = New Padding(3)
        tp_messages.Size = New Size(1448, 524)
        tp_messages.TabIndex = 7
        tp_messages.Text = "Messages"
        tp_messages.UseVisualStyleBackColor = True
        ' 
        ' lbl_scout_string_id
        ' 
        lbl_scout_string_id.AutoSize = True
        lbl_scout_string_id.Location = New Point(1048, 8)
        lbl_scout_string_id.Name = "lbl_scout_string_id"
        lbl_scout_string_id.Size = New Size(93, 15)
        lbl_scout_string_id.TabIndex = 108
        lbl_scout_string_id.Text = "String ID / Scout"
        ' 
        ' lbl_history_string_id
        ' 
        lbl_history_string_id.AutoSize = True
        lbl_history_string_id.Location = New Point(840, 8)
        lbl_history_string_id.Name = "lbl_history_string_id"
        lbl_history_string_id.Size = New Size(101, 15)
        lbl_history_string_id.TabIndex = 107
        lbl_history_string_id.Text = "String ID / History"
        ' 
        ' lbl_loss_string_id
        ' 
        lbl_loss_string_id.AutoSize = True
        lbl_loss_string_id.Location = New Point(632, 8)
        lbl_loss_string_id.Name = "lbl_loss_string_id"
        lbl_loss_string_id.Size = New Size(86, 15)
        lbl_loss_string_id.TabIndex = 106
        lbl_loss_string_id.Text = "String ID / Loss"
        ' 
        ' lbl_victory_string_id
        ' 
        lbl_victory_string_id.AutoSize = True
        lbl_victory_string_id.Location = New Point(424, 8)
        lbl_victory_string_id.Name = "lbl_victory_string_id"
        lbl_victory_string_id.Size = New Size(100, 15)
        lbl_victory_string_id.TabIndex = 105
        lbl_victory_string_id.Text = "String ID / Victory"
        ' 
        ' lbl_hints_string_id
        ' 
        lbl_hints_string_id.AutoSize = True
        lbl_hints_string_id.Location = New Point(216, 8)
        lbl_hints_string_id.Name = "lbl_hints_string_id"
        lbl_hints_string_id.Size = New Size(91, 15)
        lbl_hints_string_id.TabIndex = 104
        lbl_hints_string_id.Text = "String ID / Hints"
        ' 
        ' lbl_instructions_string_id
        ' 
        lbl_instructions_string_id.AutoSize = True
        lbl_instructions_string_id.Location = New Point(8, 8)
        lbl_instructions_string_id.Name = "lbl_instructions_string_id"
        lbl_instructions_string_id.Size = New Size(125, 15)
        lbl_instructions_string_id.TabIndex = 103
        lbl_instructions_string_id.Text = "String ID / Instructions"
        ' 
        ' tbx_scout_string_id
        ' 
        tbx_scout_string_id.Location = New Point(1048, 32)
        tbx_scout_string_id.Name = "tbx_scout_string_id"
        tbx_scout_string_id.Size = New Size(200, 23)
        tbx_scout_string_id.TabIndex = 11
        ' 
        ' tbx_history_string_id
        ' 
        tbx_history_string_id.Location = New Point(840, 32)
        tbx_history_string_id.Name = "tbx_history_string_id"
        tbx_history_string_id.Size = New Size(200, 23)
        tbx_history_string_id.TabIndex = 10
        ' 
        ' tbx_loss_string_id
        ' 
        tbx_loss_string_id.Location = New Point(632, 32)
        tbx_loss_string_id.Name = "tbx_loss_string_id"
        tbx_loss_string_id.Size = New Size(200, 23)
        tbx_loss_string_id.TabIndex = 9
        ' 
        ' tbx_victory_string_id
        ' 
        tbx_victory_string_id.Location = New Point(424, 32)
        tbx_victory_string_id.Name = "tbx_victory_string_id"
        tbx_victory_string_id.Size = New Size(200, 23)
        tbx_victory_string_id.TabIndex = 8
        ' 
        ' tbx_hints_string_id
        ' 
        tbx_hints_string_id.Location = New Point(216, 32)
        tbx_hints_string_id.Name = "tbx_hints_string_id"
        tbx_hints_string_id.Size = New Size(200, 23)
        tbx_hints_string_id.TabIndex = 7
        ' 
        ' tbx_instructions_string_id
        ' 
        tbx_instructions_string_id.Location = New Point(8, 32)
        tbx_instructions_string_id.Name = "tbx_instructions_string_id"
        tbx_instructions_string_id.Size = New Size(200, 23)
        tbx_instructions_string_id.TabIndex = 6
        ' 
        ' tbx_scout
        ' 
        tbx_scout.AcceptsReturn = True
        tbx_scout.Location = New Point(1048, 64)
        tbx_scout.MaxLength = 4096
        tbx_scout.Multiline = True
        tbx_scout.Name = "tbx_scout"
        tbx_scout.ScrollBars = ScrollBars.Vertical
        tbx_scout.Size = New Size(200, 448)
        tbx_scout.TabIndex = 5
        tbx_scout.Text = "Scout Message"
        ' 
        ' tbx_history
        ' 
        tbx_history.AcceptsReturn = True
        tbx_history.Location = New Point(840, 64)
        tbx_history.MaxLength = 4096
        tbx_history.Multiline = True
        tbx_history.Name = "tbx_history"
        tbx_history.ScrollBars = ScrollBars.Vertical
        tbx_history.Size = New Size(200, 448)
        tbx_history.TabIndex = 4
        tbx_history.Text = "History Message"
        ' 
        ' tbx_loss
        ' 
        tbx_loss.AcceptsReturn = True
        tbx_loss.Location = New Point(632, 64)
        tbx_loss.MaxLength = 4096
        tbx_loss.Multiline = True
        tbx_loss.Name = "tbx_loss"
        tbx_loss.ScrollBars = ScrollBars.Vertical
        tbx_loss.Size = New Size(200, 448)
        tbx_loss.TabIndex = 3
        tbx_loss.Text = "Loss Message"
        ' 
        ' tbx_victory
        ' 
        tbx_victory.AcceptsReturn = True
        tbx_victory.Location = New Point(424, 64)
        tbx_victory.MaxLength = 4096
        tbx_victory.Multiline = True
        tbx_victory.Name = "tbx_victory"
        tbx_victory.ScrollBars = ScrollBars.Vertical
        tbx_victory.Size = New Size(200, 448)
        tbx_victory.TabIndex = 2
        tbx_victory.Text = "Victory Message"
        ' 
        ' tbx_hints
        ' 
        tbx_hints.AcceptsReturn = True
        tbx_hints.Location = New Point(216, 64)
        tbx_hints.MaxLength = 4096
        tbx_hints.Multiline = True
        tbx_hints.Name = "tbx_hints"
        tbx_hints.ScrollBars = ScrollBars.Vertical
        tbx_hints.Size = New Size(200, 448)
        tbx_hints.TabIndex = 1
        tbx_hints.Text = "Hints Message"
        ' 
        ' tbx_instructions
        ' 
        tbx_instructions.AcceptsReturn = True
        tbx_instructions.Location = New Point(8, 64)
        tbx_instructions.MaxLength = 4096
        tbx_instructions.Multiline = True
        tbx_instructions.Name = "tbx_instructions"
        tbx_instructions.ScrollBars = ScrollBars.Vertical
        tbx_instructions.Size = New Size(200, 448)
        tbx_instructions.TabIndex = 0
        tbx_instructions.Text = "Instructions Message"
        ' 
        ' tp_cinematics
        ' 
        tp_cinematics.Controls.Add(lbl_scenario_instructions_map)
        tp_cinematics.Controls.Add(lbl_loss_cinematics)
        tp_cinematics.Controls.Add(lbl_victory_cinematics)
        tp_cinematics.Controls.Add(lbl_pregame_cinematics)
        tp_cinematics.Controls.Add(cbx_instructions_cinematic)
        tp_cinematics.Controls.Add(cbx_loss_cinematic)
        tp_cinematics.Controls.Add(cbx_victory_cinematic)
        tp_cinematics.Controls.Add(cbx_pregame_cinematic)
        tp_cinematics.Location = New Point(4, 24)
        tp_cinematics.Name = "tp_cinematics"
        tp_cinematics.Padding = New Padding(3)
        tp_cinematics.Size = New Size(1448, 524)
        tp_cinematics.TabIndex = 8
        tp_cinematics.Text = "Cinematics"
        tp_cinematics.UseVisualStyleBackColor = True
        ' 
        ' lbl_scenario_instructions_map
        ' 
        lbl_scenario_instructions_map.AutoSize = True
        lbl_scenario_instructions_map.Location = New Point(392, 8)
        lbl_scenario_instructions_map.Name = "lbl_scenario_instructions_map"
        lbl_scenario_instructions_map.Size = New Size(144, 15)
        lbl_scenario_instructions_map.TabIndex = 107
        lbl_scenario_instructions_map.Text = "Scenario Instructions Map"
        ' 
        ' lbl_loss_cinematics
        ' 
        lbl_loss_cinematics.AutoSize = True
        lbl_loss_cinematics.Location = New Point(264, 8)
        lbl_loss_cinematics.Name = "lbl_loss_cinematics"
        lbl_loss_cinematics.Size = New Size(92, 15)
        lbl_loss_cinematics.TabIndex = 106
        lbl_loss_cinematics.Text = "Loss Cinematics"
        ' 
        ' lbl_victory_cinematics
        ' 
        lbl_victory_cinematics.AutoSize = True
        lbl_victory_cinematics.Location = New Point(136, 8)
        lbl_victory_cinematics.Name = "lbl_victory_cinematics"
        lbl_victory_cinematics.Size = New Size(106, 15)
        lbl_victory_cinematics.TabIndex = 105
        lbl_victory_cinematics.Text = "Victory Cinematics"
        ' 
        ' lbl_pregame_cinematics
        ' 
        lbl_pregame_cinematics.AutoSize = True
        lbl_pregame_cinematics.Location = New Point(8, 8)
        lbl_pregame_cinematics.Name = "lbl_pregame_cinematics"
        lbl_pregame_cinematics.Size = New Size(116, 15)
        lbl_pregame_cinematics.TabIndex = 104
        lbl_pregame_cinematics.Text = "Pregame Cinematics"
        ' 
        ' cbx_instructions_cinematic
        ' 
        cbx_instructions_cinematic.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_instructions_cinematic.FormattingEnabled = True
        cbx_instructions_cinematic.Items.AddRange(New Object() {"None"})
        cbx_instructions_cinematic.Location = New Point(392, 32)
        cbx_instructions_cinematic.Name = "cbx_instructions_cinematic"
        cbx_instructions_cinematic.Size = New Size(121, 23)
        cbx_instructions_cinematic.TabIndex = 3
        ' 
        ' cbx_loss_cinematic
        ' 
        cbx_loss_cinematic.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_loss_cinematic.FormattingEnabled = True
        cbx_loss_cinematic.Items.AddRange(New Object() {"None", "aoeiide_titlevideo.wmv"})
        cbx_loss_cinematic.Location = New Point(264, 32)
        cbx_loss_cinematic.Name = "cbx_loss_cinematic"
        cbx_loss_cinematic.Size = New Size(121, 23)
        cbx_loss_cinematic.TabIndex = 2
        ' 
        ' cbx_victory_cinematic
        ' 
        cbx_victory_cinematic.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_victory_cinematic.FormattingEnabled = True
        cbx_victory_cinematic.Items.AddRange(New Object() {"None", "aoeiide_titlevideo.wmv"})
        cbx_victory_cinematic.Location = New Point(136, 32)
        cbx_victory_cinematic.Name = "cbx_victory_cinematic"
        cbx_victory_cinematic.Size = New Size(121, 23)
        cbx_victory_cinematic.TabIndex = 1
        ' 
        ' cbx_pregame_cinematic
        ' 
        cbx_pregame_cinematic.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_pregame_cinematic.FormattingEnabled = True
        cbx_pregame_cinematic.Items.AddRange(New Object() {"None", "aoeiide_titlevideo.wmv"})
        cbx_pregame_cinematic.Location = New Point(8, 32)
        cbx_pregame_cinematic.Name = "cbx_pregame_cinematic"
        cbx_pregame_cinematic.Size = New Size(121, 23)
        cbx_pregame_cinematic.TabIndex = 0
        ' 
        ' tp_trigger
        ' 
        tp_trigger.Controls.Add(lbl_created_trigger)
        tp_trigger.Controls.Add(lbl_trigger_effects)
        tp_trigger.Controls.Add(lbl_trigger_conditions)
        tp_trigger.Controls.Add(btn_trigger_add_effect)
        tp_trigger.Controls.Add(btn_trigger_add_condition)
        tp_trigger.Controls.Add(lbx_created_trigger)
        tp_trigger.Controls.Add(cbx_trigger_display_on_screen)
        tp_trigger.Controls.Add(cbx_trigger_display_as_objective)
        tp_trigger.Controls.Add(tbx_trigger_short_description_string_id)
        tp_trigger.Controls.Add(tbx_trigger_description_string_id)
        tp_trigger.Controls.Add(tbx_trigger_short_description)
        tp_trigger.Controls.Add(tbx_trigger_description)
        tp_trigger.Controls.Add(cbx_trigger_looping)
        tp_trigger.Controls.Add(cbx_trigger_starting_state)
        tp_trigger.Controls.Add(tbx_trigger_name)
        tp_trigger.Controls.Add(lbx_trigger_effects)
        tp_trigger.Controls.Add(lbx_trigger_conditions)
        tp_trigger.Location = New Point(4, 24)
        tp_trigger.Name = "tp_trigger"
        tp_trigger.Padding = New Padding(3)
        tp_trigger.Size = New Size(1448, 524)
        tp_trigger.TabIndex = 9
        tp_trigger.Text = "Trigger"
        tp_trigger.UseVisualStyleBackColor = True
        ' 
        ' lbl_created_trigger
        ' 
        lbl_created_trigger.AutoSize = True
        lbl_created_trigger.Location = New Point(1064, 8)
        lbl_created_trigger.Name = "lbl_created_trigger"
        lbl_created_trigger.Size = New Size(87, 15)
        lbl_created_trigger.TabIndex = 110
        lbl_created_trigger.Text = "Created Trigger"
        ' 
        ' lbl_trigger_effects
        ' 
        lbl_trigger_effects.AutoSize = True
        lbl_trigger_effects.Location = New Point(232, 8)
        lbl_trigger_effects.Name = "lbl_trigger_effects"
        lbl_trigger_effects.Size = New Size(42, 15)
        lbl_trigger_effects.TabIndex = 109
        lbl_trigger_effects.Text = "Effects"
        ' 
        ' lbl_trigger_conditions
        ' 
        lbl_trigger_conditions.AutoSize = True
        lbl_trigger_conditions.Location = New Point(8, 8)
        lbl_trigger_conditions.Name = "lbl_trigger_conditions"
        lbl_trigger_conditions.Size = New Size(65, 15)
        lbl_trigger_conditions.TabIndex = 108
        lbl_trigger_conditions.Text = "Conditions"
        ' 
        ' btn_trigger_add_effect
        ' 
        btn_trigger_add_effect.Location = New Point(456, 144)
        btn_trigger_add_effect.Name = "btn_trigger_add_effect"
        btn_trigger_add_effect.Size = New Size(184, 23)
        btn_trigger_add_effect.TabIndex = 18
        btn_trigger_add_effect.Text = "Add Effect"
        btn_trigger_add_effect.UseVisualStyleBackColor = True
        ' 
        ' btn_trigger_add_condition
        ' 
        btn_trigger_add_condition.Location = New Point(456, 112)
        btn_trigger_add_condition.Name = "btn_trigger_add_condition"
        btn_trigger_add_condition.Size = New Size(184, 23)
        btn_trigger_add_condition.TabIndex = 17
        btn_trigger_add_condition.Text = "Add Condition"
        btn_trigger_add_condition.UseVisualStyleBackColor = True
        ' 
        ' lbx_created_trigger
        ' 
        lbx_created_trigger.FormattingEnabled = True
        lbx_created_trigger.ItemHeight = 15
        lbx_created_trigger.Location = New Point(1064, 32)
        lbx_created_trigger.Name = "lbx_created_trigger"
        lbx_created_trigger.ScrollAlwaysVisible = True
        lbx_created_trigger.Size = New Size(352, 469)
        lbx_created_trigger.TabIndex = 16
        ' 
        ' cbx_trigger_display_on_screen
        ' 
        cbx_trigger_display_on_screen.AutoSize = True
        cbx_trigger_display_on_screen.Location = New Point(856, 64)
        cbx_trigger_display_on_screen.Name = "cbx_trigger_display_on_screen"
        cbx_trigger_display_on_screen.Size = New Size(119, 19)
        cbx_trigger_display_on_screen.TabIndex = 10
        cbx_trigger_display_on_screen.Text = "Display on Screen"
        cbx_trigger_display_on_screen.UseVisualStyleBackColor = True
        ' 
        ' cbx_trigger_display_as_objective
        ' 
        cbx_trigger_display_as_objective.AutoSize = True
        cbx_trigger_display_as_objective.Location = New Point(648, 64)
        cbx_trigger_display_as_objective.Name = "cbx_trigger_display_as_objective"
        cbx_trigger_display_as_objective.Size = New Size(131, 19)
        cbx_trigger_display_as_objective.TabIndex = 9
        cbx_trigger_display_as_objective.Text = "Display as Objective"
        cbx_trigger_display_as_objective.UseVisualStyleBackColor = True
        ' 
        ' tbx_trigger_short_description_string_id
        ' 
        tbx_trigger_short_description_string_id.Location = New Point(856, 32)
        tbx_trigger_short_description_string_id.MaxLength = 240
        tbx_trigger_short_description_string_id.Name = "tbx_trigger_short_description_string_id"
        tbx_trigger_short_description_string_id.Size = New Size(200, 23)
        tbx_trigger_short_description_string_id.TabIndex = 8
        tbx_trigger_short_description_string_id.Text = "Short Description String ID"
        ' 
        ' tbx_trigger_description_string_id
        ' 
        tbx_trigger_description_string_id.Location = New Point(648, 32)
        tbx_trigger_description_string_id.MaxLength = 240
        tbx_trigger_description_string_id.Name = "tbx_trigger_description_string_id"
        tbx_trigger_description_string_id.Size = New Size(200, 23)
        tbx_trigger_description_string_id.TabIndex = 7
        tbx_trigger_description_string_id.Text = "Trigger Description String ID"
        ' 
        ' tbx_trigger_short_description
        ' 
        tbx_trigger_short_description.AcceptsReturn = True
        tbx_trigger_short_description.Location = New Point(856, 88)
        tbx_trigger_short_description.MaxLength = 240
        tbx_trigger_short_description.Multiline = True
        tbx_trigger_short_description.Name = "tbx_trigger_short_description"
        tbx_trigger_short_description.ScrollBars = ScrollBars.Vertical
        tbx_trigger_short_description.Size = New Size(200, 416)
        tbx_trigger_short_description.TabIndex = 6
        tbx_trigger_short_description.Text = "Short Description"
        ' 
        ' tbx_trigger_description
        ' 
        tbx_trigger_description.AcceptsReturn = True
        tbx_trigger_description.Location = New Point(648, 88)
        tbx_trigger_description.MaxLength = 4095
        tbx_trigger_description.Multiline = True
        tbx_trigger_description.Name = "tbx_trigger_description"
        tbx_trigger_description.ScrollBars = ScrollBars.Vertical
        tbx_trigger_description.Size = New Size(200, 416)
        tbx_trigger_description.TabIndex = 5
        tbx_trigger_description.Text = "Trigger Description"
        ' 
        ' cbx_trigger_looping
        ' 
        cbx_trigger_looping.AutoSize = True
        cbx_trigger_looping.Location = New Point(456, 88)
        cbx_trigger_looping.Name = "cbx_trigger_looping"
        cbx_trigger_looping.Size = New Size(109, 19)
        cbx_trigger_looping.TabIndex = 4
        cbx_trigger_looping.Text = "Trigger Looping"
        cbx_trigger_looping.UseVisualStyleBackColor = True
        ' 
        ' cbx_trigger_starting_state
        ' 
        cbx_trigger_starting_state.AutoSize = True
        cbx_trigger_starting_state.Location = New Point(456, 64)
        cbx_trigger_starting_state.Name = "cbx_trigger_starting_state"
        cbx_trigger_starting_state.Size = New Size(135, 19)
        cbx_trigger_starting_state.TabIndex = 3
        cbx_trigger_starting_state.Text = "Trigger Starting State"
        cbx_trigger_starting_state.UseVisualStyleBackColor = True
        ' 
        ' tbx_trigger_name
        ' 
        tbx_trigger_name.Location = New Point(456, 32)
        tbx_trigger_name.MaxLength = 240
        tbx_trigger_name.Name = "tbx_trigger_name"
        tbx_trigger_name.Size = New Size(184, 23)
        tbx_trigger_name.TabIndex = 2
        tbx_trigger_name.Text = "Trigger Name"
        ' 
        ' lbx_trigger_effects
        ' 
        lbx_trigger_effects.FormattingEnabled = True
        lbx_trigger_effects.ItemHeight = 15
        lbx_trigger_effects.Items.AddRange(New Object() {"None", "Acknowledge AI Signal", "Acknowledge AI Signal (Multiplayer)", "Activate Trigger", "AI Script Goal", "Attack Move", "Change Civilization Name", "Change Color Mood", "Change Diplomacy", "Change Object Armor", "Change Object Attack", "Change Object Caption", "Change Object Civilization Name", "Change Object Cost", "Change Object Description", "Change Object HP", "Change Object Icon", "Change Object Name", "Change Object Player Color", "Change Object Player Name", "Change Object Range", "Change Object Speed", "Change Object Stance", "Change Ownership", "Change Player Color", "Change Player Name", "Change Technology Cost", "Change Technology Description", "Change Technology Hotkey", "Change Technology Icon", "Change Technology Location", "Change Technology Name", "Change Technology Research Time", "Change Train Location", "Change Variable", "Change View", "Clear Instructions", "Clear Timer", "Create Garrisoned Object", "Create Object", "Create Object Armor", "Create Object Attack", "Damage Object", "Deactivate Trigger", "Declare Victory", "Delete Key", "Disable Object Deletion", "Disable Object Selection", "Disable Technology Stacking", "Disable Unit Targeting", "Display Instructions", "Display Timer", "Enable Object Deletion", "Enable Object Selection", "Enable Technology Stacking", "Enable Unit Targeting", "Enable/Disable Object", "Enable/Disable Technology", "Freeze Object", "Heal Object", "Initiate Research", "Kill Object", "Load Key Value", "Lock Gate", "Modify Attribute", "Modify Attribute By Variable", "Modify Resource", "Modify Resource By Variable", "Modify Variable By Attribute", "Modify Variable By Resource", "Patrol", "Place Foundation", "Play Sound", "Remove Object", "Replace Object", "Research Technology", "Script Call", "Send Chat", "Set Building Gather Point", "Set Object Cost", "Set Player Visibility", "Stop Object", "Store Key Value", "Task Object", "Teleport Object", "Train Unit", "Tribute", "Unload", "Unlock Gate", "Use Advanced Buttons"})
        lbx_trigger_effects.Location = New Point(232, 32)
        lbx_trigger_effects.Name = "lbx_trigger_effects"
        lbx_trigger_effects.Size = New Size(216, 469)
        lbx_trigger_effects.TabIndex = 1
        ' 
        ' lbx_trigger_conditions
        ' 
        lbx_trigger_conditions.FormattingEnabled = True
        lbx_trigger_conditions.ItemHeight = 15
        lbx_trigger_conditions.Items.AddRange(New Object() {"None", "Accumulate Attribute", "AI Signal", "Bring Object to Area", "Bring Object to Object", "Building is Trading", "Capture Object", "Chance", "Condition Joiner (AND)", "Condition Separator (OR)", "Destroy Object", "Difficulty Level", "Diplomacy State", "Display Timer Triggered", "Multiplayer AI Signal", "Object Has Action", "Object Has Target", "Object HP", "Object Not Visible", "Object Selected", "Object Selected (Multiplayer)", "Object Visible", "Object Visible (Multiplayer)", "Objects in Area", "Own Fewer Objects", "Own Objects", "Player Defeated", "Research Technology", "Researching Tech", "Script Call", "Technology State", "Timer", "Units Garrisoned", "Variable Value", "Victory Timer"})
        lbx_trigger_conditions.Location = New Point(8, 32)
        lbx_trigger_conditions.Name = "lbx_trigger_conditions"
        lbx_trigger_conditions.Size = New Size(216, 469)
        lbx_trigger_conditions.TabIndex = 0
        ' 
        ' tp_about
        ' 
        tp_about.Controls.Add(lbl_aoe2de_sm)
        tp_about.Location = New Point(4, 24)
        tp_about.Name = "tp_about"
        tp_about.Padding = New Padding(3)
        tp_about.Size = New Size(1448, 524)
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
        lbl_aoe2de_sm.Text = "Age of Empires 2 DE Scenario Maker" & vbCrLf & "Version: 0.0.4" & vbCrLf & "Created By: Jeremy ""SpoOkyMagician"" Levegood"
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
        tp_objects.ResumeLayout(False)
        tp_objects.PerformLayout()
        tp_diplomacy.ResumeLayout(False)
        tp_diplomacy.PerformLayout()
        tp_victory.ResumeLayout(False)
        tp_victory.PerformLayout()
        tp_options.ResumeLayout(False)
        tp_options.PerformLayout()
        tp_messages.ResumeLayout(False)
        tp_messages.PerformLayout()
        tp_cinematics.ResumeLayout(False)
        tp_cinematics.PerformLayout()
        tp_trigger.ResumeLayout(False)
        tp_trigger.PerformLayout()
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
    Public WithEvents tp_objects As TabPage
    Public WithEvents lbx_objects_1 As ListBox
    Public WithEvents btn_remove_unit As Button
    Public WithEvents btn_create_unit As Button
    Public WithEvents tp_diplomacy As TabPage
    Public WithEvents tp_victory As TabPage
    Public WithEvents tp_options As TabPage
    Public WithEvents tp_messages As TabPage
    Public WithEvents tp_cinematics As TabPage
    Public WithEvents tp_trigger As TabPage
    Friend WithEvents tp_about As TabPage
    Public WithEvents cbx_object_player As ComboBox
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
    Public WithEvents btn_set_terrain As Button
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
    Public WithEvents lbx_objects_2 As ListBox
    Public WithEvents lbx_placed_terrains As ListBox
    Public WithEvents lbl_important_note_units As Label
    Public WithEvents lbl_important_note_terrain As Label
    Public WithEvents rbn_standard As RadioButton
    Public WithEvents rbn_conquest As RadioButton
    Public WithEvents cbx_score As ComboBox
    Public WithEvents rbn_score As RadioButton
    Public WithEvents cbx_time_limit As ComboBox
    Public WithEvents rbn_time_limit As RadioButton
    Public WithEvents rbn_custom As RadioButton
    Public WithEvents tbx_exploration_total As TextBox
    Public WithEvents cbx_all As CheckBox
    Public WithEvents cbx_relics As CheckBox
    Public WithEvents cbx_exploration As CheckBox
    Public WithEvents cbx_conquest As CheckBox
    Public WithEvents tbx_relics_total As TextBox
    Public WithEvents rbn_secondary_game_mode As RadioButton
    Public WithEvents cbx_regicide As CheckBox
    Public WithEvents cbx_sudden_death As CheckBox
    Public WithEvents cbx_empire_wars As CheckBox
    Public WithEvents cbx_king_of_the_hill As CheckBox
    Public WithEvents tbx_instructions As TextBox
    Public WithEvents tbx_scout As TextBox
    Public WithEvents tbx_history As TextBox
    Public WithEvents tbx_loss As TextBox
    Public WithEvents tbx_victory As TextBox
    Public WithEvents tbx_hints As TextBox
    Public WithEvents tbx_history_string_id As TextBox
    Public WithEvents tbx_loss_string_id As TextBox
    Public WithEvents tbx_victory_string_id As TextBox
    Public WithEvents tbx_hints_string_id As TextBox
    Public WithEvents tbx_instructions_string_id As TextBox
    Public WithEvents tbx_scout_string_id As TextBox
    Public WithEvents cbx_instructions_cinematic As ComboBox
    Public WithEvents cbx_loss_cinematic As ComboBox
    Public WithEvents cbx_victory_cinematic As ComboBox
    Public WithEvents cbx_pregame_cinematic As ComboBox
    Public WithEvents lbx_trigger_conditions As ListBox
    Public WithEvents lbx_trigger_effects As ListBox
    Public WithEvents cbx_trigger_looping As CheckBox
    Public WithEvents cbx_trigger_starting_state As CheckBox
    Public WithEvents tbx_trigger_name As TextBox
    Public WithEvents tbx_trigger_description As TextBox
    Public WithEvents tbx_trigger_short_description As TextBox
    Public WithEvents tbx_trigger_short_description_string_id As TextBox
    Public WithEvents tbx_trigger_description_string_id As TextBox
    Public WithEvents cbx_trigger_display_on_screen As CheckBox
    Public WithEvents cbx_trigger_display_as_objective As CheckBox
    Public WithEvents btn_trigger_add_effect As Button
    Public WithEvents btn_trigger_add_condition As Button
    Public WithEvents lbx_created_trigger As ListBox
    Public WithEvents cbx_disabled_player As ComboBox
    Public WithEvents clb_disabled_techs As CheckedListBox
    Public WithEvents clb_disabled_buildings As CheckedListBox
    Public WithEvents clb_disabled_units As CheckedListBox
    Public WithEvents cbx_full_tech_tree As CheckBox
    Public WithEvents cbx_collide_and_correcting As CheckBox
    Public WithEvents cbx_lock_co_op_alliances As CheckBox
    Public WithEvents cbx_villager_force_drop As CheckBox
    Public WithEvents cbx_testing_difficulty As ComboBox
    Public WithEvents lbx_view_y As ListBox
    Public WithEvents lbx_view_x As ListBox
    Public WithEvents btn_camera_view As Button
    Friend WithEvents CheckBox2 As CheckBox
    Public WithEvents lbl_custom_map_size As Label
    Public WithEvents lbl_map_size As Label
    Public WithEvents lbl_default_terrain As Label
    Public WithEvents lbl_ai_map_type As Label
    Public WithEvents lbl_color_mood As Label
    Public WithEvents lbl_script_filename As Label
    Public WithEvents lbl_placed_terrains As Label
    Public WithEvents lbl_object_list_b As Label
    Public WithEvents lbl_object_list_a As Label
    Public WithEvents lbl_object_player As Label
    Public WithEvents lbl_placed_objects As Label
    Public WithEvents lbl_object_y As Label
    Public WithEvents lbl_object_x As Label
    Public WithEvents lbl_max_teams As Label
    Public WithEvents lbl_victory_condition As Label
    Public WithEvents lbl_score As Label
    Public WithEvents lbl_percentage As Label
    Public WithEvents lbl_time_limit As Label
    Public WithEvents lbl_disabled_buildings As Label
    Public WithEvents lbl_disabled_units As Label
    Public WithEvents lbl_disabled_techs As Label
    Public WithEvents lbl_testing_difficulty As Label
    Public WithEvents lbl_options_player As Label
    Public WithEvents lbl_scout_string_id As Label
    Public WithEvents lbl_history_string_id As Label
    Public WithEvents lbl_loss_string_id As Label
    Public WithEvents lbl_victory_string_id As Label
    Public WithEvents lbl_hints_string_id As Label
    Public WithEvents lbl_instructions_string_id As Label
    Public WithEvents lbl_scenario_instructions_map As Label
    Public WithEvents lbl_loss_cinematics As Label
    Public WithEvents lbl_victory_cinematics As Label
    Public WithEvents lbl_pregame_cinematics As Label
    Public WithEvents lbl_trigger_effects As Label
    Public WithEvents lbl_trigger_conditions As Label
    Public WithEvents lbl_created_trigger As Label
End Class
