namespace Vending_Machine
{
    partial class GUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblSugar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSugar = new System.Windows.Forms.ComboBox();
            this.cmbCofee = new System.Windows.Forms.ComboBox();
            this.cmbCacao = new System.Windows.Forms.ComboBox();
            this.cmbMilk = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEnterName.Location = new System.Drawing.Point(283, 34);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(206, 25);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter new drink name:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(509, 36);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(217, 22);
            this.txtBoxName.TabIndex = 2;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSugar.Location = new System.Drawing.Point(722, 97);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(53, 20);
            this.lblSugar.TabIndex = 3;
            this.lblSugar.Text = "Sugar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(607, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cofee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(492, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cacao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(377, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Milk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(262, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // cmbSugar
            // 
            this.cmbSugar.FormattingEnabled = true;
            this.cmbSugar.Location = new System.Drawing.Point(726, 132);
            this.cmbSugar.Name = "cmbSugar";
            this.cmbSugar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSugar.Size = new System.Drawing.Size(49, 24);
            this.cmbSugar.TabIndex = 8;
            // 
            // cmbCofee
            // 
            this.cmbCofee.FormattingEnabled = true;
            this.cmbCofee.Location = new System.Drawing.Point(611, 132);
            this.cmbCofee.Name = "cmbCofee";
            this.cmbCofee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCofee.Size = new System.Drawing.Size(49, 24);
            this.cmbCofee.TabIndex = 9;
            // 
            // cmbCacao
            // 
            this.cmbCacao.FormattingEnabled = true;
            this.cmbCacao.Location = new System.Drawing.Point(496, 132);
            this.cmbCacao.Name = "cmbCacao";
            this.cmbCacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCacao.Size = new System.Drawing.Size(49, 24);
            this.cmbCacao.TabIndex = 10;
            // 
            // cmbMilk
            // 
            this.cmbMilk.FormattingEnabled = true;
            this.cmbMilk.Location = new System.Drawing.Point(381, 132);
            this.cmbMilk.Name = "cmbMilk";
            this.cmbMilk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMilk.Size = new System.Drawing.Size(49, 24);
            this.cmbMilk.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(381, 185);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 40);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(548, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 40);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(224, 133);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(36, 23);
            this.btnUp.TabIndex = 16;
            this.btnUp.Text = "+";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(266, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(49, 22);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.Text = "1";
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(182, 133);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(36, 23);
            this.btnDown.TabIndex = 18;
            this.btnDown.Text = "-";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(950, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(705, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 40);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 683);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbMilk);
            this.Controls.Add(this.cmbCacao);
            this.Controls.Add(this.cmbCofee);
            this.Controls.Add(this.cmbSugar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSugar);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI";
            this.Text = "Vending Machine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSugar;
        private System.Windows.Forms.ComboBox cmbCofee;
        private System.Windows.Forms.ComboBox cmbCacao;
        private System.Windows.Forms.ComboBox cmbMilk;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
    }
}

