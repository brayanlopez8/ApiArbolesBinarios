using BrayanTechnicalTest.BLL.Interface;
using BrayanTechnicalTest.ENT.DTO;
using System;
using System.Web.Http;

namespace BrayanTechnicalTest.API.Controllers
{
    /// <summary>
    /// Api para la creacion de arboles binarios y su posterior busqueda de ancestro commun cercano de dos números
    /// </summary>
    public class ArbolBinarioController : ApiController
    {
        private INodeTreeBll _nodeTreeBll;

        public ArbolBinarioController(INodeTreeBll nodeTreeBll)
        {
            this._nodeTreeBll = nodeTreeBll;
        }
        /// <summary>
        /// Validate connection to API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/get")]
        public string Get()
        {
            return "Bienvenido al Api";
        }

        /// <summary>
        /// Creación de arboles binarios
        /// </summary>
        /// Arreglo de Enteros ejemplo [70,49,84,37,54,78,85,22,40,51,76,80]
        /// <param name="value"></param>
        /// <returns>Arbol Binario</returns>
        [HttpPost]
        [Route("api/CreateTree")]
        public DTOTree Post([FromBody]int[] value)
        {
            try
            {
                return _nodeTreeBll.Create(value);
                //return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Ancestro comun mas cercano de dos nodos ingresados
        /// </summary>
        /// <param name="tree"></param>
        /// /// <param name="a"></param>
        /// /// <param name="b"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/AncestroComun")]
        public int AncestroComun(DTOTree tree, int a, int b)
        {
            //_nodeTreeBll.ClosestCommonAncestor(a, b);
            return _nodeTreeBll.ClosestCommonAncestor(tree,a, b);
        }

    }
}
