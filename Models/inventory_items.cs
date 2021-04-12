//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventory_items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inventory_items()
        {
            this.inventory_item_warehouse_details = new HashSet<inventory_item_warehouse_details>();
        }
    
        public int id { get; set; }
        public string itemnum { get; set; }
        public string description { get; set; }
        public Nullable<int> class_id { get; set; }
        public bool taxable { get; set; }
        public Nullable<int> type_id { get; set; }
        public string vendor_part_num { get; set; }
        public Nullable<System.DateTime> last_price_change_date { get; set; }
        public bool @new { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public bool available { get; set; }
        public string image_name { get; set; }
        public byte[] image { get; set; }
        public Nullable<int> color_id { get; set; }
        public Nullable<decimal> avg_box_footage_pack_box_qty { get; set; }
        public Nullable<int> discount_level { get; set; }
        public Nullable<decimal> width { get; set; }
        public Nullable<decimal> height { get; set; }
        public Nullable<decimal> rabbet { get; set; }
        public string notes { get; set; }
        public bool non_stock_item { get; set; }
        public bool discontinued { get; set; }
        public bool special_order { get; set; }
        public int warehouse_id { get; set; }
        public string alt_itemnum { get; set; }
        public Nullable<decimal> box_quantity { get; set; }
        public bool box_quantity_locked { get; set; }
        public Nullable<int> default_vendor_id { get; set; }
        public bool shared_item { get; set; }
        public string item_type { get; set; }
        public System.DateTime created { get; set; }
        public string upc { get; set; }
        public Nullable<int> mat_class_id { get; set; }
        public Nullable<System.DateTime> last_update { get; set; }
        public bool is_deleted { get; set; }
        public string sort_key { get; set; }
        public Nullable<System.DateTime> modified { get; set; }
        public Nullable<bool> actual_vendor { get; set; }
        public string custom1 { get; set; }
        public string custom2 { get; set; }
        public string custom3 { get; set; }
        public string custom4 { get; set; }
        public string custom5 { get; set; }
        public Nullable<int> item_collection_id { get; set; }
        public Nullable<decimal> new_width { get; set; }
        public Nullable<decimal> new_height { get; set; }
        public Nullable<decimal> new_rabbet { get; set; }
        public Nullable<int> item_style_id { get; set; }
        public Nullable<int> item_tag1_id { get; set; }
        public Nullable<int> item_tag2_id { get; set; }
        public Nullable<int> country_of_origin_id { get; set; }
        public Nullable<int> item_finish_id { get; set; }
        public Nullable<int> item_wood_type_id { get; set; }
        public string detail_notes { get; set; }
        public string popup_notes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inventory_item_warehouse_details> inventory_item_warehouse_details { get; set; }
        public virtual inventory_items inventory_items1 { get; set; }
        public virtual inventory_items inventory_items2 { get; set; }
    }
}
