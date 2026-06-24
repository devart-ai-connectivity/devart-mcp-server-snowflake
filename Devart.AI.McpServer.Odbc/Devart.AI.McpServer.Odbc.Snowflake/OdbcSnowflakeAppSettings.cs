// --------------------------------------------------------------------------
// <copyright file="OdbcSnowflakeAppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.Odbc.Snowflake
{
  internal sealed class OdbcSnowflakeAppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "Snowflake";

    public override bool OnPremise => false;
  }
}
