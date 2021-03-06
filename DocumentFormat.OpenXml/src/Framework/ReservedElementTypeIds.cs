﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml
{
    internal static class ReservedElementTypeIds
    {
        internal const int OpenXmlElementId = 9000;
        internal const int OpenXmlMiscNodeId = 9001;
        internal const int OpenXmlUnknownElementId = 9002;
        internal const int AlternateContentId = 9003;
        internal const int AlternateContentChoiceId = 9004;
        internal const int AlternateContentFallbackId = 9005;
        internal const int MaxReservedId = 10000;
        // ID of generated classes will start from 10001;

        /// <summary>
        /// Test whether the element is a strong typed element - the class is generated by CodeGen.
        /// </summary>
        /// <param name="element">The specified element.</param>
        /// <returns>True if the class of the element is generated.</returns>
        internal static bool IsStrongTypedElement(this OpenXmlElement element)
        {
            return element.ElementTypeId > MaxReservedId;
        }
    }

}
