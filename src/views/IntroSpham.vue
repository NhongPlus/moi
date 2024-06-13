<template>
    <div>
        <product-item />
        <description-product/>
        <global-footer />
    </div>
</template>

<script>
import DescriptionProduct from '../components/DescriptionProduct.vue'
import GlobalFooter from '../components/GlobalFooter.vue'
import ProductItem from '../components/ProductItem.vue'

export default{
    components: { 
        DescriptionProduct ,
        ProductItem,
        GlobalFooter,
    },
    props: {
        productInfo: Object,
        productId: {
            type: String,
            required: true,
        },
    },
}
</script>