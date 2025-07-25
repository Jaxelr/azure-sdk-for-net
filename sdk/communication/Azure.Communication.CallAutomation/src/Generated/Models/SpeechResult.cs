// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The speech status as a result. </summary>
    public partial class SpeechResult
    {
        /// <summary> Initializes a new instance of <see cref="SpeechResult"/>. </summary>
        internal SpeechResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SpeechResult"/>. </summary>
        /// <param name="speech"> The recognized speech in string. </param>
        /// <param name="confidence"> The confidence level of the recognized speech, if available, ranges from 0.0 to 1.0. </param>
        internal SpeechResult(string speech, double? confidence)
        {
            Speech = speech;
            Confidence = confidence;
        }

        /// <summary> The recognized speech in string. </summary>
        public string Speech { get; }
        /// <summary> The confidence level of the recognized speech, if available, ranges from 0.0 to 1.0. </summary>
        public double? Confidence { get; }
    }
}
