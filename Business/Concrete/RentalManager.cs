using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p=>p.Id==rentalId));
        }

        public IResult Insert(Rental rental)
        {
            if ((_rentalDal.Get(p=>p.CarId==rental.CarId))==null)//araba kiralanmamşısa
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.SuccessInserted);
            }
            else //araba daha önce kiralamışsa
            {
                if ((_rentalDal.Get(p => p.CarId == rental.CarId).ReturnDate) != null)//araba daha önce kiralanmış ama geri verilmiş
                {
                    _rentalDal.Add(rental);
                    return new SuccessResult(Messages.SuccessInserted);
                }
                else//kiralanmış ama geri verilmemiş
                {
                    return new ErrorResult(Messages.ErrorInserted);
                }
               
            }
            
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
