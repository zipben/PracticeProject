using System;
using Practice_Project.Models;
using System.Threading.Tasks;

namespace Practice_Project.Interfaces
{
    public interface ITransformHelper
    {
        Task TransformAsync(IndexViewModel model);
        void Transform(IndexViewModel model);
    }
}