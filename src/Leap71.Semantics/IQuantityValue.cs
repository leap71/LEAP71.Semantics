//
// SPDX-License-Identifier: Apache-2.0
//
// © 2026 by LEAP 71
//
// LEAP 71 licenses this file to you under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with the
// License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, THE SOFTWARE IS
// PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED.
//
// See the License for the specific language governing permissions and
// limitations under the License.   
//

namespace Leap71.Semantics;

/// <summary>
/// Marks a strongly typed quantity value.
/// </summary>
/// <remarks>
/// LEAP 71 coding conventions use the <c>u</c> variable prefix for values
/// whose type carries quantity semantics beyond the underlying primitive
/// representation.
///
/// Examples include physical quantities, angles, durations, token counts,
/// voxel counts, and other strongly typed scalar quantities.
///
/// This interface is intentionally empty. It communicates semantic type
/// information to analyzers and other tooling without imposing behavior.
/// </remarks>
public interface IQuantityValue
{
}
