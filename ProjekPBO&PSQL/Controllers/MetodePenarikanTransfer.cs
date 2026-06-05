using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    
    class MetodePenarikanTransfer : MetodePenarikan
    {
        OrangController orangController = new OrangController();
        RiwayatPenarikanController penarikanController = new RiwayatPenarikanController();

        public override bool MenarikUang(decimal jumlah, Orang orang, string noRek)
        {
            if (Validator.ApakahKosong(noRek) || Validator.ApakahAngka(noRek) || Validator.ApakahPanjang(15, noRek, 16))
            {
                MessageBox.Show("Penarikan Gagal! Transfer hanya mendukung Bank BRI dengan nomor rekening valid (15 digit angka).", "Metode Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            decimal? nominalDitarik = orang.TarikSaldo(jumlah);

            if (nominalDitarik == null)
            {
                MessageBox.Show("Penarikan Gagal! Periksa kembali nominal penarikan dan sisa saldo Anda.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal saldoTerbaru = orang.getSaldo();
            bool apakahDatabaseSukses = orangController.UpdateSaldo(orang.getIDOrang(), saldoTerbaru);
            if (apakahDatabaseSukses)
            {
                bool apakahRiwayatTercatat = penarikanController.TambahRiwayat(jumlah, "Cash", orang.getIDOrang());
                if (apakahRiwayatTercatat)
                {

                    MessageBox.Show($"Berhasil menarik uang Silakan ambil uang tunai di Owner.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Saldo berhasil terpotong, tetapi sistem gagal mencatat riwayat transaksi. Hubungi admin/owner.", "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            else
            {
                orang.BatalTarikSaldo(jumlah);
                MessageBox.Show("Gagal menyinkronkan data dengan server. Transaksi dibatalkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
