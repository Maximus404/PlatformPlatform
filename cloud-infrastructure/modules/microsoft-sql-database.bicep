param sqlServerName string
param databaseName string
param location string
param tags object

resource sqlDatabase 'Microsoft.Sql/servers/databases@2023-05-01-preview' = {
  name: '${sqlServerName}/${databaseName}'
  location: location
  tags: tags
  sku: {
    name: 'GP_S_Gen5'
    tier: 'GeneralPurpose'
    family: 'Gen5'
    capacity: 1
  }
  properties: {
    collation: 'SQL_Latin1_General_CP1_CI_AS'
    zoneRedundant: false
    autoPauseDelay: 60
    maxSizeBytes: 1073741824
  }
}
