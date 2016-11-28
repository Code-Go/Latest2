﻿using BusinessEntites.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanGoGoAdmin.Repository.Interface
{
    public interface IMasterCity
    {
        List<MasterCityDTO> Admin_MasterCityCheckExists(MasterCityDTO masterCityDTO);

        List<MasterCityDTO> Admin_MasterCityGet();

        List<MasterCityDTO> Admin_MasterCityGetOnStateId(int stateId);

        MasterCityDTO Admin_MasterCityGetOnCityId(int cityId);

        void Admin_MasterCityUpdate(MasterCityDTO masterCityDTO);
    }
}