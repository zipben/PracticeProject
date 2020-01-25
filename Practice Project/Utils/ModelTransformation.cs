using System;
using Practice_Project.Interfaces;
using Practice_Project.Models;
using System.Threading.Tasks;

namespace Practice_Project.Utils
{
    public class ModelTransformation : IModelTransformation
    {
        private readonly ITransformHelper _transformHelper;

        public ModelTransformation(ITransformHelper transformHelper)
        {
            _transformHelper = transformHelper;
        }

        public async Task TransformAsync(IndexViewModel model)
        {
            await _transformHelper.TransformAsync(model);
        }

        public void Transform(IndexViewModel model)
        {
            _transformHelper.Transform(model);
        }
    }
}