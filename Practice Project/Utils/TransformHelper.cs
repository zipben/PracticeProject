using System;
using Practice_Project.Interfaces;
using Practice_Project.Models;
using System.Threading.Tasks;

namespace Practice_Project.Utils
{
    public class TransformHelper : ITransformHelper
    {
        public TransformHelper()
        {

        }

        public async Task TransformAsync(IndexViewModel model)
        {
            await Task.Run(() => Transform(model));
        }

        public void Transform(IndexViewModel model)
        {
            model.FirstName += "_Transformed";
            model.LastName += "_Transformed";
            model.Age += 200;
        }
    }
}