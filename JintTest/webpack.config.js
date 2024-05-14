module.exports = env => {
    return {
        entry: {
            app: './hello.js'
        },
        module: {
            rules: [
                { test: /\.js$/, loader: 'babel-loader' }
            ]
        },
        optimization: {
            minimize: env != 'dev'
        }
    };
};