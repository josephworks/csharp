﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Sudoku
    {
        int[] m_nums = new int[9];
        public Sudoku(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9)
        {
            m_nums[0] = n1;
            m_nums[1] = n2;
            m_nums[2] = n3;
            m_nums[3] = n4;
            m_nums[4] = n5;
            m_nums[5] = n6;
            m_nums[6] = n7;
            m_nums[7] = n8;
            m_nums[8] = n9;
        }
        public Boolean Place(int num, int val)
        {
            if (m_nums.Contains(val) || m_nums[num] != 0)
            {
                return false;
            }
            m_nums[num] = val;
            return true;
        }
        public void isValid()
        {
            for (int i = 0; i < 9; i++)
            {

            }
        }
    }
}
