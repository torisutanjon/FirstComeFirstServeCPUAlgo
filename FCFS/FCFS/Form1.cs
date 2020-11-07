using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFS
{
    public partial class Form1 : Form
    {
        int[] arrivalTime = new int[4];//array for arrival time
        int[] executionTime = new int[4];//array for execution time
        int[] waitingTime = new int[4];//array for waiting time
        int temp = 0;//for swapping arrivalTime array purpose
        int temp2 = 0;//for swapping executionTime array purpose

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //start of inserting arrival time into array
            arrivalTime[0] = int.Parse(p1AT.Text); //Note! parse is converting string to int
            arrivalTime[1] = int.Parse(p2AT.Text); //easiest way to get data from different textboxes
            arrivalTime[2] = int.Parse(p3AT.Text);//with different names
            arrivalTime[3] = int.Parse(p4AT.Text);//
            //end of inserting arrival time into array
            //start of inserting executiong time into array
            executionTime[0] = Int32.Parse(p1ET.Text);//
            executionTime[1] = Int32.Parse(p2ET.Text);//again the easiest way
            executionTime[2] = Int32.Parse(p3ET.Text);//feelsgoodman
            executionTime[3] = Int32.Parse(p4ET.Text);//
            //end of inserting executiong time into array

            //time to calculate haha!
            //start of sorting for processes arrival time
            //Array.Sort(arrivalTime);
            for (int i = 0; i < arrivalTime.Length; i++) { //this will change the indeces that will be compared
                for (int y = i +1; y < arrivalTime.Length; y++) {//this will change the indeces that will compared to
                    if (arrivalTime[i] > arrivalTime[y]) { // the index on the left is greater on the index on the right
                        //if true
                        temp = arrivalTime[y]; // will store the value of the index on the right to the var temp
                        arrivalTime[y] = arrivalTime[i]; // will store the value of the index of the left to the right
                        arrivalTime[i] = temp; // will store the value of temps to the index on the left

                        //same process here and will use the index[n] of the arrival time
                        temp2 = executionTime[y];//same in step 1
                        executionTime[y] = executionTime[i];//same in step 1
                        executionTime[i] = temp2;//same in step 1
                    }
                }// if not true || false then this will go back to the first loop

                //just printing the data on console for algorithm basis
                Console.WriteLine("Arrival Time: " + arrivalTime[i]);
                Console.WriteLine("Execution Time: " + executionTime[i]);
                //here is the end of printing the data
            }
            //end of sorting for process arrival time
            //start of calculating for waiting time
            waitingTime[0] = 0;
            waitingTime[1] = executionTime[0] + waitingTime[0];//to solve for the second waiting time, add the first execution time and the first waiting time
            waitingTime[2] = executionTime[1] + waitingTime[1];// same as this two
            waitingTime[3] = executionTime[2] + waitingTime[2];//the logic is: [index + 1] = [current index] + [current index] vice versa
            //check if arrival time is greater than waiting time
            // I'm the only one who will get this
          
            if (arrivalTime[1] > (waitingTime[1] = executionTime[0] + waitingTime[0]))
            {
                waitingTime[1] = (arrivalTime[1] + executionTime[1]) - waitingTime[1];
            }
            else {
                waitingTime[1] = executionTime[0] + waitingTime[0];
            }
            //next index (index 2)
            if (arrivalTime[2] > (waitingTime[2] = executionTime[1] + waitingTime[1]))
            {
                waitingTime[2] = (arrivalTime[2] + executionTime[2]) - waitingTime[2];
            }
            else
            {
                waitingTime[2] = executionTime[1] + waitingTime[1];
            }
            //next index (index 3)
            if (arrivalTime[3] > (waitingTime[3] = executionTime[2] + waitingTime[2]))
            {
                waitingTime[3] = (arrivalTime[3] + executionTime[3]) - waitingTime[3];
            }
            else
            {
                waitingTime[3] = executionTime[2] + waitingTime[2];
            }
            //end of calculating for waiting time
            //start of printing the calculated data
            p1WT.Text = waitingTime[0].ToString();//
            p2WT.Text = waitingTime[1].ToString();// this is the easist way to assign data in
            p3WT.Text = waitingTime[2].ToString();//different textboxes with different names
            p4WT.Text = waitingTime[3].ToString();// 
            //end of printing the calculated data

            awtTB.Text = ((waitingTime[0] + waitingTime[1] + waitingTime[2] + waitingTime[3]) / 4).ToString();//solving for average waiting time 
            ganttchart();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void ganttchart() {
            Random rand = new Random(0-256);
            datagrid.ColumnCount = waitingTime.Length;
            
            
            for (int i = 0; i<waitingTime.Length; i++){
                Color mycolor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                datagrid.RowHeadersVisible = false;
                datagrid.ColumnHeadersVisible = false;
                datagrid.Rows[0].Cells[i].Style.BackColor = mycolor;
                datagrid.Rows[0].Cells[i].Value = "Process" + i + ":         " + waitingTime[i];
                datagrid.Columns[i].Width = 50 * waitingTime[i];
                datagrid.Rows[0].Height = 90;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            
            awtTB.Clear();
            p1AT.Clear();
            p2AT.Clear();
            p3AT.Clear();
            p4AT.Clear();
            p1ET.Clear();
            p2ET.Clear();
            p3ET.Clear();
            p4ET.Clear();
            p1WT.Clear();
            p2WT.Clear();
            p3WT.Clear();
            p4WT.Clear();
            datagrid.Columns.Clear();
        }
    }
    }
