using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    static class Validator
    {
        public static bool ApakahKosong(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Input tidak boleh kosong!","Validasi Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ApakahAngka(string input)
        {
            if (!int.TryParse(input, out _))
            {
                MessageBox.Show("Input harus berupa angka!","Validasi Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ApakahPanjang(int min, string input, int? max = null)
        {
            if (max == null)
            {
                int panjangInput = input.Length;
                if (panjangInput < min)
                {
                    MessageBox.Show($"Input harus memiliki panjang minimal {min} karakter!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else
                {
                    return true;
                }
            }
            else
            {
                int panjangInput = input.Length;
                if (panjangInput < min || panjangInput > max)
                {
                    MessageBox.Show($"Input harus memiliki panjang antara {min} dan {max} karakter!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool ApakahHurufdanAngka(string input)
        {
            if (input.All(ch => char.IsLetterOrDigit(ch)))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Input harus terdiri dari huruf dan angka saja!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ApakahAdaUsername(string username)
        {
            if (username == "wow")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool ApakahadaNama(string nama)
        {
            if (nama == "wow")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ApakahEmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("Format email salah!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
