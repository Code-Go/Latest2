using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanGoGoService.BaseClasses
{
    public class BaseReference
    {
        public BusinessAccessLayer.IGetListValues _businessAccess;

        public BusinessAccessLayer.IUser _businessUser;

        public BusinessAccessLayer.Interfaces.ICountry _businessCountry;

        public BusinessAccessLayer.Interfaces.IMasterState _businessMasterState;

        public BusinessAccessLayer.Interfaces.IMasterCity _businessMasterCity;

        public BusinessAccessLayer.Interfaces.IMasterCategory _businessMasterCategory;

        public BusinessAccessLayer.Interfaces.IAttractions _businessAttractions;

        public BusinessAccessLayer.Interfaces.IAttractionsActiveStatus _businessAttractionsActiveStatus;

        public BusinessAccessLayer.Interfaces.IMasterWeek _businessMasterWeek;

        public BusinessAccessLayer.Interfaces.IAttractionTravelTimeDistance _businessAttractionTravelTimeDistance;

        public BusinessAccessLayer.Interfaces.IMissingDistanceAttractionsRecords _businessMissingDistanceAttractionsRecords;

        public BaseReference()
        {
            _businessAccess = new BusinessAccessLayer.GetListValues();
            _businessUser = new BusinessAccessLayer.User();
            _businessCountry = new BusinessAccessLayer.Admin.Country();
            _businessMasterState = new BusinessAccessLayer.Admin.MasterState();
            _businessMasterCity = new BusinessAccessLayer.Admin.MasterCity();
            _businessMasterCategory = new BusinessAccessLayer.Admin.MasterCategory();
            _businessAttractions = new BusinessAccessLayer.Admin.Attractions();
            _businessAttractionsActiveStatus = new BusinessAccessLayer.Admin.AttractionsActiveStatus();
            _businessMasterWeek = new BusinessAccessLayer.Admin.MasterWeek();
            _businessAttractionTravelTimeDistance = new BusinessAccessLayer.Admin.AttractionTravelTimeDistance();
            _businessMissingDistanceAttractionsRecords = new BusinessAccessLayer.Admin.BALMissingDistanceAttractionsRecords();
        }
    }
}