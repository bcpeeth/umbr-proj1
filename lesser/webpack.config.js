
/**
 * Webpack configuration
 * - for development use: webpack --watch
 * - for production / build process use : webpack -p --env=production --progress
 */

const path = require('path');
const webpack = require('webpack');
const merge = require('webpack-merge');
const autoprefixer = require('autoprefixer');

const HtmlWebpackPlugin = require('html-webpack-plugin');
const BrowserSyncPlugin = require('browser-sync-webpack-plugin');
const OptimizeCssAssetsPlugin = require('optimize-css-assets-webpack-plugin');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
//const TerserPlugin = require('terser-webpack-plugin');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');
const VueLoaderPlugin = require('vue-loader/lib/plugin');
//const BundleAnalyzerPlugin = require('webpack-bundle-analyzer').BundleAnalyzerPlugin;

/**
 * Application state to switch option values within this configuration
 */
let APPSTATE = "debug";


/**
 * Default configuration (production)
 */
const config = {
    mode: 'development',
    entry: {
        main: [
			path.resolve(__dirname, 'Content/js/main.js'),
			path.resolve(__dirname, 'Content/sass/main.scss'),
        ]
    },
    output: {
        path: path.resolve(__dirname, 'Content/build/'),
        filename: '[name].build.js',
        publicPath: '../../Content'
    },
    optimization: {
        splitChunks: {
            cacheGroups: {
                vendor: {
                    test: /node_modules/,
                    name: "vendor",
                    chunks: "initial",
                    enforce: true
                }
            }
        }
    },
    module: {
        rules: [
            // {
            //     test: /\.vue$/,
            //     loader: 'vue-loader'
            // },
            {
                test: /\.(sa|sc|c)ss$/,
                use: [
                    MiniCssExtractPlugin.loader,
                    {
                        loader: 'css-loader',
                        options: {
                            autoprefixer: true,
                            importLoaders: 2
                        }
                    },
                    {
                        loader: 'postcss-loader',
                        options: {
                            plugins: () => [(
                               autoprefixer({
                                   'browsers': ['>0.25%', 'not ie < 10']
                               })
                            )]
                        }
                    },
                    {
                        loader: 'sass-loader',
                        options: {
                            includePaths: [
                                path.resolve(__dirname, 'node_modules'),
                            ]
                        }
                    }
                ]
            },
            {
                test: /\.(jpg|jpeg|gif|png|svg)$/,
                loader: 'file-loader?limit=2048',
                options: {
                    name: '/img/[name].[ext]',
                    emitFile: false
                }
            },
            {
                test: /\.(woff|woff2|eot|ttf)$/,
                loader: 'file-loader?limit=2048',
                options: {
                    name: '/fonts/[name].[ext]',
                    emitFile: false
                }
            },
            // we use babel loader in both development and production to be able to use modular import of ElementUI modules during dev
            {
                test: /\.js$/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        babelrc: false,
                        cacheDirectory: true,
                        presets: [['@babel/preset-env', {
                            useBuiltIns: "entry",
                            targets: {
                                'browsers': ['>0.25%', 'not ie < 10']
                            },
                            modules: false
                        }]]
                        // plugins: [['component', { 'libraryName': 'element-ui', 'styleLibraryName': 'theme-chalk' }]]
                    }
                }
            }
        ]
    },
    plugins: [
        new MiniCssExtractPlugin({
            filename: '../../Content/css/[name].css'
        }),
        new webpack.ProvidePlugin({
            _: 'underscore'
        }),
        // new VueLoaderPlugin()
    ],
    externals: {
        TweenLite: 'TweenLite' // prevents conflict references when importing
    },
    resolve: {
        alias: {
            // 'vue$': 'vue/dist/vue.esm.js'
        }
    }
};

/**
 * Development configuration, to merge with default config
 * Note: use fastest source map available (https://webpack.js.org/configuration/devtool/)
 */
const development = {
    devtool: 'cheap-eval-source-map',
    module: {
        rules: [

        ]
    },
    plugins: [
        new BrowserSyncPlugin({
            host: 'localhost',
            port: 3000,
            // proxy: 'zorgthuisnu.w3sdev.nl',
            files: ['Views/*.cshtml', 'Views/**/*.cshtml'],
            open: false,
            reloadDebounce: 1000,
            injectChanges: false
        })
        //,new BundleAnalyzerPlugin()
    ]
}

/**
 * Production configuration, to merge with default config
 * Note: Babel targets should be identical to css autoprefixer values!
 */
const production = {
    mode: 'production',
    optimization: {
        splitChunks: {
            cacheGroups: {
                styles: {
                    name: 'main',
                    test: /\.(sa|sc|c)ss$/,
                    chunks: 'all',
                    enforce: true
                }
            }
        },
        minimizer: [
            new UglifyJsPlugin({
                cache: true,
                parallel: true,
                extractComments: false,
                uglifyOptions: {
                    compress: {
                        drop_console: true
                    },
                    output: {
                        comments: false
                    }
                }
            })
        ]
    },
    performance: {
        hints: false
    },
    module: {
        rules: [
            {
                test: /\.js$/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        babelrc: false,
                        cacheDirectory: true,
                        presets: [['@babel/preset-env', {
                            useBuiltIns: "entry",
                            targets: {
                                'browsers': ['>0.25%', 'not ie < 10']
                            },
                            modules: false
                        }]],
                        plugins: [['component', { 'libraryName': 'element-ui', 'styleLibraryName': 'theme-chalk' }]]
                    }
                }
            }
        ]
    },
    plugins: [
		new OptimizeCssAssetsPlugin({
		    cssProcessor: require('cssnano'),
		    cssProcessorOptions: { discardComments: { removeAll: true } },
		    canPrint: true
		})
    ]
}

/**
 * Return the config to webpack module
 */
module.exports = function (env) {
    if (env === 'production') {
        APPSTATE = 'production';
        return merge.smart(config, production);
    }
    return merge.smart(config, development);
};

//var info = autoprefixer().info();
//console.log(info);