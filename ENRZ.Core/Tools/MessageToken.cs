﻿using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace ENRZ.Core. Tools {
    /// <summary>
    /// List of messenger handler
    /// </summary>
    public static class MessageToken {

        public static readonly string PersonalMessageToken;


        static MessageToken() {
            PersonalMessageToken=nameof(PersonalMessageToken);

        }
    }
}
