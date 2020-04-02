// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Extensions
{
	[MixedRealityServiceProfile(typeof(IPointerStateService))]
	[CreateAssetMenu(fileName = "PointerStateServiceProfile", menuName = "MixedRealityToolkit/PointerStateService Configuration Profile")]
	public class PointerStateServiceProfile : BaseMixedRealityProfile
	{
		// Store config data in serialized fields
	}
}