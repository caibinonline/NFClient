﻿//-----------------------------------------------------------------------
// <copyright file="NFIEvent.cs">
//     Copyright (C) 2015-2015 lvsheng.huang <https://github.com/ketoo/NFrame>
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFrame
{
	public abstract class NFIEvent
	{
		public delegate void EventHandler(NFGUID self, int nEventID, NFDataList initValueList, NFDataList valueList);

		public abstract void RegisterCallback(NFIEvent.EventHandler handler);
		public abstract void DoEvent(NFDataList valueList);
	}
}
