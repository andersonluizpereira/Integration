using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Integration.Infra.DataAgent.Interface
{
    public interface IConversationBusiness
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alias"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> GetEmailMappingAsync(String alias);
    }
}
