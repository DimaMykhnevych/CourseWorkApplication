﻿namespace CourseWork.Forms
{
    partial class ChangeOrSeeCompanyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.changeCompButton = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.backToMain = new System.Windows.Forms.Button();
            this.servicesList = new System.Windows.Forms.CheckedListBox();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.ownerShipcomboBox = new System.Windows.Forms.ComboBox();
            this.ownerShipLabel = new System.Windows.Forms.Label();
            this.speccomboBox = new System.Windows.Forms.ComboBox();
            this.specializLabel = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.Label();
            this.workTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sunday = new System.Windows.Forms.CheckBox();
            this.saturday = new System.Windows.Forms.CheckBox();
            this.thursday = new System.Windows.Forms.CheckBox();
            this.friday = new System.Windows.Forms.CheckBox();
            this.wednesday = new System.Windows.Forms.CheckBox();
            this.tuesday = new System.Windows.Forms.CheckBox();
            this.monday = new System.Windows.Forms.CheckBox();
            this.workDaysLabel = new System.Windows.Forms.Label();
            this.telephtextBox = new System.Windows.Forms.TextBox();
            this.telephLabel = new System.Windows.Forms.Label();
            this.cathegorycomboBox = new System.Windows.Forms.ComboBox();
            this.cathegory = new System.Windows.Forms.Label();
            this.houseNum = new System.Windows.Forms.Label();
            this.streettextBox = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.Label();
            this.citytextBox = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.houseNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // changeCompButton
            // 
            this.changeCompButton.BackColor = System.Drawing.Color.Cornsilk;
            this.changeCompButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeCompButton.Location = new System.Drawing.Point(142, 343);
            this.changeCompButton.Name = "changeCompButton";
            this.changeCompButton.Size = new System.Drawing.Size(98, 31);
            this.changeCompButton.TabIndex = 205;
            this.changeCompButton.Text = "Изменить";
            this.changeCompButton.UseVisualStyleBackColor = false;
            this.changeCompButton.Click += new System.EventHandler(this.ChangeCompButton_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Cornsilk;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(404, 343);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(98, 31);
            this.cancel.TabIndex = 204;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // backToMain
            // 
            this.backToMain.BackColor = System.Drawing.Color.Cornsilk;
            this.backToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMain.Location = new System.Drawing.Point(273, 343);
            this.backToMain.Name = "backToMain";
            this.backToMain.Size = new System.Drawing.Size(107, 31);
            this.backToMain.TabIndex = 203;
            this.backToMain.Text = "Подтвердить";
            this.backToMain.UseVisualStyleBackColor = false;
            this.backToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // servicesList
            // 
            this.servicesList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicesList.FormattingEnabled = true;
            this.servicesList.Items.AddRange(new object[] {
            "водоснабжение",
            "газ",
            "гостиницы",
            "обувь",
            "одежда",
            "отопление",
            "парикмахерские",
            "перевозка",
            "питание",
            "почтовые",
            "прачечные",
            "ремонт",
            "ритуальные",
            "строительство",
            "электроэнергия",
            "другое"});
            this.servicesList.Location = new System.Drawing.Point(455, 134);
            this.servicesList.MaximumSize = new System.Drawing.Size(300, 500);
            this.servicesList.Name = "servicesList";
            this.servicesList.Size = new System.Drawing.Size(179, 139);
            this.servicesList.TabIndex = 202;
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesLabel.Location = new System.Drawing.Point(344, 144);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(56, 18);
            this.servicesLabel.TabIndex = 201;
            this.servicesLabel.Text = "Услуги";
            // 
            // ownerShipcomboBox
            // 
            this.ownerShipcomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ownerShipcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerShipcomboBox.DropDownWidth = 156;
            this.ownerShipcomboBox.FormattingEnabled = true;
            this.ownerShipcomboBox.Items.AddRange(new object[] {
            "Любая",
            "Государственная",
            "Муниципальная",
            "Частная"});
            this.ownerShipcomboBox.Location = new System.Drawing.Point(457, 94);
            this.ownerShipcomboBox.Name = "ownerShipcomboBox";
            this.ownerShipcomboBox.Size = new System.Drawing.Size(161, 21);
            this.ownerShipcomboBox.TabIndex = 200;
            // 
            // ownerShipLabel
            // 
            this.ownerShipLabel.AutoSize = true;
            this.ownerShipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerShipLabel.Location = new System.Drawing.Point(340, 100);
            this.ownerShipLabel.Name = "ownerShipLabel";
            this.ownerShipLabel.Size = new System.Drawing.Size(116, 18);
            this.ownerShipLabel.TabIndex = 199;
            this.ownerShipLabel.Text = "Собственность";
            // 
            // speccomboBox
            // 
            this.speccomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speccomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speccomboBox.DropDownWidth = 156;
            this.speccomboBox.FormattingEnabled = true;
            this.speccomboBox.Items.AddRange(new object[] {
            "Любая",
            "Коммерческое",
            "Коммунальное",
            "Промышленное",
            "Производственное",
            "Другое"});
            this.speccomboBox.Location = new System.Drawing.Point(457, 66);
            this.speccomboBox.Name = "speccomboBox";
            this.speccomboBox.Size = new System.Drawing.Size(161, 21);
            this.speccomboBox.TabIndex = 198;
            // 
            // specializLabel
            // 
            this.specializLabel.AutoSize = true;
            this.specializLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specializLabel.Location = new System.Drawing.Point(340, 72);
            this.specializLabel.Name = "specializLabel";
            this.specializLabel.Size = new System.Drawing.Size(116, 18);
            this.specializLabel.TabIndex = 197;
            this.specializLabel.Text = "Специализация";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTimePicker.CustomFormat = "HH:mm";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(384, 305);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(59, 20);
            this.endTimePicker.TabIndex = 196;
            this.endTimePicker.Value = new System.DateTime(1800, 1, 1, 23, 59, 0, 0);
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endDTPicker_ValueChanged);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(344, 307);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(38, 13);
            this.end.TabIndex = 195;
            this.end.Text = "Конец";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTimePicker.CustomFormat = "HH:mm";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(246, 305);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(59, 20);
            this.startTimePicker.TabIndex = 194;
            this.startTimePicker.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.startTimePicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(196, 307);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(44, 13);
            this.start.TabIndex = 193;
            this.start.Text = "Начало";
            // 
            // workTime
            // 
            this.workTime.AutoSize = true;
            this.workTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workTime.Location = new System.Drawing.Point(17, 305);
            this.workTime.Name = "workTime";
            this.workTime.Size = new System.Drawing.Size(109, 18);
            this.workTime.TabIndex = 192;
            this.workTime.Text = "Время работы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sunday);
            this.groupBox1.Controls.Add(this.saturday);
            this.groupBox1.Controls.Add(this.thursday);
            this.groupBox1.Controls.Add(this.friday);
            this.groupBox1.Controls.Add(this.wednesday);
            this.groupBox1.Controls.Add(this.tuesday);
            this.groupBox1.Controls.Add(this.monday);
            this.groupBox1.Location = new System.Drawing.Point(122, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 41);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            // 
            // sunday
            // 
            this.sunday.AutoSize = true;
            this.sunday.Location = new System.Drawing.Point(282, 15);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(39, 17);
            this.sunday.TabIndex = 7;
            this.sunday.Text = "Вс";
            this.sunday.UseVisualStyleBackColor = true;
            // 
            // saturday
            // 
            this.saturday.AutoSize = true;
            this.saturday.Location = new System.Drawing.Point(236, 15);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(39, 17);
            this.saturday.TabIndex = 6;
            this.saturday.Text = "Сб";
            this.saturday.UseVisualStyleBackColor = true;
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.Location = new System.Drawing.Point(144, 15);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(39, 17);
            this.thursday.TabIndex = 5;
            this.thursday.Text = "Чт";
            this.thursday.UseVisualStyleBackColor = true;
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.Location = new System.Drawing.Point(190, 15);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(39, 17);
            this.friday.TabIndex = 4;
            this.friday.Text = "Пт";
            this.friday.UseVisualStyleBackColor = true;
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.Location = new System.Drawing.Point(98, 15);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(39, 17);
            this.wednesday.TabIndex = 2;
            this.wednesday.Text = "Ср";
            this.wednesday.UseVisualStyleBackColor = true;
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.Location = new System.Drawing.Point(52, 15);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(38, 17);
            this.tuesday.TabIndex = 1;
            this.tuesday.Text = "Вт";
            this.tuesday.UseVisualStyleBackColor = true;
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Location = new System.Drawing.Point(6, 15);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(40, 17);
            this.monday.TabIndex = 0;
            this.monday.Text = "Пн";
            this.monday.UseVisualStyleBackColor = true;
            // 
            // workDaysLabel
            // 
            this.workDaysLabel.AutoSize = true;
            this.workDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workDaysLabel.Location = new System.Drawing.Point(17, 263);
            this.workDaysLabel.Name = "workDaysLabel";
            this.workDaysLabel.Size = new System.Drawing.Size(97, 18);
            this.workDaysLabel.TabIndex = 190;
            this.workDaysLabel.Text = "Рабочие дни";
            // 
            // telephtextBox
            // 
            this.telephtextBox.Location = new System.Drawing.Point(199, 176);
            this.telephtextBox.MaxLength = 9;
            this.telephtextBox.Name = "telephtextBox";
            this.telephtextBox.Size = new System.Drawing.Size(100, 20);
            this.telephtextBox.TabIndex = 189;
            // 
            // telephLabel
            // 
            this.telephLabel.AutoSize = true;
            this.telephLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephLabel.Location = new System.Drawing.Point(18, 175);
            this.telephLabel.Name = "telephLabel";
            this.telephLabel.Size = new System.Drawing.Size(129, 18);
            this.telephLabel.TabIndex = 188;
            this.telephLabel.Text = "Номер телефона";
            // 
            // cathegorycomboBox
            // 
            this.cathegorycomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cathegorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cathegorycomboBox.DropDownWidth = 156;
            this.cathegorycomboBox.FormattingEnabled = true;
            this.cathegorycomboBox.Items.AddRange(new object[] {
            "Любой",
            "Первый",
            "Второй",
            "Высший"});
            this.cathegorycomboBox.Location = new System.Drawing.Point(199, 212);
            this.cathegorycomboBox.Name = "cathegorycomboBox";
            this.cathegorycomboBox.Size = new System.Drawing.Size(121, 21);
            this.cathegorycomboBox.TabIndex = 187;
            // 
            // cathegory
            // 
            this.cathegory.AutoSize = true;
            this.cathegory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cathegory.Location = new System.Drawing.Point(17, 212);
            this.cathegory.Name = "cathegory";
            this.cathegory.Size = new System.Drawing.Size(59, 18);
            this.cathegory.TabIndex = 186;
            this.cathegory.Text = "Разряд";
            // 
            // houseNum
            // 
            this.houseNum.AutoSize = true;
            this.houseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.houseNum.Location = new System.Drawing.Point(18, 144);
            this.houseNum.Name = "houseNum";
            this.houseNum.Size = new System.Drawing.Size(96, 18);
            this.houseNum.TabIndex = 184;
            this.houseNum.Text = "Номер дома";
            // 
            // streettextBox
            // 
            this.streettextBox.Location = new System.Drawing.Point(199, 124);
            this.streettextBox.MaxLength = 50;
            this.streettextBox.Name = "streettextBox";
            this.streettextBox.Size = new System.Drawing.Size(100, 20);
            this.streettextBox.TabIndex = 183;
            // 
            // Street
            // 
            this.Street.AutoSize = true;
            this.Street.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Street.Location = new System.Drawing.Point(18, 123);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(51, 18);
            this.Street.TabIndex = 182;
            this.Street.Text = "Улица";
            // 
            // citytextBox
            // 
            this.citytextBox.Location = new System.Drawing.Point(199, 98);
            this.citytextBox.MaxLength = 30;
            this.citytextBox.Name = "citytextBox";
            this.citytextBox.Size = new System.Drawing.Size(100, 20);
            this.citytextBox.TabIndex = 181;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city.Location = new System.Drawing.Point(18, 97);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(52, 18);
            this.city.TabIndex = 180;
            this.city.Text = "Город";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(199, 70);
            this.nametextBox.MaxLength = 50;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 20);
            this.nametextBox.TabIndex = 179;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(108, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(457, 24);
            this.header.TabIndex = 178;
            this.header.Text = "Просмотр/изменение данных о предприятии";
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyName.Location = new System.Drawing.Point(18, 69);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(167, 18);
            this.companyName.TabIndex = 177;
            this.companyName.Text = "Название предприятия";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(21, 53);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 13);
            this.idLabel.TabIndex = 206;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(168, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 207;
            this.label1.Text = "+380";
            // 
            // houseNumber
            // 
            this.houseNumber.Location = new System.Drawing.Point(230, 146);
            this.houseNumber.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.houseNumber.Name = "houseNumber";
            this.houseNumber.Size = new System.Drawing.Size(40, 20);
            this.houseNumber.TabIndex = 208;
            // 
            // ChangeOrSeeCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(651, 395);
            this.Controls.Add(this.houseNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.changeCompButton);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.backToMain);
            this.Controls.Add(this.servicesList);
            this.Controls.Add(this.servicesLabel);
            this.Controls.Add(this.ownerShipcomboBox);
            this.Controls.Add(this.ownerShipLabel);
            this.Controls.Add(this.speccomboBox);
            this.Controls.Add(this.specializLabel);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.end);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.start);
            this.Controls.Add(this.workTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.workDaysLabel);
            this.Controls.Add(this.telephtextBox);
            this.Controls.Add(this.telephLabel);
            this.Controls.Add(this.cathegorycomboBox);
            this.Controls.Add(this.cathegory);
            this.Controls.Add(this.houseNum);
            this.Controls.Add(this.streettextBox);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.citytextBox);
            this.Controls.Add(this.city);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.header);
            this.Controls.Add(this.companyName);
            this.Name = "ChangeOrSeeCompanyForm";
            this.Text = "Изменение/просмотр данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeCompButton;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button backToMain;
        private System.Windows.Forms.CheckedListBox servicesList;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.ComboBox ownerShipcomboBox;
        private System.Windows.Forms.Label ownerShipLabel;
        private System.Windows.Forms.ComboBox speccomboBox;
        private System.Windows.Forms.Label specializLabel;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label workTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sunday;
        private System.Windows.Forms.CheckBox saturday;
        private System.Windows.Forms.CheckBox thursday;
        private System.Windows.Forms.CheckBox friday;
        private System.Windows.Forms.CheckBox wednesday;
        private System.Windows.Forms.CheckBox tuesday;
        private System.Windows.Forms.CheckBox monday;
        private System.Windows.Forms.Label workDaysLabel;
        private System.Windows.Forms.TextBox telephtextBox;
        private System.Windows.Forms.Label telephLabel;
        private System.Windows.Forms.ComboBox cathegorycomboBox;
        private System.Windows.Forms.Label cathegory;
        private System.Windows.Forms.Label houseNum;
        private System.Windows.Forms.TextBox streettextBox;
        private System.Windows.Forms.Label Street;
        private System.Windows.Forms.TextBox citytextBox;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown houseNumber;
    }
}