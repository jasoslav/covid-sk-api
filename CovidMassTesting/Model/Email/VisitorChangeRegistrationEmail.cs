﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidMassTesting.Model.Email
{
    /// <summary>
    /// Email template for visitor change registration
    /// </summary>
    public class VisitorChangeRegistrationEmail : IEmail
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="language"></param>
        public VisitorChangeRegistrationEmail(string language)
        {
            SetLanguage(language);
        }
        /// <summary>
        /// Template identifier
        /// </summary>
        public override string TemplateId => "VisitorChangeRegistration";
        /// <summary>
        /// Registration code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// BarCode image
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Place
        /// </summary>
        public string Place { get; set; }
        /// <summary>
        /// Place description
        /// </summary>
        public string PlaceDescription { get; set; }
    }
}
