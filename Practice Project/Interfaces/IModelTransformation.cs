using System;
using Practice_Project.Models;
using System.Threading.Tasks;

namespace Practice_Project.Interfaces
{
    public interface IModelTransformation
    {
        Task TransformAsync(IndexViewModel model);
        void Transform(IndexViewModel model);
    }
}