using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Integration.Infra.DataAgent.Interface
{
    public interface IOrderBusiness
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> GetOrder(string orderId);


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<HttpResponseMessage> ListOrders(string queries);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> GetOrderCancel(string orderId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> PostRegisterChanges(string orderId, JsonObject payload);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> PostStartHandling(string orderId, JsonObject payload);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> PostChangeOrderState(string orderId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> Interations(string orderId, JsonObject payload);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> PostNote(string orderId, JsonObject payload);
    }
}
