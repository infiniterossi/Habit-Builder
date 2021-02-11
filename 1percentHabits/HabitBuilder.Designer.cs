
namespace _1percentHabits
{
    partial class HabitBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitBuilder));
            this.lbHabits = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnAddNewHabit = new System.Windows.Forms.Button();
            this.btnPlusPercent = new System.Windows.Forms.Button();
            this.btnMinusPercent = new System.Windows.Forms.Button();
            this.lblHabit = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEditHabit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.gbHabit = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.gbHabit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHabits
            // 
            this.lbHabits.FormattingEnabled = true;
            this.lbHabits.Location = new System.Drawing.Point(84, 108);
            this.lbHabits.Margin = new System.Windows.Forms.Padding(2);
            this.lbHabits.Name = "lbHabits";
            this.lbHabits.Size = new System.Drawing.Size(156, 186);
            this.lbHabits.TabIndex = 0;
            this.lbHabits.SelectedIndexChanged += new System.EventHandler(this.lbHabits_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(8, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "time",
            "quantity",
            "distance"});
            this.cmbType.Location = new System.Drawing.Point(181, 47);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(92, 21);
            this.cmbType.TabIndex = 3;
            // 
            // btnAddNewHabit
            // 
            this.btnAddNewHabit.Location = new System.Drawing.Point(277, 47);
            this.btnAddNewHabit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewHabit.Name = "btnAddNewHabit";
            this.btnAddNewHabit.Size = new System.Drawing.Size(96, 22);
            this.btnAddNewHabit.TabIndex = 4;
            this.btnAddNewHabit.Text = "Add new habit";
            this.btnAddNewHabit.UseVisualStyleBackColor = true;
            this.btnAddNewHabit.Visible = false;
            this.btnAddNewHabit.Click += new System.EventHandler(this.btnAddNewHabit_Click);
            // 
            // btnPlusPercent
            // 
            this.btnPlusPercent.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlusPercent.Location = new System.Drawing.Point(257, 108);
            this.btnPlusPercent.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlusPercent.Name = "btnPlusPercent";
            this.btnPlusPercent.Size = new System.Drawing.Size(60, 60);
            this.btnPlusPercent.TabIndex = 5;
            this.btnPlusPercent.Text = "+ 1%";
            this.btnPlusPercent.UseVisualStyleBackColor = false;
            this.btnPlusPercent.Visible = false;
            this.btnPlusPercent.Click += new System.EventHandler(this.btnPlusPercent_Click);
            // 
            // btnMinusPercent
            // 
            this.btnMinusPercent.BackColor = System.Drawing.Color.LightCoral;
            this.btnMinusPercent.Location = new System.Drawing.Point(257, 234);
            this.btnMinusPercent.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinusPercent.Name = "btnMinusPercent";
            this.btnMinusPercent.Size = new System.Drawing.Size(60, 60);
            this.btnMinusPercent.TabIndex = 6;
            this.btnMinusPercent.Text = "- 1%";
            this.btnMinusPercent.UseVisualStyleBackColor = false;
            this.btnMinusPercent.Visible = false;
            this.btnMinusPercent.Click += new System.EventHandler(this.btnMinusPercent_Click);
            // 
            // lblHabit
            // 
            this.lblHabit.AutoSize = true;
            this.lblHabit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabit.Location = new System.Drawing.Point(332, 108);
            this.lblHabit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHabit.Name = "lblHabit";
            this.lblHabit.Size = new System.Drawing.Size(142, 26);
            this.lblHabit.TabIndex = 7;
            this.lblHabit.Text = "Select Habit";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(332, 139);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(0, 29);
            this.lblInstruction.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Habit Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Starting Value";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(277, 46);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(95, 23);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnEditHabit
            // 
            this.btnEditHabit.Location = new System.Drawing.Point(10, 172);
            this.btnEditHabit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditHabit.Name = "btnEditHabit";
            this.btnEditHabit.Size = new System.Drawing.Size(60, 60);
            this.btnEditHabit.TabIndex = 12;
            this.btnEditHabit.Text = "Edit";
            this.btnEditHabit.UseVisualStyleBackColor = true;
            this.btnEditHabit.Visible = false;
            this.btnEditHabit.Click += new System.EventHandler(this.btnEditHabit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(13, 271);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // numValue
            // 
            this.numValue.Location = new System.Drawing.Point(89, 47);
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(87, 20);
            this.numValue.TabIndex = 2;
            this.numValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbHabit
            // 
            this.gbHabit.Controls.Add(this.label3);
            this.gbHabit.Controls.Add(this.btnAddNewHabit);
            this.gbHabit.Controls.Add(this.numValue);
            this.gbHabit.Controls.Add(this.cmbType);
            this.gbHabit.Controls.Add(this.label2);
            this.gbHabit.Controls.Add(this.btnSaveChanges);
            this.gbHabit.Controls.Add(this.txtName);
            this.gbHabit.Controls.Add(this.label1);
            this.gbHabit.Location = new System.Drawing.Point(12, 12);
            this.gbHabit.Name = "gbHabit";
            this.gbHabit.Size = new System.Drawing.Size(390, 79);
            this.gbHabit.TabIndex = 15;
            this.gbHabit.TabStop = false;
            this.gbHabit.Text = "Add New Habit";
            this.gbHabit.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Starting Value";
            // 
            // btnOpenAddNew
            // 
            this.btnOpenAddNew.Location = new System.Drawing.Point(10, 108);
            this.btnOpenAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenAddNew.Name = "btnOpenAddNew";
            this.btnOpenAddNew.Size = new System.Drawing.Size(60, 60);
            this.btnOpenAddNew.TabIndex = 15;
            this.btnOpenAddNew.Text = "Add new habit";
            this.btnOpenAddNew.UseVisualStyleBackColor = true;
            this.btnOpenAddNew.Click += new System.EventHandler(this.btnOpenAddNew_Click);
            // 
            // HabitBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 317);
            this.Controls.Add(this.btnOpenAddNew);
            this.Controls.Add(this.gbHabit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditHabit);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblHabit);
            this.Controls.Add(this.btnMinusPercent);
            this.Controls.Add(this.btnPlusPercent);
            this.Controls.Add(this.lbHabits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HabitBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habit Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.gbHabit.ResumeLayout(false);
            this.gbHabit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbHabits;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAddNewHabit;
        private System.Windows.Forms.Button btnPlusPercent;
        private System.Windows.Forms.Button btnMinusPercent;
        private System.Windows.Forms.Label lblHabit;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnEditHabit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.GroupBox gbHabit;
        private System.Windows.Forms.Button btnOpenAddNew;
        private System.Windows.Forms.Label label3;
    }
}

