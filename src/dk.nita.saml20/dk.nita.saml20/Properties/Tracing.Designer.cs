﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dk.nita.saml20.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Tracing {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Tracing() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("dk.nita.saml20.Properties.Tracing", typeof(Tracing).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received an artifact resolve.
        /// </summary>
        internal static string ArtifactResolveIn {
            get {
                return ResourceManager.GetString("ArtifactResolveIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received an artifact response.
        /// </summary>
        internal static string ArtifactResponseIn {
            get {
                return ResourceManager.GetString("ArtifactResponseIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received assertion from attribute query.
        ///
        ///Assertion: {0}.
        /// </summary>
        internal static string AttrQueryAssertion {
            get {
                return ResourceManager.GetString("AttrQueryAssertion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attribute query can not be performed when user is not logged in with an IdP..
        /// </summary>
        internal static string AttrQueryNoLogin {
            get {
                return ResourceManager.GetString("AttrQueryNoLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recieved bad status from attribute query:
        ///
        ///Status: {0}.
        /// </summary>
        internal static string AttrQueryStatusError {
            get {
                return ResourceManager.GetString("AttrQueryStatusError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to called.
        /// </summary>
        internal static string Called {
            get {
                return ResourceManager.GetString("Called", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received a common domain cookie
        ///
        ///Value: {0}.
        /// </summary>
        internal static string CDC {
            get {
                return ResourceManager.GetString("CDC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate with DN &quot;{0}&quot; and thumbprint &quot;{1}&quot; is not valid according to RFC3280. 
        ///
        ///Exception was: {2}.
        /// </summary>
        internal static string CertificateIsNotRFC3280Valid {
            get {
                return ResourceManager.GetString("CertificateIsNotRFC3280Valid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created new artifact
        ///
        ///Artifact: {0}
        ///Saml message: {1}.
        /// </summary>
        internal static string CreatedArtifact {
            get {
                return ResourceManager.GetString("CreatedArtifact", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Demanding level of assurance: &quot;{0}&quot;.
        /// </summary>
        internal static string DemandingLevelOfAssurance {
            get {
                return ResourceManager.GetString("DemandingLevelOfAssurance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Demanding profile: &quot;{0}&quot;.
        /// </summary>
        internal static string DemandingProfile {
            get {
                return ResourceManager.GetString("DemandingProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to done.
        /// </summary>
        internal static string Done {
            get {
                return ResourceManager.GetString("Done", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User was logged in:
        ///
        ///User: {0}
        ///SessionIndex: {1}
        ///NameIdFormat: {2}.
        /// </summary>
        internal static string Login {
            get {
                return ResourceManager.GetString("Login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received a LogoutRequest
        ///
        ///Message: {0}.
        /// </summary>
        internal static string LogoutRequest {
            get {
                return ResourceManager.GetString("LogoutRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request credential type: &quot;{0}&quot;.
        /// </summary>
        internal static string RequestCredentialType {
            get {
                return ResourceManager.GetString("RequestCredentialType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolving an artifact
        ///
        ///Artifact: {0}
        ///IdP: {1}
        ///EndPointIndex: {2}
        ///EndPointUrl: {3}
        ///Sending message: {4}.
        /// </summary>
        internal static string ResolveArtifact {
            get {
                return ResourceManager.GetString("ResolveArtifact", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Responding to an ArtifactResolveMessage
        ///
        ///Artifact:{0}
        ///Sending message: {1}.
        /// </summary>
        internal static string RespondToArtifactResolve {
            get {
                return ResourceManager.GetString("RespondToArtifactResolve", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending an attribute query
        ///
        ///To: {0}
        ///Message: {1}.
        /// </summary>
        internal static string SendAttrQuery {
            get {
                return ResourceManager.GetString("SendAttrQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending an Authnrequest
        ///
        ///Binding: {0}
        ///IdP id: {1}.
        /// </summary>
        internal static string SendAuthnRequest {
            get {
                return ResourceManager.GetString("SendAuthnRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending a LogoutRequest
        ///
        ///Binding: {0}
        ///IdP id: {1}
        ///Message: {2}.
        /// </summary>
        internal static string SendLogoutRequest {
            get {
                return ResourceManager.GetString("SendLogoutRequest", resourceCulture);
            }
        }
    }
}
