﻿namespace Client
{
    partial class DataInputPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataInputPanel));
            this.tb_exercise = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_calory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_insulin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_glucose = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_exercise = new System.Windows.Forms.Button();
            this.bt_calories = new System.Windows.Forms.Button();
            this.bt_BloodGlucose = new System.Windows.Forms.Button();
            this.bt_insulin = new System.Windows.Forms.Button();
            this.panel_glucose = new System.Windows.Forms.Panel();
            this.panel_insulin = new System.Windows.Forms.Panel();
            this.panel_calories = new System.Windows.Forms.Panel();
            this.panel_exercise = new System.Windows.Forms.Panel();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel_glucose.SuspendLayout();
            this.panel_insulin.SuspendLayout();
            this.panel_calories.SuspendLayout();
            this.panel_exercise.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_exercise
            // 
            this.tb_exercise.Location = new System.Drawing.Point(14, 15);
            this.tb_exercise.Name = "tb_exercise";
            this.tb_exercise.Size = new System.Drawing.Size(277, 83);
            this.tb_exercise.TabIndex = 16;
            this.tb_exercise.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cal";
            // 
            // tb_calory
            // 
            this.tb_calory.Location = new System.Drawing.Point(18, 16);
            this.tb_calory.Name = "tb_calory";
            this.tb_calory.Size = new System.Drawing.Size(93, 21);
            this.tb_calory.TabIndex = 14;
            this.tb_calory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_calory_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "units";
            // 
            // tb_insulin
            // 
            this.tb_insulin.Location = new System.Drawing.Point(18, 16);
            this.tb_insulin.Name = "tb_insulin";
            this.tb_insulin.Size = new System.Drawing.Size(93, 21);
            this.tb_insulin.TabIndex = 12;
            this.tb_insulin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_insulin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "mg/dL";
            // 
            // tb_glucose
            // 
            this.tb_glucose.Location = new System.Drawing.Point(18, 16);
            this.tb_glucose.Name = "tb_glucose";
            this.tb_glucose.Size = new System.Drawing.Size(93, 21);
            this.tb_glucose.TabIndex = 10;
            this.tb_glucose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_glucose_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.bt_exercise);
            this.groupBox1.Controls.Add(this.bt_calories);
            this.groupBox1.Controls.Add(this.bt_BloodGlucose);
            this.groupBox1.Controls.Add(this.bt_insulin);
            this.groupBox1.Location = new System.Drawing.Point(14, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 316);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // bt_exercise
            // 
            this.bt_exercise.Location = new System.Drawing.Point(9, 249);
            this.bt_exercise.Name = "bt_exercise";
            this.bt_exercise.Size = new System.Drawing.Size(129, 47);
            this.bt_exercise.TabIndex = 2;
            this.bt_exercise.Text = "Daily Exercise";
            this.bt_exercise.UseVisualStyleBackColor = true;
            this.bt_exercise.Click += new System.EventHandler(this.bt_exercise_Click);
            // 
            // bt_calories
            // 
            this.bt_calories.Location = new System.Drawing.Point(9, 172);
            this.bt_calories.Name = "bt_calories";
            this.bt_calories.Size = new System.Drawing.Size(129, 47);
            this.bt_calories.TabIndex = 2;
            this.bt_calories.Text = "Calories";
            this.bt_calories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_calories.UseVisualStyleBackColor = true;
            this.bt_calories.Click += new System.EventHandler(this.bt_calories_Click);
            // 
            // bt_BloodGlucose
            // 
            this.bt_BloodGlucose.AutoSize = true;
            this.bt_BloodGlucose.BackColor = System.Drawing.Color.Transparent;
            this.bt_BloodGlucose.FlatAppearance.BorderSize = 0;
            this.bt_BloodGlucose.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_BloodGlucose.ForeColor = System.Drawing.Color.Black;
            this.bt_BloodGlucose.Location = new System.Drawing.Point(9, 27);
            this.bt_BloodGlucose.Name = "bt_BloodGlucose";
            this.bt_BloodGlucose.Size = new System.Drawing.Size(129, 47);
            this.bt_BloodGlucose.TabIndex = 0;
            this.bt_BloodGlucose.Text = "Blood Glucose";
            this.bt_BloodGlucose.UseVisualStyleBackColor = false;
            this.bt_BloodGlucose.Click += new System.EventHandler(this.bt_BloodGlucose_Click);
            // 
            // bt_insulin
            // 
            this.bt_insulin.Location = new System.Drawing.Point(9, 100);
            this.bt_insulin.Name = "bt_insulin";
            this.bt_insulin.Size = new System.Drawing.Size(129, 47);
            this.bt_insulin.TabIndex = 1;
            this.bt_insulin.Text = "Insulin Amount";
            this.bt_insulin.UseVisualStyleBackColor = true;
            this.bt_insulin.Click += new System.EventHandler(this.bt_insulin_Click);
            // 
            // panel_glucose
            // 
            this.panel_glucose.Controls.Add(this.tb_glucose);
            this.panel_glucose.Controls.Add(this.label1);
            this.panel_glucose.Location = new System.Drawing.Point(206, 29);
            this.panel_glucose.Name = "panel_glucose";
            this.panel_glucose.Size = new System.Drawing.Size(200, 57);
            this.panel_glucose.TabIndex = 17;
            this.panel_glucose.Visible = false;
            // 
            // panel_insulin
            // 
            this.panel_insulin.Controls.Add(this.tb_insulin);
            this.panel_insulin.Controls.Add(this.label2);
            this.panel_insulin.Location = new System.Drawing.Point(206, 92);
            this.panel_insulin.Name = "panel_insulin";
            this.panel_insulin.Size = new System.Drawing.Size(200, 53);
            this.panel_insulin.TabIndex = 18;
            this.panel_insulin.Visible = false;
            // 
            // panel_calories
            // 
            this.panel_calories.Controls.Add(this.tb_calory);
            this.panel_calories.Controls.Add(this.label3);
            this.panel_calories.Location = new System.Drawing.Point(206, 151);
            this.panel_calories.Name = "panel_calories";
            this.panel_calories.Size = new System.Drawing.Size(200, 54);
            this.panel_calories.TabIndex = 19;
            this.panel_calories.Visible = false;
            // 
            // panel_exercise
            // 
            this.panel_exercise.Controls.Add(this.tb_exercise);
            this.panel_exercise.Location = new System.Drawing.Point(206, 211);
            this.panel_exercise.Name = "panel_exercise";
            this.panel_exercise.Size = new System.Drawing.Size(306, 116);
            this.panel_exercise.TabIndex = 20;
            this.panel_exercise.Visible = false;
            // 
            // bt_ok
            // 
            this.bt_ok.BackgroundImage = global::Client.Properties.Resources.accept1;
            this.bt_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ok.FlatAppearance.BorderSize = 0;
            this.bt_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ok.Location = new System.Drawing.Point(440, 334);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(50, 50);
            this.bt_ok.TabIndex = 95;
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackgroundImage = global::Client.Properties.Resources.close;
            this.bt_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Location = new System.Drawing.Point(509, 334);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(50, 50);
            this.bt_cancel.TabIndex = 94;
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // DataInputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.panel_exercise);
            this.Controls.Add(this.panel_calories);
            this.Controls.Add(this.panel_insulin);
            this.Controls.Add(this.panel_glucose);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "DataInputPanel";
            this.Size = new System.Drawing.Size(606, 390);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_glucose.ResumeLayout(false);
            this.panel_glucose.PerformLayout();
            this.panel_insulin.ResumeLayout(false);
            this.panel_insulin.PerformLayout();
            this.panel_calories.ResumeLayout(false);
            this.panel_calories.PerformLayout();
            this.panel_exercise.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_exercise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_calory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_insulin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_glucose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_exercise;
        private System.Windows.Forms.Button bt_calories;
        private System.Windows.Forms.Button bt_BloodGlucose;
        private System.Windows.Forms.Button bt_insulin;
        private System.Windows.Forms.Panel panel_glucose;
        private System.Windows.Forms.Panel panel_insulin;
        private System.Windows.Forms.Panel panel_calories;
        private System.Windows.Forms.Panel panel_exercise;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
    }
}
