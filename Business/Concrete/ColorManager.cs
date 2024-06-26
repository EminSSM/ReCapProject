﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult TAdd(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult TDelete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> TGetAllColors()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> TGetBy(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.GetBy(c => c.ColorId == id));
        }

        public IResult TUpdate(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }
    }
}
