using System;
using System.Linq;

namespace Sudokew
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
        public Sudoku(int[] nums)
        {
            for (int i = 0; i < 9; i++)
            {
                m_nums[i] = nums[i];
            }
        }
        public bool place(int num, int val)
        {
            if (val > 9 || val < 1 || num > 8 || num < 0) { return false; }
            if (m_nums.Contains(val)) { return false; }
            if (m_nums[num] != 0) { return false; }
            m_nums[num] = val;
            return true;
        }

        public bool place(int val)
        {
            if (val > 9 || val < 1) { return false; }
            if (contains(val)) { return false; }
            return true;
        }
        public bool contains(int val)
        {
            int count = 0;
            for (int i = 0; i < m_nums.Length; i++)
            {
                if (m_nums[i] == val) { count++; }
            }
            return count >= 2;
        }
        //  Make sure no numbers appear twice
        public Boolean isValid()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = i+1; j < 9; j++)
                {
                    if (m_nums[i] == m_nums[j]  && m_nums[i] != 0)
                        return false;
                }
            }
            return true;
        }
    }
}
