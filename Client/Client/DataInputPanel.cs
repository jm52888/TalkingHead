﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class DataInputPanel : UserControl
    {
        private System.Drawing.Point startPoint = new System.Drawing.Point(206, 29);
        private int testType=0;

        public DataInputPanel()
        {
            InitializeComponent();
        }

        private void bt_BloodGlucose_Click(object sender, EventArgs e)
        {
            Clear();
            panel_glucose.Location = startPoint;
            panel_glucose.Visible = true;
            testType = msgCenter.Objects.TestResultObject.TESTTYPE_Glucose;
        }

        private void bt_insulin_Click(object sender, EventArgs e)
        {
            Clear();
            panel_insulin.Location = startPoint;
            panel_insulin.Visible = true;
            testType = msgCenter.Objects.TestResultObject.TESTTYPE_Insulin;
        }

        private void bt_calories_Click(object sender, EventArgs e)
        {
            Clear();
            panel_calories.Location = startPoint;
            panel_calories.Visible = true;
            testType = msgCenter.Objects.TestResultObject.TESTTYPE_Calories;
        }

        private void bt_exercise_Click(object sender, EventArgs e)
        {
            Clear();
            panel_exercise.Location = startPoint;
            panel_exercise.Visible = true;
            testType = msgCenter.Objects.TestResultObject.TESTTYPE_Exercise;
        }

        private void Clear()
        {
            panel_calories.Visible = false;
            panel_glucose.Visible = false;
            panel_insulin.Visible = false;
            panel_exercise.Visible = false;
        }


        private void bt_ok_Click(object sender, EventArgs e)
        {
            msgCenter.Objects.TestResultObject test=new msgCenter.Objects.TestResultObject();
            msgCenter.Objects.TestResultObject.TestResult newTest = new msgCenter.Objects.TestResultObject.TestResult();
            newTest.testType = testType.ToString();
            newTest.testTime = DateTime.Now;
            newTest.stateFlag = msgCenter.Objects.TestResultObject.STATE_FLAG_GOOD;
            if (testType.Equals(msgCenter.Objects.TestResultObject.TESTTYPE_Glucose)) {
                newTest.maxValue = float.Parse(tb_glucose.Text);
            }
            else if  (testType.Equals(msgCenter.Objects.TestResultObject.TESTTYPE_Insulin))  {
                newTest.maxValue = float.Parse(tb_insulin.Text);
            }
            else if (testType.Equals(msgCenter.Objects.TestResultObject.TESTTYPE_Calories)) {
                newTest.maxValue = float.Parse(tb_calory.Text);
            }
            else if (testType.Equals(msgCenter.Objects.TestResultObject.TESTTYPE_Exercise)) {
                //newTest.maxValue = float.Parse(tb);
            }
            test.Result = newTest;
            test.SaveResult();
            MessageBox.Show("Value Saved.");
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void tb_glucose_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_insulin_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_calory_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

       
    }
}
