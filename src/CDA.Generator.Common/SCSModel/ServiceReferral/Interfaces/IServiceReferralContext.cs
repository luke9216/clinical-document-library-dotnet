﻿/*
 * Copyright 2013 NEHTA
 *
 * Licensed under the NEHTA Open Source (Apache) License; you may not use this
 * file except in compliance with the License. A copy of the License is in the
 * 'license.txt' file, which should be provided with this work.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System.Collections.Generic;
using JetBrains.Annotations;
using Nehta.VendorLibrary.CDA.SCSModel.Common;
using Nehta.VendorLibrary.CDA.SCSModel.ServiceReferral.Interfaces;
using Nehta.VendorLibrary.Common;

namespace Nehta.VendorLibrary.CDA.SCSModel
{
    /// <summary>
    /// This interface encapsulates all the SCS specific context for a shared health summary
    /// </summary>
    public interface IServiceReferralContext
    {
        /// <summary>
        /// A participation - Author
        /// </summary>
        [CanBeNull]
        IParticipationDocumentAuthor Author { get; set; }

        /// <summary>
        /// A participation - Subject of care
        /// </summary>
        [CanBeNull]
        IParticipationSubjectOfCare SubjectOfCare { get; set; }

        /// <summary>
        /// Patient Nominated Contact
        /// </summary>
        IList<IParticipationPersonOrOrganisation> PatientNominatedContact { get; set; }

        /// <summary>
        /// Primary Care Provider
        /// </summary>
        IParticipationPersonOrOrganisation PrimaryCareProvider { get; set; }
        
        /// <summary>
        /// Interested Party
        /// </summary>
        IList<IParticipationPersonOrOrganisation> InterestedParty { get; set; }

        /// <summary>
        /// The Referee for the CDA document
        /// </summary>
        IParticipationPersonOrOrganisation Referee { get; set; }

        /// <summary>
        /// Validates this Service Referral Context
        /// </summary>
        /// <param name="path">The path to this object as a string</param>
        /// <param name="messages">the validation messages, these may be added to within this method</param>
        void Validate(string path, List<ValidationMessage> messages);
    }
}