#!/usr/bin/env bash
./node_modules/.bin/ncy ./node_modules/mocha/bin/mocha --recursive --require ts-node/register "tests/**/*.test.ts"
