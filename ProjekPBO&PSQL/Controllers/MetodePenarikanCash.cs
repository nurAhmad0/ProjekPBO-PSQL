using System;
using System.Collections.Generic;
using System.Text;
using ProjekPBO_PSQL.Models;

namespace ProjekPBO_PSQL.Controllers
{
    class MetodePenarikanCash : MetodePenarikan
    {
        OrangController Controller = new OrangController();
        public override bool MenarikUang(decimal jumlah, Orang orang)
        {

            decimal? nominalDitarik = orang.TarikSaldo(jumlah);

            if (nominalDitarik == null)
            {
                MessageBox.Show("Penarikan Gagal! Periksa kembali nominal penarikan dan sisa saldo Anda.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal saldoTerbaru = orang.getSaldo();
            bool apakahDatabaseSukses = Controller.UpdateSaldo(orang.getIDOrang(), saldoTerbaru);
            if (apakahDatabaseSukses)
            {
                MessageBox.Show($"Berhasil menarik uang Silakan ambil uang tunai di Owner.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                orang.BatalTarikSaldo(jumlah);
                return false;
            }
        }
    }
}
