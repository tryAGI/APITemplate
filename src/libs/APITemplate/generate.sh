#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://apitemplateio.s3.ap-southeast-1.amazonaws.com/redoc_apiv2/apitemplateiov2_api.yaml
python3 - <<'PY'
from pathlib import Path

path = Path("openapi.yaml")
path.write_text(path.read_text(encoding="utf-8").replace("\t", "  "), encoding="utf-8")
PY
autosdk generate openapi.yaml \
  --namespace APITemplate \
  --clientClassName APITemplateClient \
  --targetFramework net10.0 \
  --security-scheme ApiKey:Header:X-API-KEY \
  --output Generated \
  --exclude-deprecated-operations

rm -rf ../../cli/APITemplate.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/APITemplate.CLI \
  --sdk-project ../../libs/APITemplate/APITemplate.csproj \
  --targetFramework net10.0 \
  --namespace APITemplate \
  --clientClassName APITemplateClient \
  --package-id APITemplate.CLI \
  --tool-command-name api-template \
  --user-secrets-id APITemplate.CLI \
  --api-key-env-var APITEMPLATE_API_KEY \
  --base-url-env-var APITEMPLATE_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-KEY
