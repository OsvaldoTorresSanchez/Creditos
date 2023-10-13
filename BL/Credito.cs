using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Credito
    {
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.CreditosEntities context = new DL_EF.CreditosEntities())
                {
                    var resultQuery = context.CreditoGetAll().ToList();

                    if (resultQuery != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in resultQuery)
                        {
                            ML.Credito credito = new ML.Credito();

                            credito.NumeroCredito = obj.NumeroCredito;
                            credito.ImporteCredito = (decimal)obj.ImporteCredito;
                            credito.PLazo = (int)obj.Plazo;
                            credito.TasaAnual = (decimal)obj.TasaAnual;


                            result.Objects.Add(credito);
                            result.Correct = true;
                        }
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result DeleteEF(ML.Credito credito)
        {
            ML.Result result = new ML.Result();

           
            try
            {
                using (DL_EF.CreditosEntities context = new DL_EF.CreditosEntities())
                {
                    var updateResult = context.CreditoDelete(credito.NumeroCredito);
                    if (updateResult >= 1)
                    {
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

    }
}
