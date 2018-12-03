var path = require("path");
var webpack = require("webpack");
const Dotenv = require('dotenv-webpack');

var SRC_DIR = path.resolve(__dirname, "src");
var DIST_DIR = path.resolve(__dirname, "dist");

var config = {
  entry: ['babel-polyfill',SRC_DIR + "\\index.js"],
  output: {
    path: DIST_DIR + "\\app",
    filename: "bundle.js",
    publicPath: "/app/"
  },
  module: {
    loaders: [
      {
        test: /.js?/,
        loader: 'babel-loader',
        exclude: path.resolve(__dirname, "node_modules"),
        query:{
            presets: ['react', 'env', 'stage-2']
          },
        },
        {
          test: /\.(less|css)$/,
          loader: ['style-loader', 'css-loader','less-loader']
        },
        {
          test: /\.(eot|svg|ttf|woff|woff2)$/,
          loader: 'file-loader'
        },
        {
          test: /\.(pdf|jpg|jpeg|png|gif|svg|ico)$/,
          loader: ['url-loader']
        }
    ]
  },
  plugins: [
    new Dotenv({
      path: '.env',
    }),
     new webpack.DefinePlugin({
       'process.env.NODE_ENV': JSON.stringify('development')
     })
  ]
}

module.exports = config
