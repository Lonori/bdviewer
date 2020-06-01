﻿namespace dbviewer
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.db_tree_list = new System.Windows.Forms.TreeView();
            this.tree_list_icon = new System.Windows.Forms.ImageList(this.components);
            this.table_query_result = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.log_panel = new System.Windows.Forms.Panel();
            this.log_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_database = new System.Windows.Forms.Panel();
            this.panel_table_data = new System.Windows.Forms.Panel();
            this.panel_table_list = new System.Windows.Forms.Panel();
            this.table_tables = new System.Windows.Forms.TableLayoutPanel();
            this.panel_sql = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel_table_create = new System.Windows.Forms.Panel();
            this.table_creator = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.textbox_table_name = new System.Windows.Forms.TextBox();
            this.button_add_column = new System.Windows.Forms.Button();
            this.button_table_create = new System.Windows.Forms.Button();
            this.tool_panel_container = new System.Windows.Forms.TableLayoutPanel();
            this.tool_panel = new System.Windows.Forms.ToolStrip();
            this.tool_panel_tsb1 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb2 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb3 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb4 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb5 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb6 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb7 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb8 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb9 = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel_db_create = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.create_database = new System.Windows.Forms.Button();
            this.name_new_db = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.main_split = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_bd = new System.Windows.Forms.Button();
            this.sub_split = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_cache = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.table_query_result)).BeginInit();
            this.log_panel.SuspendLayout();
            this.panel_database.SuspendLayout();
            this.panel_table_data.SuspendLayout();
            this.panel_table_list.SuspendLayout();
            this.panel_sql.SuspendLayout();
            this.panel_table_create.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tool_panel_container.SuspendLayout();
            this.tool_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_db_create.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_split)).BeginInit();
            this.main_split.Panel1.SuspendLayout();
            this.main_split.Panel2.SuspendLayout();
            this.main_split.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub_split)).BeginInit();
            this.sub_split.Panel1.SuspendLayout();
            this.sub_split.Panel2.SuspendLayout();
            this.sub_split.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_cache)).BeginInit();
            this.SuspendLayout();
            // 
            // db_tree_list
            // 
            this.db_tree_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.db_tree_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_tree_list.ImageIndex = 0;
            this.db_tree_list.ImageList = this.tree_list_icon;
            this.db_tree_list.Location = new System.Drawing.Point(0, 62);
            this.db_tree_list.Margin = new System.Windows.Forms.Padding(0);
            this.db_tree_list.Name = "db_tree_list";
            this.db_tree_list.SelectedImageIndex = 2;
            this.db_tree_list.Size = new System.Drawing.Size(198, 497);
            this.db_tree_list.TabIndex = 1;
            this.db_tree_list.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tree_list_icon
            // 
            this.tree_list_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tree_list_icon.ImageStream")));
            this.tree_list_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.tree_list_icon.Images.SetKeyName(0, "database.png");
            this.tree_list_icon.Images.SetKeyName(1, "b_browse.png");
            this.tree_list_icon.Images.SetKeyName(2, "play.png");
            // 
            // table_query_result
            // 
            this.table_query_result.BackgroundColor = System.Drawing.SystemColors.Control;
            this.table_query_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_query_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_query_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_query_result.Location = new System.Drawing.Point(0, 0);
            this.table_query_result.Margin = new System.Windows.Forms.Padding(0);
            this.table_query_result.Name = "table_query_result";
            this.table_query_result.Size = new System.Drawing.Size(778, 406);
            this.table_query_result.TabIndex = 2;
            this.table_query_result.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.table_query_result_DataError);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 4, 4);
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Базы данных:";
            // 
            // log_panel
            // 
            this.log_panel.AutoScroll = true;
            this.log_panel.BackColor = System.Drawing.SystemColors.Window;
            this.log_panel.Controls.Add(this.log_label);
            this.log_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_panel.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_panel.Location = new System.Drawing.Point(0, 23);
            this.log_panel.Margin = new System.Windows.Forms.Padding(0);
            this.log_panel.Name = "log_panel";
            this.log_panel.Size = new System.Drawing.Size(778, 92);
            this.log_panel.TabIndex = 4;
            // 
            // log_label
            // 
            this.log_label.AutoSize = true;
            this.log_label.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_label.Location = new System.Drawing.Point(4, 4);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(0, 16);
            this.log_label.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Лог:";
            // 
            // panel_database
            // 
            this.panel_database.BackColor = System.Drawing.Color.Transparent;
            this.panel_database.Controls.Add(this.panel_table_data);
            this.panel_database.Controls.Add(this.panel_table_list);
            this.panel_database.Controls.Add(this.panel_sql);
            this.panel_database.Controls.Add(this.panel_table_create);
            this.panel_database.Controls.Add(this.tool_panel_container);
            this.panel_database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_database.Location = new System.Drawing.Point(0, 0);
            this.panel_database.Margin = new System.Windows.Forms.Padding(0);
            this.panel_database.Name = "panel_database";
            this.panel_database.Size = new System.Drawing.Size(778, 438);
            this.panel_database.TabIndex = 7;
            this.panel_database.Visible = false;
            // 
            // panel_table_data
            // 
            this.panel_table_data.Controls.Add(this.table_query_result);
            this.panel_table_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_table_data.Location = new System.Drawing.Point(0, 32);
            this.panel_table_data.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_data.Name = "panel_table_data";
            this.panel_table_data.Size = new System.Drawing.Size(778, 406);
            this.panel_table_data.TabIndex = 4;
            this.panel_table_data.Visible = false;
            // 
            // panel_table_list
            // 
            this.panel_table_list.AutoScroll = true;
            this.panel_table_list.Controls.Add(this.table_tables);
            this.panel_table_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_table_list.Location = new System.Drawing.Point(0, 32);
            this.panel_table_list.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_list.Name = "panel_table_list";
            this.panel_table_list.Size = new System.Drawing.Size(778, 406);
            this.panel_table_list.TabIndex = 2;
            this.panel_table_list.Visible = false;
            // 
            // table_tables
            // 
            this.table_tables.BackColor = System.Drawing.Color.Transparent;
            this.table_tables.ColumnCount = 5;
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_tables.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_tables.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_tables.Location = new System.Drawing.Point(0, 0);
            this.table_tables.Margin = new System.Windows.Forms.Padding(0);
            this.table_tables.Name = "table_tables";
            this.table_tables.RowCount = 1;
            this.table_tables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_tables.Size = new System.Drawing.Size(778, 30);
            this.table_tables.TabIndex = 0;
            // 
            // panel_sql
            // 
            this.panel_sql.Controls.Add(this.textBox2);
            this.panel_sql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sql.Location = new System.Drawing.Point(0, 32);
            this.panel_sql.Margin = new System.Windows.Forms.Padding(0);
            this.panel_sql.Name = "panel_sql";
            this.panel_sql.Size = new System.Drawing.Size(778, 406);
            this.panel_sql.TabIndex = 5;
            this.panel_sql.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(778, 406);
            this.textBox2.TabIndex = 0;
            // 
            // panel_table_create
            // 
            this.panel_table_create.AutoScroll = true;
            this.panel_table_create.Controls.Add(this.table_creator);
            this.panel_table_create.Controls.Add(this.tableLayoutPanel2);
            this.panel_table_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_table_create.Location = new System.Drawing.Point(0, 32);
            this.panel_table_create.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_create.Name = "panel_table_create";
            this.panel_table_create.Size = new System.Drawing.Size(778, 406);
            this.panel_table_create.TabIndex = 2;
            this.panel_table_create.Visible = false;
            // 
            // table_creator
            // 
            this.table_creator.BackColor = System.Drawing.Color.Transparent;
            this.table_creator.ColumnCount = 5;
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_creator.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_creator.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_creator.Location = new System.Drawing.Point(0, 40);
            this.table_creator.Margin = new System.Windows.Forms.Padding(0);
            this.table_creator.Name = "table_creator";
            this.table_creator.RowCount = 1;
            this.table_creator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_creator.Size = new System.Drawing.Size(778, 30);
            this.table_creator.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textbox_table_name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_add_column, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_table_create, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 40);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(0, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 32);
            this.label14.TabIndex = 2;
            this.label14.Text = "Имя таблицы:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textbox_table_name
            // 
            this.textbox_table_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_table_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_table_name.Location = new System.Drawing.Point(134, 4);
            this.textbox_table_name.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_table_name.Name = "textbox_table_name";
            this.textbox_table_name.Size = new System.Drawing.Size(350, 32);
            this.textbox_table_name.TabIndex = 1;
            // 
            // button_add_column
            // 
            this.button_add_column.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_add_column.FlatAppearance.BorderSize = 0;
            this.button_add_column.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_column.Location = new System.Drawing.Point(592, 4);
            this.button_add_column.Margin = new System.Windows.Forms.Padding(4);
            this.button_add_column.Name = "button_add_column";
            this.button_add_column.Size = new System.Drawing.Size(182, 32);
            this.button_add_column.TabIndex = 3;
            this.button_add_column.Text = "Добавить поле";
            this.button_add_column.UseVisualStyleBackColor = false;
            this.button_add_column.Click += new System.EventHandler(this.button_add_column_Click);
            // 
            // button_table_create
            // 
            this.button_table_create.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_table_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_table_create.FlatAppearance.BorderSize = 0;
            this.button_table_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_table_create.Location = new System.Drawing.Point(492, 4);
            this.button_table_create.Margin = new System.Windows.Forms.Padding(4);
            this.button_table_create.Name = "button_table_create";
            this.button_table_create.Size = new System.Drawing.Size(92, 32);
            this.button_table_create.TabIndex = 3;
            this.button_table_create.Text = "Создать";
            this.button_table_create.UseVisualStyleBackColor = false;
            this.button_table_create.Click += new System.EventHandler(this.button_table_create_Click);
            // 
            // tool_panel_container
            // 
            this.tool_panel_container.ColumnCount = 2;
            this.tool_panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tool_panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tool_panel_container.Controls.Add(this.tool_panel, 0, 0);
            this.tool_panel_container.Controls.Add(this.panel3, 1, 0);
            this.tool_panel_container.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_panel_container.Location = new System.Drawing.Point(0, 0);
            this.tool_panel_container.Margin = new System.Windows.Forms.Padding(0);
            this.tool_panel_container.Name = "tool_panel_container";
            this.tool_panel_container.RowCount = 1;
            this.tool_panel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tool_panel_container.Size = new System.Drawing.Size(778, 32);
            this.tool_panel_container.TabIndex = 5;
            // 
            // tool_panel
            // 
            this.tool_panel.BackColor = System.Drawing.Color.Transparent;
            this.tool_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tool_panel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool_panel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tool_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_panel_tsb1,
            this.tool_panel_tsb2,
            this.tool_panel_tsb3,
            this.tool_panel_tsb4,
            this.tool_panel_tsb5,
            this.tool_panel_tsb6,
            this.tool_panel_tsb7,
            this.tool_panel_tsb8,
            this.tool_panel_tsb9});
            this.tool_panel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tool_panel.Location = new System.Drawing.Point(0, 0);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Padding = new System.Windows.Forms.Padding(0);
            this.tool_panel.Size = new System.Drawing.Size(544, 32);
            this.tool_panel.TabIndex = 3;
            this.tool_panel.Text = "toolStrip2";
            // 
            // tool_panel_tsb1
            // 
            this.tool_panel_tsb1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb1.Image = global::dbviewer.Properties.Resources.b_browse;
            this.tool_panel_tsb1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb1.Name = "tool_panel_tsb1";
            this.tool_panel_tsb1.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb1.Text = "Обзор";
            this.tool_panel_tsb1.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb2
            // 
            this.tool_panel_tsb2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb2.Image = global::dbviewer.Properties.Resources.b_props;
            this.tool_panel_tsb2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb2.Name = "tool_panel_tsb2";
            this.tool_panel_tsb2.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb2.Text = "Структура";
            this.tool_panel_tsb2.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb3
            // 
            this.tool_panel_tsb3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb3.Image = global::dbviewer.Properties.Resources.b_table_add;
            this.tool_panel_tsb3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb3.Name = "tool_panel_tsb3";
            this.tool_panel_tsb3.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb3.Text = "Создать таблицу";
            this.tool_panel_tsb3.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb4
            // 
            this.tool_panel_tsb4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb4.Image = global::dbviewer.Properties.Resources.b_sql;
            this.tool_panel_tsb4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb4.Name = "tool_panel_tsb4";
            this.tool_panel_tsb4.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb4.Text = "SQL";
            this.tool_panel_tsb4.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb5
            // 
            this.tool_panel_tsb5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb5.Image = global::dbviewer.Properties.Resources.b_insrow;
            this.tool_panel_tsb5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb5.Name = "tool_panel_tsb5";
            this.tool_panel_tsb5.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb5.Text = "Вставить";
            this.tool_panel_tsb5.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb6
            // 
            this.tool_panel_tsb6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb6.Image = global::dbviewer.Properties.Resources.b_routines;
            this.tool_panel_tsb6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb6.Name = "tool_panel_tsb6";
            this.tool_panel_tsb6.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb6.Text = "Процедуры";
            this.tool_panel_tsb6.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb7
            // 
            this.tool_panel_tsb7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb7.Image = global::dbviewer.Properties.Resources.b_triggers;
            this.tool_panel_tsb7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb7.Name = "tool_panel_tsb7";
            this.tool_panel_tsb7.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb7.Text = "Тригеры";
            this.tool_panel_tsb7.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb8
            // 
            this.tool_panel_tsb8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb8.Image = global::dbviewer.Properties.Resources.b_deltbl;
            this.tool_panel_tsb8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb8.Name = "tool_panel_tsb8";
            this.tool_panel_tsb8.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb8.Text = "Удалить таблицу";
            this.tool_panel_tsb8.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb9
            // 
            this.tool_panel_tsb9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb9.Image = global::dbviewer.Properties.Resources.db_remove;
            this.tool_panel_tsb9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb9.Name = "tool_panel_tsb9";
            this.tool_panel_tsb9.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb9.Text = "Удалить базу данных";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(544, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(234, 32);
            this.panel3.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.Tag = "Поиск";
            this.textBox1.Text = "Поиск";
            this.textBox1.Enter += new System.EventHandler(this.plaseholder_listener_Enter);
            this.textBox1.Leave += new System.EventHandler(this.plaseholder_listener_Leave);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // panel_db_create
            // 
            this.panel_db_create.BackColor = System.Drawing.Color.Transparent;
            this.panel_db_create.Controls.Add(this.tableLayoutPanel1);
            this.panel_db_create.Controls.Add(this.label1);
            this.panel_db_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_db_create.Location = new System.Drawing.Point(0, 0);
            this.panel_db_create.Margin = new System.Windows.Forms.Padding(0);
            this.panel_db_create.Name = "panel_db_create";
            this.panel_db_create.Size = new System.Drawing.Size(778, 438);
            this.panel_db_create.TabIndex = 9;
            this.panel_db_create.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.create_database, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.name_new_db, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 32);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // create_database
            // 
            this.create_database.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_database.FlatAppearance.BorderSize = 0;
            this.create_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_database.Location = new System.Drawing.Point(593, 0);
            this.create_database.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.create_database.Name = "create_database";
            this.create_database.Size = new System.Drawing.Size(175, 32);
            this.create_database.TabIndex = 2;
            this.create_database.Text = "Создать";
            this.create_database.UseVisualStyleBackColor = false;
            this.create_database.Click += new System.EventHandler(this.create_database_Click);
            // 
            // name_new_db
            // 
            this.name_new_db.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_new_db.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_new_db.Location = new System.Drawing.Point(0, 0);
            this.name_new_db.Margin = new System.Windows.Forms.Padding(0);
            this.name_new_db.Name = "name_new_db";
            this.name_new_db.Size = new System.Drawing.Size(583, 32);
            this.name_new_db.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(14, 34, 4, 4);
            this.label1.Size = new System.Drawing.Size(214, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создать базу данных:";
            // 
            // main_split
            // 
            this.main_split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_split.Location = new System.Drawing.Point(0, 0);
            this.main_split.Margin = new System.Windows.Forms.Padding(0);
            this.main_split.Name = "main_split";
            // 
            // main_split.Panel1
            // 
            this.main_split.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.main_split.Panel1.Controls.Add(this.panel1);
            this.main_split.Panel1MinSize = 140;
            // 
            // main_split.Panel2
            // 
            this.main_split.Panel2.Controls.Add(this.sub_split);
            this.main_split.Panel2MinSize = 200;
            this.main_split.Size = new System.Drawing.Size(984, 561);
            this.main_split.SplitterDistance = 200;
            this.main_split.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.db_tree_list);
            this.panel1.Controls.Add(this.create_bd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 559);
            this.panel1.TabIndex = 7;
            // 
            // create_bd
            // 
            this.create_bd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_bd.Dock = System.Windows.Forms.DockStyle.Top;
            this.create_bd.FlatAppearance.BorderSize = 0;
            this.create_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_bd.Image = global::dbviewer.Properties.Resources.b_newdb;
            this.create_bd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create_bd.Location = new System.Drawing.Point(0, 32);
            this.create_bd.Margin = new System.Windows.Forms.Padding(0);
            this.create_bd.Name = "create_bd";
            this.create_bd.Size = new System.Drawing.Size(198, 30);
            this.create_bd.TabIndex = 6;
            this.create_bd.Text = "Создать БД";
            this.create_bd.UseVisualStyleBackColor = false;
            this.create_bd.Click += new System.EventHandler(this.create_bd_Click);
            // 
            // sub_split
            // 
            this.sub_split.BackColor = System.Drawing.Color.Transparent;
            this.sub_split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sub_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub_split.Location = new System.Drawing.Point(0, 0);
            this.sub_split.Margin = new System.Windows.Forms.Padding(0);
            this.sub_split.Name = "sub_split";
            this.sub_split.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sub_split.Panel1
            // 
            this.sub_split.Panel1.Controls.Add(this.panel_database);
            this.sub_split.Panel1.Controls.Add(this.panel_db_create);
            this.sub_split.Panel1MinSize = 200;
            // 
            // sub_split.Panel2
            // 
            this.sub_split.Panel2.Controls.Add(this.panel2);
            this.sub_split.Panel2MinSize = 100;
            this.sub_split.Size = new System.Drawing.Size(780, 561);
            this.sub_split.SplitterDistance = 440;
            this.sub_split.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.log_panel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 115);
            this.panel2.TabIndex = 6;
            // 
            // data_cache
            // 
            this.data_cache.DataSetName = "NewDataSet";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.main_split);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_query_result)).EndInit();
            this.log_panel.ResumeLayout(false);
            this.log_panel.PerformLayout();
            this.panel_database.ResumeLayout(false);
            this.panel_table_data.ResumeLayout(false);
            this.panel_table_list.ResumeLayout(false);
            this.panel_sql.ResumeLayout(false);
            this.panel_sql.PerformLayout();
            this.panel_table_create.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tool_panel_container.ResumeLayout(false);
            this.tool_panel_container.PerformLayout();
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_db_create.ResumeLayout(false);
            this.panel_db_create.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.main_split.Panel1.ResumeLayout(false);
            this.main_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_split)).EndInit();
            this.main_split.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sub_split.Panel1.ResumeLayout(false);
            this.sub_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sub_split)).EndInit();
            this.sub_split.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_cache)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView db_tree_list;
        private System.Windows.Forms.DataGridView table_query_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel log_panel;
        private System.Windows.Forms.Label log_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_bd;
        private System.Windows.Forms.Panel panel_database;
        private System.Windows.Forms.Panel panel_db_create;
        private System.Windows.Forms.Button create_database;
        private System.Windows.Forms.TextBox name_new_db;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_table_list;
        private System.Windows.Forms.TableLayoutPanel table_tables;
        private System.Windows.Forms.Panel panel_table_create;
        private System.Windows.Forms.TableLayoutPanel table_creator;
        private System.Windows.Forms.Button button_add_column;
        private System.Windows.Forms.Button button_table_create;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textbox_table_name;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.SplitContainer main_split;
        private System.Windows.Forms.SplitContainer sub_split;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_table_data;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tool_panel_container;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip tool_panel;
        private System.Windows.Forms.Panel panel_sql;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb1;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb2;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb3;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb4;
        private System.Windows.Forms.ImageList tree_list_icon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb5;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb6;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb7;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb8;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb9;
        private System.Data.DataSet data_cache;
    }
}

