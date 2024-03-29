﻿using Application.InspectionTasks.DTOs;
using Application.RealProperties.DTOs;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.DTOs
{
    public class InspectionProtocolOfParticularTaskDTO
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public DateTime InspectionDateTime { get; set; }
        public AllRealPropertiesDTO InspectedPropertyDTO { get; set; }
        public Resident? Resident { get; set; }
    }
}
