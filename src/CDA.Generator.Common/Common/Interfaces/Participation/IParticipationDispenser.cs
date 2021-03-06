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

using System.Runtime.Serialization;
using JetBrains.Annotations;
using Nehta.VendorLibrary.CDA.Common;
using Nehta.VendorLibrary.Common;
using System.Collections.Generic;

namespace Nehta.VendorLibrary.CDA.SCSModel
{
    /// <summary>
    /// The IParticipationDispenser interface defines the properties associated with a participation
    /// when the participation / participant is a dispenser
    /// </summary>
    public interface IParticipationDispenser
    {
        /// <summary>
      /// Dispenser Role
        /// </summary>
        [CanBeNull]
        [DataMember]
        ICodableText Role { get; set; }

        /// <summary>
        /// Date Time Authored
        /// </summary>
        [CanBeNull]
        ISO8601DateTime Time { get; set; }

        /// <summary>
        /// The dispenser
        /// </summary>
        [CanBeNull]
        IDispenser Participant { get; set; }

        /// <summary>
        /// Validates this Participation Dispenser
        /// </summary>
        /// <param name="path">The path to this object as a string</param>
        /// <param name="messages">the validation messages, these may be added to within this method</param>
        void Validate(string path, List<ValidationMessage> messages);

        /// <summary>
        /// Validates this CDA Context for this Participation Dispenser
        /// </summary>
        /// <param name="path">The path to this object as a string</param>
        /// <param name="messages">the validation messages, these may be added to within this method</param>
        void ValidateATS(string path, List<ValidationMessage> messages);
    }
}
