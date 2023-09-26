﻿#region Usings

using System;

#endregion Usings

namespace PK2.Types
{
    public class InvalidBlockException : Exception
    {
        #region Properties

        /// <summary>
        /// Ruft eine Meldung ab, die die aktuelle Ausnahme beschreibt.
        /// </summary>
        public override string Message
            => "The requested block can not be parsed, since it's damaged, corrupted or not any block.";

        /// <summary>
        /// Gets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public long Position { get; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidBlockException" /> class.
        /// </summary>
        /// <param name="position">The position.</param>
        public InvalidBlockException(long position)
        {
            Position = position;
        }

        #endregion Constructor
    }
}