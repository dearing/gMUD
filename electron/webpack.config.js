const VueLoadPlugin = requre('vue-loader/lib/plugin')

export const module = {
    rules: [
        {
            test: /\.vue$/,
            use: 'vue-loader'
        }
    ]
};
export const plugins = [
    new VueLoadPlugin()
];