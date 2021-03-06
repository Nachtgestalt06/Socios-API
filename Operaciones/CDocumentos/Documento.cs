﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uFacturaEDatos.Operaciones.CDocumentos
{
    public class Documento : Operacion
    {
        uFacturaEDatos.BasedatosDataContext _db = null;
        public Documento()
        {
            _db = new BasedatosDataContext(_connectionString);
            _db.CommandTimeout = 240;
        }

        public bool Guardar(uFacturaEDatos.C_Documentos documento)
        {
            bool resultado = false;
            try
            {
                var vDocumento = from doc in _db.C_Documentos where doc.DocumentoID == documento.DocumentoID select doc;
                if (vDocumento.Count() == 0)
                {
                    _db.C_Documentos.InsertOnSubmit(documento);
                }

                _db.SubmitChanges();

                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
                _mensajeErrorSistema = ex.Message;
                GrabarLogError(ex);
                throw new Exception("No fué posible guardar el documento");
            }

            return resultado;
        }

        public bool Eliminar(uFacturaEDatos.C_Documentos documento)
        {
            bool resultado = false;
            try
            {
                var vDocumento = from doc in _db.C_Documentos where doc.DocumentoID == documento.DocumentoID select doc;

                if (vDocumento.Count() > 0)
                {
                    documento = vDocumento.First();
                    _db.C_Documentos.DeleteOnSubmit(documento);
                    _db.SubmitChanges();

                    resultado = true;
                }
                else
                {
                    _mensajeErrorUsuario = "El idDocumento " + documento.DocumentoID.ToString() + " no existe y no es posible eliminar el registro.";
                    resultado = false;
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                _mensajeErrorSistema = ex.Message;
                GrabarLogError(ex);
            }

            return resultado;
        }

        public uFacturaEDatos.C_Documentos Obten(uFacturaEDatos.C_Documentos documento)
        {
            try
            {
                var vDocumento = from doc in _db.C_Documentos where doc.DocumentoID == documento.DocumentoID select doc;

                if (vDocumento.Count() > 0)
                {
                    return vDocumento.First();
                }
                else
                {
                    _mensajeErrorUsuario = "El idDocumento " + documento.DocumentoID.ToString() + " no existe y no es posible obtener el registro.";
                    return null;
                }
            }
            catch (Exception ex)
            {
                _mensajeErrorSistema = ex.Message;
                GrabarLogError(ex);
                return null;
            }
        }

        
        public List<uFacturaEDatos.C_Documentos> ObtenLista()
        {
            try
            {
                var vDocumento = from doc in _db.C_Documentos select doc;
                return vDocumento.ToList();
            }
            catch (Exception ex)
            {
                _mensajeErrorSistema = ex.Message;
                GrabarLogError(ex);
                return new List<uFacturaEDatos.C_Documentos>();
            }
        }

       
    }
}
