using EquipmentDB.Model;

namespace EquipmentDB.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фирмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oрганизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводВЭксплуатациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.временноеИспользованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списанноеОборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверкаОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ответсвенныеСотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.помещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПомещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корпусаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.резервированиеБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.восстановитьФайлыБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоТипамБалансаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоКорпусамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоСотрудникамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomEquipmentColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.EquipmentLeasingColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.WriteOffShowColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteOffColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInventoryNumber = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEquipmentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBalanceType = new System.Windows.Forms.ComboBox();
            this.comboBoxEquipType = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturers = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddEquip = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.отчетыПоОборудованииСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочныеДанныеToolStripMenuItem,
            this.оборудованиеToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.помещенияToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочныеДанныеToolStripMenuItem
            // 
            this.справочныеДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фирмыToolStripMenuItem,
            this.типОборудованияToolStripMenuItem,
            this.должностьToolStripMenuItem,
            this.oрганизацииToolStripMenuItem});
            this.справочныеДанныеToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_BT_binder_905575;
            this.справочныеДанныеToolStripMenuItem.Name = "справочныеДанныеToolStripMenuItem";
            this.справочныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.справочныеДанныеToolStripMenuItem.Text = "Справочные данные";
            // 
            // фирмыToolStripMenuItem
            // 
            this.фирмыToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.industry_16;
            this.фирмыToolStripMenuItem.Name = "фирмыToolStripMenuItem";
            this.фирмыToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.фирмыToolStripMenuItem.Text = "Фирма изготовитель";
            this.фирмыToolStripMenuItem.Click += new System.EventHandler(this.фирмыToolStripMenuItem_Click);
            // 
            // типОборудованияToolStripMenuItem
            // 
            this.типОборудованияToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.artboard_16;
            this.типОборудованияToolStripMenuItem.Name = "типОборудованияToolStripMenuItem";
            this.типОборудованияToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.типОборудованияToolStripMenuItem.Text = "Тип оборудования";
            this.типОборудованияToolStripMenuItem.Click += new System.EventHandler(this.типОборудованияToolStripMenuItem_Click);
            // 
            // должностьToolStripMenuItem
            // 
            this.должностьToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_user_employee_id_badge_card_3209204;
            this.должностьToolStripMenuItem.Name = "должностьToolStripMenuItem";
            this.должностьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.должностьToolStripMenuItem.Text = "Должности";
            this.должностьToolStripMenuItem.Click += new System.EventHandler(this.должностьToolStripMenuItem_Click);
            // 
            // oрганизацииToolStripMenuItem
            // 
            this.oрганизацииToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_organization_298836;
            this.oрганизацииToolStripMenuItem.Name = "oрганизацииToolStripMenuItem";
            this.oрганизацииToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.oрганизацииToolStripMenuItem.Text = "Oрганизации";
            this.oрганизацииToolStripMenuItem.Click += new System.EventHandler(this.oрганизацииToolStripMenuItem_Click);
            // 
            // оборудованиеToolStripMenuItem
            // 
            this.оборудованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вводВЭксплуатациюToolStripMenuItem,
            this.временноеИспользованиеToolStripMenuItem,
            this.списанноеОборудованиеToolStripMenuItem,
            this.сверкаОборудованияToolStripMenuItem});
            this.оборудованиеToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_computer_103447;
            this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.оборудованиеToolStripMenuItem.Text = "Оборудование";
            // 
            // вводВЭксплуатациюToolStripMenuItem
            // 
            this.вводВЭксплуатациюToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_architecture_interior_26_809094;
            this.вводВЭксплуатациюToolStripMenuItem.Name = "вводВЭксплуатациюToolStripMenuItem";
            this.вводВЭксплуатациюToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.вводВЭксплуатациюToolStripMenuItem.Text = "Оборудование в эксплуатации";
            this.вводВЭксплуатациюToolStripMenuItem.Click += new System.EventHandler(this.вводВЭксплуатациюToolStripMenuItem_Click);
            // 
            // временноеИспользованиеToolStripMenuItem
            // 
            this.временноеИспользованиеToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_62_Client_User_costs_employee_finance_money_person_43081841;
            this.временноеИспользованиеToolStripMenuItem.Name = "временноеИспользованиеToolStripMenuItem";
            this.временноеИспользованиеToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.временноеИспользованиеToolStripMenuItem.Text = "Оборудование во временном использовании";
            this.временноеИспользованиеToolStripMenuItem.Click += new System.EventHandler(this.временноеИспользованиеToolStripMenuItem_Click);
            // 
            // списанноеОборудованиеToolStripMenuItem
            // 
            this.списанноеОборудованиеToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_image2vector_4_2807499;
            this.списанноеОборудованиеToolStripMenuItem.Name = "списанноеОборудованиеToolStripMenuItem";
            this.списанноеОборудованиеToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.списанноеОборудованиеToolStripMenuItem.Text = "Списанное оборудование";
            this.списанноеОборудованиеToolStripMenuItem.Click += new System.EventHandler(this.списанноеОборудованиеToolStripMenuItem_Click);
            // 
            // сверкаОборудованияToolStripMenuItem
            // 
            this.сверкаОборудованияToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_pending_wait_time_revise_unfinish_3209435;
            this.сверкаОборудованияToolStripMenuItem.Name = "сверкаОборудованияToolStripMenuItem";
            this.сверкаОборудованияToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.сверкаОборудованияToolStripMenuItem.Text = "Сверка оборудования";
            this.сверкаОборудованияToolStripMenuItem.Click += new System.EventHandler(this.сверкаОборудованияToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem1,
            this.ответсвенныеСотрудникиToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.post_16;
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.Image = global::EquipmentDB.Properties.Resources.post_16;
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem1.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem1_Click);
            // 
            // ответсвенныеСотрудникиToolStripMenuItem1
            // 
            this.ответсвенныеСотрудникиToolStripMenuItem1.Image = global::EquipmentDB.Properties.Resources.iconfinder_user_employee_id_badge_card_3209204__1_;
            this.ответсвенныеСотрудникиToolStripMenuItem1.Name = "ответсвенныеСотрудникиToolStripMenuItem1";
            this.ответсвенныеСотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.ответсвенныеСотрудникиToolStripMenuItem1.Text = "Ответсвенные сотрудники";
            this.ответсвенныеСотрудникиToolStripMenuItem1.Click += new System.EventHandler(this.ответсвенныеСотрудникиToolStripMenuItem1_Click);
            // 
            // помещенияToolStripMenuItem
            // 
            this.помещенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеПомещенияToolStripMenuItem,
            this.корпусаToolStripMenuItem1});
            this.помещенияToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_house_shape_PhotoshopSupply_com_4_3966450;
            this.помещенияToolStripMenuItem.Name = "помещенияToolStripMenuItem";
            this.помещенияToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.помещенияToolStripMenuItem.Text = "Помещения";
            // 
            // всеПомещенияToolStripMenuItem
            // 
            this.всеПомещенияToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_popular_12_5365983;
            this.всеПомещенияToolStripMenuItem.Name = "всеПомещенияToolStripMenuItem";
            this.всеПомещенияToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.всеПомещенияToolStripMenuItem.Text = "Все помещения";
            this.всеПомещенияToolStripMenuItem.Click += new System.EventHandler(this.всеПомещенияToolStripMenuItem_Click);
            // 
            // корпусаToolStripMenuItem1
            // 
            this.корпусаToolStripMenuItem1.Image = global::EquipmentDB.Properties.Resources.iconfinder_Home_Alt_4737439;
            this.корпусаToolStripMenuItem1.Name = "корпусаToolStripMenuItem1";
            this.корпусаToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.корпусаToolStripMenuItem1.Text = "Корпуса";
            this.корпусаToolStripMenuItem1.Click += new System.EventHandler(this.корпусаToolStripMenuItem1_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem1,
            this.резервированиеБДToolStripMenuItem,
            this.восстановитьФайлыБДToolStripMenuItem});
            this.сервисToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_28_Settings_4620073;
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // пользователиToolStripMenuItem1
            // 
            this.пользователиToolStripMenuItem1.Image = global::EquipmentDB.Properties.Resources.iconfinder_lock_298817;
            this.пользователиToolStripMenuItem1.Name = "пользователиToolStripMenuItem1";
            this.пользователиToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.пользователиToolStripMenuItem1.Text = "Пользователи";
            this.пользователиToolStripMenuItem1.Click += new System.EventHandler(this.пользователиToolStripMenuItem1_Click);
            // 
            // резервированиеБДToolStripMenuItem
            // 
            this.резервированиеБДToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_backup_171273;
            this.резервированиеБДToolStripMenuItem.Name = "резервированиеБДToolStripMenuItem";
            this.резервированиеБДToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.резервированиеБДToolStripMenuItem.Text = "Резервирование БД";
            this.резервированиеБДToolStripMenuItem.Click += new System.EventHandler(this.резервированиеБДToolStripMenuItem_Click);
            // 
            // восстановитьФайлыБДToolStripMenuItem
            // 
            this.восстановитьФайлыБДToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.restore_3832193;
            this.восстановитьФайлыБДToolStripMenuItem.Name = "восстановитьФайлыБДToolStripMenuItem";
            this.восстановитьФайлыБДToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.восстановитьФайлыБДToolStripMenuItem.Text = "Восстановить файлы БД";
            this.восстановитьФайлыБДToolStripMenuItem.Click += new System.EventHandler(this.восстановитьФайлыБДToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетПоТипамБалансаToolStripMenuItem,
            this.отчетПоКорпусамToolStripMenuItem,
            this.отчетПоСотрудникамToolStripMenuItem,
            this.отчетыПоОборудованииСотрудниковToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчетПоТипамБалансаToolStripMenuItem
            // 
            this.отчетПоТипамБалансаToolStripMenuItem.Name = "отчетПоТипамБалансаToolStripMenuItem";
            this.отчетПоТипамБалансаToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.отчетПоТипамБалансаToolStripMenuItem.Text = "Отчет по типам баланса";
            this.отчетПоТипамБалансаToolStripMenuItem.Click += new System.EventHandler(this.отчетПоТипамБалансаToolStripMenuItem_Click);
            // 
            // отчетПоКорпусамToolStripMenuItem
            // 
            this.отчетПоКорпусамToolStripMenuItem.Name = "отчетПоКорпусамToolStripMenuItem";
            this.отчетПоКорпусамToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.отчетПоКорпусамToolStripMenuItem.Text = "Отчет по корпусам";
            this.отчетПоКорпусамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоКорпусамToolStripMenuItem_Click);
            // 
            // отчетПоСотрудникамToolStripMenuItem
            // 
            this.отчетПоСотрудникамToolStripMenuItem.Name = "отчетПоСотрудникамToolStripMenuItem";
            this.отчетПоСотрудникамToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.отчетПоСотрудникамToolStripMenuItem.Text = "Отчет по сотрудникам";
            this.отчетПоСотрудникамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоСотрудникамToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.iconfinder_v_31_3162614;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Image = global::EquipmentDB.Properties.Resources.iconfinder_reference_1348650;
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Image = global::EquipmentDB.Properties.Resources.help;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentIDDataGridViewTextBoxColumn,
            this.equipmentTypeDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.Model,
            this.equipmentNameDataGridViewTextBoxColumn,
            this.balanceTypeDataGridViewTextBoxColumn,
            this.serialDataGridViewTextBoxColumn,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.RoomEquipmentColumn,
            this.EquipmentLeasingColumn,
            this.WriteOffShowColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.WriteOffColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.dataGridView.DataSource = this.equipmentBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 198);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1330, 383);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // equipmentIDDataGridViewTextBoxColumn
            // 
            this.equipmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.equipmentIDDataGridViewTextBoxColumn.DataPropertyName = "Equipment_ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.equipmentIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.equipmentIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.equipmentIDDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.equipmentIDDataGridViewTextBoxColumn.Name = "equipmentIDDataGridViewTextBoxColumn";
            this.equipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipmentIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // equipmentTypeDataGridViewTextBoxColumn
            // 
            this.equipmentTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.equipmentTypeDataGridViewTextBoxColumn.DataPropertyName = "EquipmentType";
            this.equipmentTypeDataGridViewTextBoxColumn.HeaderText = "Тип ";
            this.equipmentTypeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.equipmentTypeDataGridViewTextBoxColumn.Name = "equipmentTypeDataGridViewTextBoxColumn";
            this.equipmentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.manufacturerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 90;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Width = 90;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Модель";
            this.Model.MinimumWidth = 100;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // equipmentNameDataGridViewTextBoxColumn
            // 
            this.equipmentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipmentNameDataGridViewTextBoxColumn.DataPropertyName = "EquipmentName";
            this.equipmentNameDataGridViewTextBoxColumn.HeaderText = "Наименование по бух. уч.";
            this.equipmentNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.equipmentNameDataGridViewTextBoxColumn.Name = "equipmentNameDataGridViewTextBoxColumn";
            this.equipmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceTypeDataGridViewTextBoxColumn
            // 
            this.balanceTypeDataGridViewTextBoxColumn.DataPropertyName = "BalanceType";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.balanceTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.balanceTypeDataGridViewTextBoxColumn.HeaderText = "Учёт";
            this.balanceTypeDataGridViewTextBoxColumn.Name = "balanceTypeDataGridViewTextBoxColumn";
            this.balanceTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceTypeDataGridViewTextBoxColumn.Width = 90;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "б/н";
            this.serialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.serialDataGridViewTextBoxColumn.HeaderText = "Серийный №";
            this.serialDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialDataGridViewTextBoxColumn.Width = 80;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "Инвентарный №";
            this.inventoryNumberDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Availability";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "На складе";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // RoomEquipmentColumn
            // 
            this.RoomEquipmentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.RoomEquipmentColumn.DataPropertyName = "RoomEquipmentsQuantity";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RoomEquipmentColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.RoomEquipmentColumn.HeaderText = "В помещениях";
            this.RoomEquipmentColumn.MinimumWidth = 80;
            this.RoomEquipmentColumn.Name = "RoomEquipmentColumn";
            this.RoomEquipmentColumn.ReadOnly = true;
            this.RoomEquipmentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomEquipmentColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RoomEquipmentColumn.Width = 80;
            // 
            // EquipmentLeasingColumn
            // 
            this.EquipmentLeasingColumn.DataPropertyName = "EmployeeEquipmentsQuantity";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EquipmentLeasingColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.EquipmentLeasingColumn.HeaderText = "Во временном использовании";
            this.EquipmentLeasingColumn.Name = "EquipmentLeasingColumn";
            this.EquipmentLeasingColumn.ReadOnly = true;
            this.EquipmentLeasingColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EquipmentLeasingColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // WriteOffShowColumn
            // 
            this.WriteOffShowColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.WriteOffShowColumn.DataPropertyName = "WriteOffEquipmentsQuantity";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.WriteOffShowColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.WriteOffShowColumn.HeaderText = "Списано";
            this.WriteOffShowColumn.MinimumWidth = 50;
            this.WriteOffShowColumn.Name = "WriteOffShowColumn";
            this.WriteOffShowColumn.ReadOnly = true;
            this.WriteOffShowColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WriteOffShowColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WriteOffShowColumn.Width = 50;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Всего";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 40;
            // 
            // WriteOffColumn
            // 
            this.WriteOffColumn.HeaderText = "";
            this.WriteOffColumn.Image = global::EquipmentDB.Properties.Resources.iconfinder_hammer_tool_103858__1_;
            this.WriteOffColumn.Name = "WriteOffColumn";
            this.WriteOffColumn.ReadOnly = true;
            this.WriteOffColumn.Width = 30;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = global::EquipmentDB.Properties.Resources.edit_16;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.ToolTipText = "Редактировать помещение";
            this.EditColumn.Width = 30;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::EquipmentDB.Properties.Resources.delete_16;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.ToolTipText = "Удалить помещение";
            this.DeleteColumn.Width = 30;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(EquipmentDB.Model.Equipment);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInventoryNumber);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEquipmentName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSerialNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxBalanceType);
            this.groupBox1.Controls.Add(this.comboBoxEquipType);
            this.groupBox1.Controls.Add(this.comboBoxManufacturers);
            this.groupBox1.Location = new System.Drawing.Point(279, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск оборудования";
            // 
            // textBoxInventoryNumber
            // 
            this.textBoxInventoryNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxInventoryNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxInventoryNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxInventoryNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInventoryNumber.Location = new System.Drawing.Point(295, 82);
            this.textBoxInventoryNumber.MaxLength = 100;
            this.textBoxInventoryNumber.Name = "textBoxInventoryNumber";
            this.textBoxInventoryNumber.Size = new System.Drawing.Size(215, 20);
            this.textBoxInventoryNumber.TabIndex = 10;
            this.textBoxInventoryNumber.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Image = global::EquipmentDB.Properties.Resources.search_24;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(528, 43);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(182, 49);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.Text = "Найти";
            this.toolTip1.SetToolTip(this.buttonSearch, "Поиск оборудования по заданным параметрам");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReset.FlatAppearance.BorderSize = 2;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Image = global::EquipmentDB.Properties.Resources.refresh_16;
            this.buttonReset.Location = new System.Drawing.Point(528, 98);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(182, 35);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonReset, "Сборос параметров и данных поиска");
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Инвентарный номер";
            // 
            // textBoxEquipmentName
            // 
            this.textBoxEquipmentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxEquipmentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxEquipmentName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEquipmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEquipmentName.Location = new System.Drawing.Point(295, 122);
            this.textBoxEquipmentName.MaxLength = 100;
            this.textBoxEquipmentName.Name = "textBoxEquipmentName";
            this.textBoxEquipmentName.Size = new System.Drawing.Size(215, 20);
            this.textBoxEquipmentName.TabIndex = 10;
            this.textBoxEquipmentName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Наименование по бух.уч.";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSerialNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSerialNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerialNumber.Location = new System.Drawing.Point(295, 43);
            this.textBoxSerialNumber.MaxLength = 100;
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(215, 20);
            this.textBoxSerialNumber.TabIndex = 10;
            this.textBoxSerialNumber.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Серийный номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Тип учёта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Тип оборудования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Изготовитель";
            // 
            // comboBoxBalanceType
            // 
            this.comboBoxBalanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBalanceType.FormattingEnabled = true;
            this.comboBoxBalanceType.Location = new System.Drawing.Point(20, 121);
            this.comboBoxBalanceType.Name = "comboBoxBalanceType";
            this.comboBoxBalanceType.Size = new System.Drawing.Size(258, 21);
            this.comboBoxBalanceType.TabIndex = 6;
            // 
            // comboBoxEquipType
            // 
            this.comboBoxEquipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipType.FormattingEnabled = true;
            this.comboBoxEquipType.Location = new System.Drawing.Point(20, 82);
            this.comboBoxEquipType.Name = "comboBoxEquipType";
            this.comboBoxEquipType.Size = new System.Drawing.Size(258, 21);
            this.comboBoxEquipType.TabIndex = 6;
            // 
            // comboBoxManufacturers
            // 
            this.comboBoxManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufacturers.FormattingEnabled = true;
            this.comboBoxManufacturers.Location = new System.Drawing.Point(20, 42);
            this.comboBoxManufacturers.Name = "comboBoxManufacturers";
            this.comboBoxManufacturers.Size = new System.Drawing.Size(258, 21);
            this.comboBoxManufacturers.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::EquipmentDB.Properties.Resources.iconfinder_hammer_tool_103858;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(12, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 33);
            this.button3.TabIndex = 6;
            this.button3.TabStop = false;
            this.button3.Text = "Списание оборудования";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button3, "СПисание оборудования со склада");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::EquipmentDB.Properties.Resources.iconfinder_62_Client_User_costs_employee_finance_money_person_4308184;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(12, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 33);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "Выдача во временное использование";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button2, "Выдача оборудования со склада во временнное использование");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::EquipmentDB.Properties.Resources.iconfinder_architecture_interior_26_809094;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 33);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "Ввод оборудования в эксплуатацию";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button1, "Ввод в использование оборудования со склада");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddEquip
            // 
            this.buttonAddEquip.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddEquip.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddEquip.FlatAppearance.BorderSize = 2;
            this.buttonAddEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEquip.Image = global::EquipmentDB.Properties.Resources.add;
            this.buttonAddEquip.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddEquip.Location = new System.Drawing.Point(12, 38);
            this.buttonAddEquip.Name = "buttonAddEquip";
            this.buttonAddEquip.Size = new System.Drawing.Size(261, 33);
            this.buttonAddEquip.TabIndex = 6;
            this.buttonAddEquip.TabStop = false;
            this.buttonAddEquip.Text = "Добавить новое оборудование";
            this.buttonAddEquip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.buttonAddEquip, "Добавить новое оборудование на склад");
            this.buttonAddEquip.UseVisualStyleBackColor = false;
            this.buttonAddEquip.Click += new System.EventHandler(this.buttonAddEquip_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::EquipmentDB.Properties.Resources.iconfinder_restore_2460287;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::EquipmentDB.Properties.Resources.edit_16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.ToolTipText = "Редактировать помещение";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::EquipmentDB.Properties.Resources.delete_16;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.ToolTipText = "Удалить помещение";
            this.dataGridViewImageColumn3.Width = 30;
            // 
            // отчетыПоОборудованииСотрудниковToolStripMenuItem
            // 
            this.отчетыПоОборудованииСотрудниковToolStripMenuItem.Name = "отчетыПоОборудованииСотрудниковToolStripMenuItem";
            this.отчетыПоОборудованииСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.отчетыПоОборудованииСотрудниковToolStripMenuItem.Text = "Отчеты по оборудовании сотрудников";
            this.отчетыПоОборудованииСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.отчетыПоОборудованииСотрудниковToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 606);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddEquip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт компьютерного оборудования";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фирмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типОборудованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помещенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводВЭксплуатациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem временноеИспользованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списанноеОборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеПомещенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem корпусаToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInventoryNumber;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEquipmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBalanceType;
        private System.Windows.Forms.ComboBox comboBoxEquipType;
        private System.Windows.Forms.ComboBox comboBoxManufacturers;
        private System.Windows.Forms.Button buttonAddEquip;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem сверкаОборудованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oрганизацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem резервированиеБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ответсвенныеСотрудникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem восстановитьФайлыБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn RoomEquipmentColumn;
        private System.Windows.Forms.DataGridViewLinkColumn EquipmentLeasingColumn;
        private System.Windows.Forms.DataGridViewLinkColumn WriteOffShowColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn WriteOffColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоТипамБалансаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоКорпусамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоСотрудникамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыПоОборудованииСотрудниковToolStripMenuItem;
    }
}

