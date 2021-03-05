using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _OOP_Matrix
{

    public partial class CMatrix : Form
    {

        public CMatrix()
        {
            InitializeComponent();
            LButtons = new List<Button>();
            LButtons.Add(buttonCreate);
            LButtons.Add(buttonFill);
            LButtons.Add(buttonCalc);
            foreach(Button button in LButtons)
            {
                button.Visible = false;
            }
            vSetButtons(0, false);
        }

        bool bMtr = true;
        List<Button> LButtons;
        float[,] fMtr1, fMtr2;

        // Позиция нулевого элемента 12;12 / Размер элемента 25;20 / Вбок 31 / Вниз 26

        void vSwap(ref int iu, ref int iv)
        {
            int iTemp = iu;
            iu = iv;
            iv = iTemp;
        }

        void vCreateMatrix(bool bIsFirst)
        {
            int iColumns = iGetColumns();
            int iRows = iGetRows();
            int iXPos = 12, iYPos = 12;
            if (!bIsFirst)
            {
                vSwap(ref iColumns, ref iRows);
            }
            for (int i = 0; i < iColumns; i++)
            {
                for (int j = 0; j < iRows; j++)
                {
                    TextBox CNewBox = new TextBox();
                    CNewBox.Size = new Size(25, 20);
                    CNewBox.Name = $"index[{bIsFirst}][{i}][{j}]";
                    CNewBox.Location = new Point(iXPos + (i * 31), iYPos + (j * 26));
                    Controls.Add(CNewBox);
                }
            }
        }

        void vCleaner(bool bIsFirst)
        {
            int iColumns = iGetColumns();
            int iRows = iGetRows();
            if (!bIsFirst)
            {
                vSwap(ref iColumns, ref iRows);
            } 
            for (int i = 0; i < iColumns; i++)
            {
                for (int j = 0; j < iRows; j++)
                {
                    Controls[$"index[{bIsFirst}][{i}][{j}]"].Visible = false;
                }
            }
        }

        void vReleaseResult(int iResSize)
        {
            int iXPos = 12, iYPos = 12;
            for (int i = 0; i < iResSize; i++)
            {
                for (int j = 0; j < iResSize; j++)
                {
                    TextBox CNewBox = new TextBox();
                    CNewBox.Size = new Size(25, 20);
                    CNewBox.Text = vMul(fMtr1, fMtr2)[i, j].ToString();
                    CNewBox.Location = new Point(iXPos + (i * 31), iYPos + (j * 26));
                    if (vMul(fMtr1, fMtr2)[i, j] != 0)
                    {
                        Controls.Add(CNewBox);
                    }
                }
            }
        }

        float[,] vMul(float[,] fMtr1, float[,] fMtr2)
        {
            float[,] fResMtr = new float[iResSize(), iResSize()];
            for (int i = 0; i < fMtr1.GetLength(0); i++)
            {
                for (int j = 0; j < fMtr2.GetLength(1); j++)
                {
                    for (int k = 0; k < fMtr2.GetLength(0); k++)
                    {
                        fResMtr[i, j] += fMtr1[i, k] * fMtr2[k, j];
                    }
                }
            }
            return fResMtr;
        }

        void vFillFMtr()
        {
            fMtr1 = new float[iGetColumns(), iGetRows()];
            for (int i = 0; i < iGetColumns(); i++)
            {
                for (int j = 0; j < iGetRows(); j++)
                {
                    fMtr1[i, j] = Convert.ToInt32(Controls[$"index[{true}][{i}][{j}]"].Text);
                }
            }
        }

        void vFillSMtr()
        {
            fMtr2 = new float[iGetRows(), iGetColumns()];
            for (int i = 0; i < iGetRows(); i++)
            {
                for (int j = 0; j < iGetColumns(); j++)
                {
                    fMtr2[i, j] = Convert.ToInt32(Controls[$"index[{false}][{i}][{j}]"].Text);
                }
            }
        }

        void vSetButtons(int iID, bool bHideFields)
        {
            LButtons[iID].Visible = true;
            if(bHideFields)
            {
                textBoxColumns1.Visible = false;
                textBoxRow1.Visible = false;
            }
            for(int i = 0; i < 3; i++)
            {
                if(iID != i)
                {
                    LButtons[i].Visible = false;
                }
            }
        }

        int iGetColumns() => Convert.ToInt32(this.textBoxRow1.Text);
        int iGetRows() => Convert.ToInt32(this.textBoxColumns1.Text);

        int iResSize() 
        {
            if (iGetColumns() == iGetRows())
            {
                return iGetColumns();
            }
            else
            {
                return iGetColumns() > iGetRows() ? iGetRows() + 1 : iGetColumns() + 1;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            vCreateMatrix(bMtr);
            vSetButtons(1, true);
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            vFillFMtr();
            vCleaner(bMtr);
            bMtr = false;
            vCreateMatrix(bMtr);
            vSetButtons(2, true);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            vFillSMtr();
            vCleaner(bMtr);
            vReleaseResult(iResSize());
        }

    }
}
