using System;

namespace JuradoDeElecciones
{
    class Ciudadano 
    {
        private string _strUsuario;
        private string _strContrasea;
        public string TipoDeDocumento;

        private string CrearCuenta()
        {
            return _strUsuario;
        }
    }

    class Registros
    {
        private string _TipoDeDocumento;
        public string strNombres;
        public string strApellidosPaternos;
        public string strApellidosMaternos;
        public DateTime dtFechaDeNacimiento;
        public string _strLugarDeNacimiento;
        public string _strSexo;
        public string _strCodigoDeVotacion;
    }

    class Municipio
    {
        private int _CodMunicipio;
        public string _strNombreMunicipio;
    }

    class Departamento
    {
        private int _CodigoDepartamento;
        public string strNombreDepartamento;
    }

    class Candidato
    {
        private int _CodigoCandidato;
        public string strCedula;
        public string strNombreCandidato;
        public int IdPartido;
    }

    class TipoCandidato
    {
        private int _CodigoTipo;
        public string strDescipcionCargos;
    }
    class Votos
    {
        private int _IdVotacion;
        private int _CodigoCandidato;
        public DateTime dtmFechaDeVoto;
        public DateTime dtmHoraDeVoto;
    }

}
