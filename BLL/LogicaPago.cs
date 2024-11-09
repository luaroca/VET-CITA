using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LogicaPago
    {
        RepositoryPago objd = new RepositoryPago();

        public DataTable N_listar_pagos()
        {
            return objd.D_listar_pagos();
        }

        public DataTable N_buscar_pago(Pago obje)
        {
            return objd.D_buscar_pago(obje);
        }

        public string N_mantenimiento_pago(Pago obje)
        {
            return objd.D_mantenimiento_pago(obje);
        }
    }
}
