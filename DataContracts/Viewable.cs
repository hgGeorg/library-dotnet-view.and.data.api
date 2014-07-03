/////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Autodesk, Inc. All rights reserved 
// Written by Philippe Leefsma 2014 - ADN/Developer Technical Services
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted, 
// provided that the above copyright notice appears in all copies and 
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting 
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS. 
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC. 
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
/////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace Autodesk.ADN.Toolkit.ViewData.DataContracts
{
    public enum ViewableOptionEnum
    { 
        kDefault,
        kStatus,
        kAll
    }

    public class RegisterResponse : ViewDataResponseBase
    {
        public string Result
        {
            get;
            set;
        }
    }

    public class ViewableResponse: ViewDataResponseBase
    {
        public string Guid
        {
            get;
            set;
        }

        public int Order
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public bool HasThumbnail
        {
            get;
            set;
        }

        public string Mime
        {
            get;
            set;
        }

        public string Progress
        {
            get;
            set;
        }

        public string Role
        {
            get;
            set;
        }

        public string Urn
        {
            get;
            set;
        }

        public string Result
        {
            get;
            set;
        }

        public List<ViewableResponse> Children
        {
            get;
            set;
        }

        public List <double> Camera
        {
            get;
            set;
        }

        public List<int> Resolution
        {
            get;
            set;
        }

        public List<ViewableMessage> Messages
        {
            get;
            set;
        }

        public ViewableResponse()
        {
            Camera = new List<double>();
            Resolution = new List<int>();  
            Children = new List<ViewableResponse>();           
            Messages = new List <ViewableMessage>();
        }
    }

    public class ViewableMessage
    {
        public string Type
        {
            get;
            set;
        }

        public int code
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }
    }
}