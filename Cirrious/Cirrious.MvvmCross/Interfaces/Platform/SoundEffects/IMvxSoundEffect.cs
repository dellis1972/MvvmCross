#region Copyright
// <copyright file="IMvxSoundEffect.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Project Lead - Stuart Lodge, Cirrious. http://www.cirrious.com
#endregion

using System;
using Cirrious.MvvmCross.Interfaces.Localization;

namespace Cirrious.MvvmCross.Interfaces.Platform.SoundEffects
{
    public interface IMvxSoundEffect
        : IMvxResourceObject, IDisposable
    {
        IMvxSoundEffectInstance CreateInstance();
    }
}