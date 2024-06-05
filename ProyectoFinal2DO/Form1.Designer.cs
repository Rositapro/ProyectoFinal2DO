namespace ProyectoFinal2DO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblLasName = new Label();
            lblCurp = new Label();
            lblAge = new Label();
            lblWork = new Label();
            txtName = new TextBox();
            txtPaternal = new TextBox();
            txtCurp = new TextBox();
            txtAge = new TextBox();
            txtHoursWorked = new TextBox();
            txtMaternal = new TextBox();
            lblPaternal = new Label();
            lblMaternal = new Label();
            lblSalary = new Label();
            txtSalary = new TextBox();
            lvDatos = new ListView();
            btnCalculateSalary = new FontAwesome.Sharp.IconButton();
            lblworkstation = new Label();
            cmbTipoTrabajador = new ComboBox();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnSaveExcel = new FontAwesome.Sharp.IconButton();
            btnSaveWord = new FontAwesome.Sharp.IconButton();
            btnSavetxt = new FontAwesome.Sharp.IconButton();
            btnSaveXml = new FontAwesome.Sharp.IconButton();
            btnSaveJson = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnSavePdf = new FontAwesome.Sharp.IconButton();
            btnFillMatrix = new Button();
            btnShowMatriz = new Button();
            lblWelcome = new Label();
            btnOpenTxt = new Button();
            txtContent = new TextBox();
            btnSaveNewTxt = new Button();
            btnClearTxt = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 11F, FontStyle.Bold | FontStyle.Italic);
            lblName.Location = new Point(0, 54);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 17);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblLasName
            // 
            lblLasName.AutoSize = true;
            lblLasName.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLasName.Location = new Point(0, 105);
            lblLasName.Name = "lblLasName";
            lblLasName.Size = new Size(81, 17);
            lblLasName.TabIndex = 2;
            lblLasName.Text = "Last name";
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCurp.Location = new Point(0, 130);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(43, 17);
            lblCurp.TabIndex = 3;
            lblCurp.Text = "Curp";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(0, 160);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 17);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // lblWork
            // 
            lblWork.AutoSize = true;
            lblWork.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWork.Location = new Point(0, 217);
            lblWork.Name = "lblWork";
            lblWork.Size = new Size(107, 17);
            lblWork.TabIndex = 5;
            lblWork.Text = "Hours worked";
            // 
            // txtName
            // 
            txtName.Location = new Point(79, 56);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(158, 23);
            txtName.TabIndex = 6;
            // 
            // txtPaternal
            // 
            txtPaternal.Location = new Point(79, 104);
            txtPaternal.Multiline = true;
            txtPaternal.Name = "txtPaternal";
            txtPaternal.Size = new Size(158, 23);
            txtPaternal.TabIndex = 7;
            // 
            // txtCurp
            // 
            txtCurp.Location = new Point(79, 132);
            txtCurp.Multiline = true;
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(158, 23);
            txtCurp.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(79, 158);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(158, 23);
            txtAge.TabIndex = 9;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(138, 219);
            txtHoursWorked.Multiline = true;
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(158, 23);
            txtHoursWorked.TabIndex = 10;
            // 
            // txtMaternal
            // 
            txtMaternal.Location = new Point(243, 104);
            txtMaternal.Multiline = true;
            txtMaternal.Name = "txtMaternal";
            txtMaternal.Size = new Size(158, 23);
            txtMaternal.TabIndex = 11;
            // 
            // lblPaternal
            // 
            lblPaternal.AutoSize = true;
            lblPaternal.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPaternal.Location = new Point(79, 80);
            lblPaternal.Name = "lblPaternal";
            lblPaternal.Size = new Size(66, 17);
            lblPaternal.TabIndex = 12;
            lblPaternal.Text = "Paternal";
            // 
            // lblMaternal
            // 
            lblMaternal.AutoSize = true;
            lblMaternal.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMaternal.Location = new Point(243, 80);
            lblMaternal.Name = "lblMaternal";
            lblMaternal.Size = new Size(69, 17);
            lblMaternal.TabIndex = 13;
            lblMaternal.Text = "Maternal";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSalary.Location = new Point(0, 250);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(52, 17);
            lblSalary.TabIndex = 14;
            lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(79, 252);
            txtSalary.Multiline = true;
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(158, 23);
            txtSalary.TabIndex = 15;
            // 
            // lvDatos
            // 
            lvDatos.Location = new Point(407, 12);
            lvDatos.Name = "lvDatos";
            lvDatos.Size = new Size(381, 263);
            lvDatos.TabIndex = 16;
            lvDatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnCalculateSalary
            // 
            btnCalculateSalary.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            btnCalculateSalary.IconColor = Color.Green;
            btnCalculateSalary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalculateSalary.Location = new Point(334, 174);
            btnCalculateSalary.Name = "btnCalculateSalary";
            btnCalculateSalary.Size = new Size(54, 39);
            btnCalculateSalary.TabIndex = 17;
            btnCalculateSalary.UseVisualStyleBackColor = true;
            btnCalculateSalary.Click += btnCalculateSalary_Click;
            // 
            // lblworkstation
            // 
            lblworkstation.AutoSize = true;
            lblworkstation.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblworkstation.Location = new Point(0, 188);
            lblworkstation.Name = "lblworkstation";
            lblworkstation.Size = new Size(93, 17);
            lblworkstation.TabIndex = 20;
            lblworkstation.Text = "Workstation";
            // 
            // cmbTipoTrabajador
            // 
            cmbTipoTrabajador.FormattingEnabled = true;
            cmbTipoTrabajador.Location = new Point(105, 191);
            cmbTipoTrabajador.Name = "cmbTipoTrabajador";
            cmbTipoTrabajador.Size = new Size(158, 23);
            cmbTipoTrabajador.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.Navy;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(334, 219);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(55, 56);
            btnSave.TabIndex = 22;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSaveExcel
            // 
            btnSaveExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnSaveExcel.IconColor = Color.Black;
            btnSaveExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveExcel.Location = new Point(576, 297);
            btnSaveExcel.Name = "btnSaveExcel";
            btnSaveExcel.Size = new Size(48, 77);
            btnSaveExcel.TabIndex = 23;
            btnSaveExcel.Text = "XLSX";
            btnSaveExcel.TextAlign = ContentAlignment.BottomCenter;
            btnSaveExcel.UseVisualStyleBackColor = true;
            btnSaveExcel.Click += btnSaveExcel_Click;
            // 
            // btnSaveWord
            // 
            btnSaveWord.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveWord.IconChar = FontAwesome.Sharp.IconChar.FileWord;
            btnSaveWord.IconColor = Color.Black;
            btnSaveWord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveWord.Location = new Point(459, 297);
            btnSaveWord.Name = "btnSaveWord";
            btnSaveWord.Size = new Size(52, 77);
            btnSaveWord.TabIndex = 24;
            btnSaveWord.Text = "DOCS";
            btnSaveWord.TextAlign = ContentAlignment.BottomCenter;
            btnSaveWord.UseVisualStyleBackColor = true;
            btnSaveWord.Click += btnSaveWord_Click;
            // 
            // btnSavetxt
            // 
            btnSavetxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavetxt.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btnSavetxt.IconColor = Color.Black;
            btnSavetxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSavetxt.Location = new Point(630, 297);
            btnSavetxt.Name = "btnSavetxt";
            btnSavetxt.Size = new Size(46, 77);
            btnSavetxt.TabIndex = 25;
            btnSavetxt.Text = "TXT";
            btnSavetxt.TextAlign = ContentAlignment.BottomCenter;
            btnSavetxt.UseVisualStyleBackColor = true;
            btnSavetxt.Click += btnSavetxt_Click;
            // 
            // btnSaveXml
            // 
            btnSaveXml.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveXml.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btnSaveXml.IconColor = Color.Black;
            btnSaveXml.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveXml.Location = new Point(517, 297);
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(53, 78);
            btnSaveXml.TabIndex = 27;
            btnSaveXml.Text = "XML";
            btnSaveXml.TextAlign = ContentAlignment.BottomCenter;
            btnSaveXml.UseVisualStyleBackColor = true;
            btnSaveXml.Click += btnSaveXml_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveJson.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btnSaveJson.IconColor = Color.Black;
            btnSaveJson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveJson.Location = new Point(682, 297);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(53, 78);
            btnSaveJson.TabIndex = 29;
            btnSaveJson.Text = "JSON";
            btnSaveJson.TextAlign = ContentAlignment.BottomCenter;
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // btnClear
            // 
            btnClear.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(336, 129);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(53, 39);
            btnClear.TabIndex = 30;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSavePdf
            // 
            btnSavePdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnSavePdf.IconColor = Color.Black;
            btnSavePdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSavePdf.Location = new Point(407, 297);
            btnSavePdf.Name = "btnSavePdf";
            btnSavePdf.Size = new Size(46, 77);
            btnSavePdf.TabIndex = 31;
            btnSavePdf.TextAlign = ContentAlignment.BottomCenter;
            btnSavePdf.UseVisualStyleBackColor = true;
            btnSavePdf.Click += btnSavePdf_Click;
            // 
            // btnFillMatrix
            // 
            btnFillMatrix.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFillMatrix.Location = new Point(0, 297);
            btnFillMatrix.Name = "btnFillMatrix";
            btnFillMatrix.Size = new Size(75, 33);
            btnFillMatrix.TabIndex = 32;
            btnFillMatrix.Text = "Fill";
            btnFillMatrix.UseVisualStyleBackColor = true;
            btnFillMatrix.Click += btnFillMatrix_Click;
            // 
            // btnShowMatriz
            // 
            btnShowMatriz.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnShowMatriz.Location = new Point(81, 297);
            btnShowMatriz.Name = "btnShowMatriz";
            btnShowMatriz.Size = new Size(78, 33);
            btnShowMatriz.TabIndex = 33;
            btnShowMatriz.Text = "Show";
            btnShowMatriz.UseVisualStyleBackColor = true;
            btnShowMatriz.Click += btnShowMatriz_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(37, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(200, 30);
            lblWelcome.TabIndex = 34;
            lblWelcome.Text = "Welcome Employee";
            // 
            // btnOpenTxt
            // 
            btnOpenTxt.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOpenTxt.Location = new Point(813, 297);
            btnOpenTxt.Name = "btnOpenTxt";
            btnOpenTxt.Size = new Size(106, 30);
            btnOpenTxt.TabIndex = 35;
            btnOpenTxt.Text = "Open TXT";
            btnOpenTxt.UseVisualStyleBackColor = true;
            btnOpenTxt.Click += btnOpenTxt_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(794, 12);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Size = new Size(431, 263);
            txtContent.TabIndex = 36;
            // 
            // btnSaveNewTxt
            // 
            btnSaveNewTxt.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSaveNewTxt.Location = new Point(813, 333);
            btnSaveNewTxt.Name = "btnSaveNewTxt";
            btnSaveNewTxt.Size = new Size(106, 30);
            btnSaveNewTxt.TabIndex = 37;
            btnSaveNewTxt.Text = "Save TXT";
            btnSaveNewTxt.UseVisualStyleBackColor = true;
            btnSaveNewTxt.Click += btnSaveNewTxt_Click;
            // 
            // btnClearTxt
            // 
            btnClearTxt.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnClearTxt.IconColor = Color.Black;
            btnClearTxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClearTxt.Location = new Point(925, 297);
            btnClearTxt.Name = "btnClearTxt";
            btnClearTxt.Size = new Size(53, 39);
            btnClearTxt.TabIndex = 38;
            btnClearTxt.UseVisualStyleBackColor = true;
            btnClearTxt.Click += btnClearTxt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1228, 450);
            Controls.Add(btnClearTxt);
            Controls.Add(btnSaveNewTxt);
            Controls.Add(txtContent);
            Controls.Add(btnOpenTxt);
            Controls.Add(lblWelcome);
            Controls.Add(btnShowMatriz);
            Controls.Add(btnFillMatrix);
            Controls.Add(btnSavePdf);
            Controls.Add(btnClear);
            Controls.Add(btnSaveJson);
            Controls.Add(btnSaveXml);
            Controls.Add(btnSavetxt);
            Controls.Add(btnSaveWord);
            Controls.Add(btnSaveExcel);
            Controls.Add(btnSave);
            Controls.Add(cmbTipoTrabajador);
            Controls.Add(lblworkstation);
            Controls.Add(btnCalculateSalary);
            Controls.Add(lvDatos);
            Controls.Add(txtSalary);
            Controls.Add(lblSalary);
            Controls.Add(lblMaternal);
            Controls.Add(lblPaternal);
            Controls.Add(txtMaternal);
            Controls.Add(txtHoursWorked);
            Controls.Add(txtAge);
            Controls.Add(txtCurp);
            Controls.Add(txtPaternal);
            Controls.Add(txtName);
            Controls.Add(lblWork);
            Controls.Add(lblAge);
            Controls.Add(lblCurp);
            Controls.Add(lblLasName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblLasName;
        private Label lblCurp;
        private Label lblAge;
        private Label label5;
        private TextBox txtName;
        private TextBox txtPaternal;
        private TextBox txtCurp;
        private TextBox txtAge;
        private TextBox txtHoursWorked;
        private TextBox txtMaternal;
        private Label lblPaternal;
        private Label lblMaternal;
        private Label label6;
        private TextBox txtSalary;
        private ListView lvDatos;
        private FontAwesome.Sharp.IconButton btnCalculateSalary;
        private Label lblworkstation;
        private ComboBox cmbTipoTrabajador;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnSaveExcel;
        private FontAwesome.Sharp.IconButton btnSaveWord;
        private FontAwesome.Sharp.IconButton btnSavetxt;
        private FontAwesome.Sharp.IconButton btnSaveXml;
        private FontAwesome.Sharp.IconButton btnSaveJson;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnSavePdf;
        private Label lblWork;
        private Label lblSalary;
        private Button btnFillMatrix;
        private Button btnShowMatriz;
        private Label lblWelcome;
        private Button btnOpenTxt;
        private TextBox txtContent;
        private Button btnSaveNewTxt;
        private FontAwesome.Sharp.IconButton btnClearTxt;
    }
}
