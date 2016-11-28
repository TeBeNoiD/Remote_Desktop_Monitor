using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

/// <summary>
/// Cette classe contient les méthodes fournies par le webservice RDMService. Elle permet de gèrer des comptes utilisateurs
/// </summary>
namespace RDMService
{
    public class Service : IServiceRDM
    {
        // PLAGE DES CODES ERREUR POUR LE WebService ---> [1 - 200[
        public const int CodeRet_Ok = 0;
        public const int CodeRet_PseudoUtilise = 1;
        public const int CodeRet_PseudoObligatoire = 2;
        public const int CodeRet_PseudoDownloadObligatoire = 3;
        public const int CodeRet_Logout = 4;
        public const int CodeRet_PasswordObligatoire = 5;
        public const int CodeRet_PasswordIncorrect = 6;
        public const int CodeRet_PseudoDownloadLogout = 7;
        public const int CodeRet_ParamKeyInconnu = 10;
        public const int CodeRet_ParamTypeInvalid = 11;
        public const int CodeRet_ErreurInterneService = 100;

        public WSR_Result DownloadData(WSR_Params p)
        {
            string pseudo;
            string pwd;
            string pseudoDownload;
            object data;
            WSR_Result result = VerifParamType(p, "pseudo", out pseudo);
            if(result == null)
            {
                result = VerifParamType(p, "pwd", out pwd);
                if (result == null)
                {
                    result = VerifParamType(p, "pseudoDowload", out pseudoDownload);
                    if (result == null)
                    {
                        result = VerifParamType(p, "data", out data);
                        Account.ReadData(pseudo, pwd, pseudoDownload, out data);
                        return new WSR_Result(data, true);
                    }
                    else return result;
                }
                else return result;
            }
            else return result;
        }

        public WSR_Result GetPseudos(WSR_Params p)
        {
            return null;
        }

        public WSR_Result Login(WSR_Params p)
        {
            return null;
        }

        public WSR_Result Logout(WSR_Params p)
        {
            return null;
        }

        public WSR_Result UploadData(WSR_Params p)
        {
            string pseudo;
            string pwd;
            string data;
            WSR_Result result = VerifParamType(p, "pseudo", out pseudo);
            if (result == null)
            {
                result = VerifParamType(p, "password", out pwd);
                if (result == null)
                {
                    result = VerifParamType(p, "data", out data);
                    if (result == null)
                    {
                        Account.WriteData(pseudo, pwd, data);
                    }
                    else return result;
                }
                else return result;
            }
            else return result;
            return null;
        }

        #region Fonctions perso

        /// <summary>
        /// Vérification de l'existance du parametre définit par sa clé dans l'objet de la classe WSR_Params
        /// </summary>
        /// <param name="p">Objet de type WSR_Params</param>
        /// <param name="key">Chaine de caractère définissant la clé du paramètre.</param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected static WSR_Result VerifParamExist(WSR_Params p, string key, out object data)
        {
            data = null;

            if (!p.ContainsKey(key))
                return new WSR_Result(CodeRet_ParamKeyInconnu, String.Format(Properties.Resources.PARAMKEYINCONNU, key));

            data = p.GetValueSerialized(key);

            return null;
        }

        protected static WSR_Result VerifParamType<T>(WSR_Params p, string key, out T value) where T : class
        {
            object data = null;
            value = null;

            WSR_Result ret = VerifParamExist(p, key, out data);
            if (ret != null)
                return ret;

            if (p[key] != null)
            {
                try
                {
                    value = p[key] as T; // Permet de vérifier le type
                }
                catch (Exception) { } // Il peut y avoir exception si le type est inconnu (type personnalisé qui n'est pas dans les références)

                if (value == null)
                    return new WSR_Result(CodeRet_ParamTypeInvalid, String.Format(Properties.Resources.PARAMTYPEINVALID, key));
            }

            return null;
        }

        #endregion Fonctions perso
    }
}
