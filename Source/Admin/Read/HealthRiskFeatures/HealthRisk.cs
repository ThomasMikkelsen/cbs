/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017-2018 The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;

namespace Read.HealthRiskFeatures
{
    public class HealthRisk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ReadableId { get; set; }
        public int? Threshold { get; set; }
        public string CaseDefinition { get; set; }
       /* public string ConfirmedCase { get; set; }*/ //TODO: Should this be removed?
        public string Note { get; set; } //TODO: Should this be removed?
        //public string SuspectedCase { get; set; }
        //public string ProbableCase { get; set; }
        public string CommunityCase { get; set; }
        public string KeyMessage { get; internal set; }
    }
}